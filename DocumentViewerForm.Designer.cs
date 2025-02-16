namespace DocumentosOrtobio
{
    partial class DocumentViewerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxFiles;
        private PdfiumViewer.PdfViewer pdfViewer;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxSubCategory;
        private System.Windows.Forms.Button btnToggleDarkMode;
        private System.Windows.Forms.Button btnVisualizacaoDupla;

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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.pdfViewer = new PdfiumViewer.PdfViewer();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxSubCategory = new System.Windows.Forms.ComboBox();
            this.btnToggleDarkMode = new System.Windows.Forms.Button();
            this.btnVisualizacaoDupla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 43);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(126, 20);
            this.textBoxSearch.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(144, 41);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(12, 71);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(126, 940);
            this.listBoxFiles.TabIndex = 4;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.ListBoxFiles_SelectedIndexChanged);
            // 
            // pdfViewer
            // 
            this.pdfViewer.AutoSize = true;
            this.pdfViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pdfViewer.Location = new System.Drawing.Point(144, 71);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.Size = new System.Drawing.Size(1684, 940);
            this.pdfViewer.TabIndex = 6;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1797, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 36);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(1544, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(85, 36);
            this.btnSettings.TabIndex = 10;
            this.btnSettings.Text = "Configurações";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(12, 12);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(126, 21);
            this.comboBoxCategory.TabIndex = 11;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategory_SelectedIndexChanged);
            // 
            // comboBoxSubCategory
            // 
            this.comboBoxSubCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubCategory.FormattingEnabled = true;
            this.comboBoxSubCategory.Location = new System.Drawing.Point(144, 12);
            this.comboBoxSubCategory.Name = "comboBoxSubCategory";
            this.comboBoxSubCategory.Size = new System.Drawing.Size(126, 21);
            this.comboBoxSubCategory.TabIndex = 12;
            // 
            // btnToggleDarkMode
            // 
            this.btnToggleDarkMode.Location = new System.Drawing.Point(1716, 12);
            this.btnToggleDarkMode.Name = "btnToggleDarkMode";
            this.btnToggleDarkMode.Size = new System.Drawing.Size(75, 36);
            this.btnToggleDarkMode.TabIndex = 15;
            this.btnToggleDarkMode.Text = "Modo Escuro";
            this.btnToggleDarkMode.UseVisualStyleBackColor = true;
            this.btnToggleDarkMode.Click += new System.EventHandler(this.BtnToggleDarkMode_Click);
            // 
            // btnVisualizacaoDupla
            // 
            this.btnVisualizacaoDupla.Location = new System.Drawing.Point(1635, 12);
            this.btnVisualizacaoDupla.Name = "btnVisualizacaoDupla";
            this.btnVisualizacaoDupla.Size = new System.Drawing.Size(75, 36);
            this.btnVisualizacaoDupla.TabIndex = 16;
            this.btnVisualizacaoDupla.Text = "Visualização Dupla";
            this.btnVisualizacaoDupla.UseVisualStyleBackColor = true;
            this.btnVisualizacaoDupla.Click += new System.EventHandler(this.BtnVisualizacaoDupla_Click);
            // 
            // DocumentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 1061);
            this.Controls.Add(this.btnVisualizacaoDupla);
            this.Controls.Add(this.btnToggleDarkMode);
            this.Controls.Add(this.comboBoxSubCategory);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pdfViewer);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "DocumentViewerForm";
            this.Text = "Visualizador de Documentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DocumentViewerForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}