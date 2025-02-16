using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DocumentosOrtobio
{
    public partial class DocumentManagementForm : Form
    {
        private readonly string basePath;
        private readonly Dictionary<string, List<string>> categoriesWithSubmenus;

        public DocumentManagementForm(string basePath, Dictionary<string, List<string>> categoriesWithSubmenus)
        {
            this.basePath = basePath;
            this.categoriesWithSubmenus = categoriesWithSubmenus;
            InitializeComponent();
            InitializeComboBoxes(cmbCategory, cmbSubCategory);
            InitializeComboBoxes(comboBoxCategorySearch, comboBoxSubCategorySearch);
        }

        private void InitializeComboBoxes(ComboBox comboBoxCategory, ComboBox comboBoxSubCategory)
        {
            comboBoxCategory.Items.AddRange(categoriesWithSubmenus.Keys.ToArray());
            comboBoxCategory.SelectedIndexChanged += (sender, e) =>
            {
                var selectedCategory = comboBoxCategory.SelectedItem.ToString();
                comboBoxSubCategory.Items.Clear();
                if (categoriesWithSubmenus.ContainsKey(selectedCategory))
                {
                    comboBoxSubCategory.Items.AddRange(categoriesWithSubmenus[selectedCategory].ToArray());
                }
            };
        }

        private void BtnLoadFiles_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lstFiles.Items.Clear();
                    foreach (var file in openFileDialog.FileNames)
                    {
                        lstFiles.Items.Add(file);
                    }
                    ActivityLogger.Log($"Carregou arquivos: {string.Join(", ", openFileDialog.FileNames.Select(Path.GetFileName))}");
                }
            }
        }

        private void BtnSaveFiles_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory.SelectedItem == null || cmbSubCategory.SelectedItem == null)
                {
                    MessageBox.Show("Selecione uma categoria e uma subcategoria.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var selectedCategory = cmbCategory.SelectedItem.ToString();
                var selectedSubCategory = cmbSubCategory.SelectedItem.ToString();
                var targetPath = Path.Combine(basePath, selectedCategory, selectedSubCategory);

                if (!Directory.Exists(targetPath))
                {
                    MessageBox.Show($"O caminho de destino não existe: {targetPath}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (var file in lstFiles.Items)
                {
                    var fileName = Path.GetFileName(file.ToString());
                    var destPath = Path.Combine(targetPath, fileName);

                    if (File.Exists(destPath))
                    {
                        var result = MessageBox.Show($"O arquivo '{fileName}' já existe na pasta de destino. Deseja substituí-lo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            continue;
                        }
                    }

                    File.Copy(file.ToString(), destPath, true);
                }

                ActivityLogger.Log($"Arquivos salvos na categoria '{selectedCategory}' e subcategoria '{selectedSubCategory}'.");
                MessageBox.Show("Arquivos salvos com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar arquivos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeleteFiles_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItems.Count > 0)
            {
                var confirmResult = MessageBox.Show("Tem certeza de que deseja excluir os documentos selecionados?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    foreach (var selectedItem in listBoxFiles.SelectedItems)
                    {
                        var fileName = selectedItem.ToString();
                        var filePath = GetFilePath(fileName);
                        if (filePath != null)
                        {
                            File.Delete(filePath);
                        }
                    }
                    ActivityLogger.Log($"Excluiu documentos: {string.Join(", ", listBoxFiles.SelectedItems.Cast<string>())}");
                    MessageBox.Show("Documentos excluídos com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listBoxFiles.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("Nenhum documento selecionado para exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClearFiles_Click(object sender, EventArgs e)
        {
            lstFiles.Items.Clear();
            ActivityLogger.Log("Limpou a lista de arquivos.");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var searchPattern = textBoxSearch.Text;
            var selectedCategory = comboBoxCategorySearch.SelectedItem?.ToString() ?? "All Categories";
            var selectedSubCategory = comboBoxSubCategorySearch.SelectedItem?.ToString() ?? "All Subcategories";

            listBoxFiles.Items.Clear();

            if (selectedCategory == "All Categories")
            {
                foreach (var category in categoriesWithSubmenus.Keys)
                {
                    SearchFiles(category, selectedSubCategory, searchPattern, listBoxFiles);
                }
            }
            else
            {
                SearchFiles(selectedCategory, selectedSubCategory, searchPattern, listBoxFiles);
            }

            ActivityLogger.Log($"Realizou pesquisa por '{searchPattern}' na categoria '{selectedCategory}' e subcategoria '{selectedSubCategory}'.");
        }

        private void SearchFiles(string category, string subCategory, string searchPattern, ListBox listBox)
        {
            if (subCategory == "All Subcategories")
            {
                foreach (var subCat in categoriesWithSubmenus[category])
                {
                    string subCategoryPath = Path.Combine(basePath, category, subCat);
                    string[] files = Directory.GetFiles(subCategoryPath, "*" + searchPattern + "*.*", SearchOption.AllDirectories);
                    foreach (string file in files)
                    {
                        listBox.Items.Add(Path.GetFileName(file));
                    }
                }
            }
            else
            {
                string subCategoryPath = Path.Combine(basePath, category, subCategory);
                string[] files = Directory.GetFiles(subCategoryPath, "*" + searchPattern + "*.*", SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    listBox.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private string GetFilePath(string fileName)
        {
            foreach (var category in categoriesWithSubmenus.Keys)
            {
                string categoryPath = Path.Combine(basePath, category);
                var files = Directory.GetFiles(categoryPath, fileName, SearchOption.AllDirectories);
                if (files.Any())
                {
                    return files.First();
                }
                foreach (var subCategory in categoriesWithSubmenus[category])
                {
                    var subCategoryPath = Path.Combine(categoryPath, subCategory);
                    files = Directory.GetFiles(subCategoryPath, fileName, SearchOption.AllDirectories);
                    if (files.Any())
                    {
                        return files.First();
                    }
                }
            }
            return null;
        }
    }
}