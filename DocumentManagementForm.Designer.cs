namespace DocumentosOrtobio
{
    partial class DocumentManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLoadFiles;
        private System.Windows.Forms.Button btnSaveFiles;
        private System.Windows.Forms.Button btnDeleteFiles;
        private System.Windows.Forms.Button btnClearFiles;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbSubCategory;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBoxCategorySearch;
        private System.Windows.Forms.ComboBox comboBoxSubCategorySearch;
        private System.Windows.Forms.ListBox listBoxFiles;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnLoadFiles = new System.Windows.Forms.Button();
            this.btnSaveFiles = new System.Windows.Forms.Button();
            this.btnDeleteFiles = new System.Windows.Forms.Button();
            this.btnClearFiles = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbSubCategory = new System.Windows.Forms.ComboBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBoxCategorySearch = new System.Windows.Forms.ComboBox();
            this.comboBoxSubCategorySearch = new System.Windows.Forms.ComboBox();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.Location = new System.Drawing.Point(21, 12);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Size = new System.Drawing.Size(150, 23);
            this.btnLoadFiles.TabIndex = 0;
            this.btnLoadFiles.Text = "Carregar Arquivos";
            this.btnLoadFiles.UseVisualStyleBackColor = true;
            this.btnLoadFiles.Click += new System.EventHandler(this.BtnLoadFiles_Click);
            // 
            // btnSaveFiles
            // 
            this.btnSaveFiles.Location = new System.Drawing.Point(21, 339);
            this.btnSaveFiles.Name = "btnSaveFiles";
            this.btnSaveFiles.Size = new System.Drawing.Size(150, 23);
            this.btnSaveFiles.TabIndex = 4;
            this.btnSaveFiles.Text = "Salvar Arquivos";
            this.btnSaveFiles.UseVisualStyleBackColor = true;
            this.btnSaveFiles.Click += new System.EventHandler(this.BtnSaveFiles_Click);
            // 
            // btnDeleteFiles
            // 
            this.btnDeleteFiles.Location = new System.Drawing.Point(110, 368);
            this.btnDeleteFiles.Name = "btnDeleteFiles";
            this.btnDeleteFiles.Size = new System.Drawing.Size(150, 23);
            this.btnDeleteFiles.TabIndex = 5;
            this.btnDeleteFiles.Text = "Excluir Arquivos";
            this.btnDeleteFiles.UseVisualStyleBackColor = true;
            this.btnDeleteFiles.Click += new System.EventHandler(this.BtnDeleteFiles_Click);
            // 
            // btnClearFiles
            // 
            this.btnClearFiles.Location = new System.Drawing.Point(193, 339);
            this.btnClearFiles.Name = "btnClearFiles";
            this.btnClearFiles.Size = new System.Drawing.Size(150, 23);
            this.btnClearFiles.TabIndex = 7;
            this.btnClearFiles.Text = "Limpar Lista de Arquivos";
            this.btnClearFiles.UseVisualStyleBackColor = true;
            this.btnClearFiles.Click += new System.EventHandler(this.BtnClearFiles_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Location = new System.Drawing.Point(21, 41);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(322, 21);
            this.cmbCategory.TabIndex = 1;
            //this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.CmbCategory_SelectedIndexChanged);
            // 
            // cmbSubCategory
            // 
            this.cmbSubCategory.Location = new System.Drawing.Point(21, 68);
            this.cmbSubCategory.Name = "cmbSubCategory";
            this.cmbSubCategory.Size = new System.Drawing.Size(322, 21);
            this.cmbSubCategory.TabIndex = 2;
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(21, 95);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(322, 238);
            this.lstFiles.TabIndex = 3;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(360, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(300, 20);
            this.textBoxSearch.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(680, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // comboBoxCategorySearch
            // 
            this.comboBoxCategorySearch.FormattingEnabled = true;
            this.comboBoxCategorySearch.Location = new System.Drawing.Point(360, 41);
            this.comboBoxCategorySearch.Name = "comboBoxCategorySearch";
            this.comboBoxCategorySearch.Size = new System.Drawing.Size(150, 21);
            this.comboBoxCategorySearch.TabIndex = 10;
            //this.comboBoxCategorySearch.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategorySearch_SelectedIndexChanged);
            // 
            // comboBoxSubCategorySearch
            // 
            this.comboBoxSubCategorySearch.FormattingEnabled = true;
            this.comboBoxSubCategorySearch.Location = new System.Drawing.Point(520, 41);
            this.comboBoxSubCategorySearch.Name = "comboBoxSubCategorySearch";
            this.comboBoxSubCategorySearch.Size = new System.Drawing.Size(150, 21);
            this.comboBoxSubCategorySearch.TabIndex = 11;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(360, 68);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxFiles.Size = new System.Drawing.Size(395, 264);
            this.listBoxFiles.TabIndex = 12;
            // 
            // DocumentManagementForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.comboBoxSubCategorySearch);
            this.Controls.Add(this.comboBoxCategorySearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnLoadFiles);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbSubCategory);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.btnSaveFiles);
            this.Controls.Add(this.btnDeleteFiles);
            this.Controls.Add(this.btnClearFiles);
            this.Name = "DocumentManagementForm";
            this.Text = "Gerenciamento de Documentos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}