namespace DocumentosOrtobio
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnGenerateLogReport;
        private System.Windows.Forms.Button btnOnlineUsers;
        private System.Windows.Forms.Button btnManageDocuments;
        private System.Windows.Forms.Button btnClearLog;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnGenerateLogReport = new System.Windows.Forms.Button();
            this.btnOnlineUsers = new System.Windows.Forms.Button();
            this.btnManageDocuments = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(38, 167);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(120, 23);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Criar Usuário";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.BtnCreateUser_Click);
            // 
            // btnGenerateLogReport
            // 
            this.btnGenerateLogReport.Location = new System.Drawing.Point(38, 225);
            this.btnGenerateLogReport.Name = "btnGenerateLogReport";
            this.btnGenerateLogReport.Size = new System.Drawing.Size(120, 23);
            this.btnGenerateLogReport.TabIndex = 1;
            this.btnGenerateLogReport.Text = "Gerar Logs";
            this.btnGenerateLogReport.UseVisualStyleBackColor = true;
            this.btnGenerateLogReport.Click += new System.EventHandler(this.BtnGenerateLogReport_Click);
            // 
            // btnOnlineUsers
            // 
            this.btnOnlineUsers.Location = new System.Drawing.Point(38, 196);
            this.btnOnlineUsers.Name = "btnOnlineUsers";
            this.btnOnlineUsers.Size = new System.Drawing.Size(120, 23);
            this.btnOnlineUsers.TabIndex = 2;
            this.btnOnlineUsers.Text = "Usuários Online";
            this.btnOnlineUsers.UseVisualStyleBackColor = true;
            this.btnOnlineUsers.Click += new System.EventHandler(this.BtnOnlineUsers_Click);
            // 
            // btnManageDocuments
            // 
            this.btnManageDocuments.Location = new System.Drawing.Point(38, 283);
            this.btnManageDocuments.Name = "btnManageDocuments";
            this.btnManageDocuments.Size = new System.Drawing.Size(120, 34);
            this.btnManageDocuments.TabIndex = 3;
            this.btnManageDocuments.Text = "Gerenciamento de Documentos";
            this.btnManageDocuments.UseVisualStyleBackColor = true;
            this.btnManageDocuments.Click += new System.EventHandler(this.BtnManageDocuments_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(38, 254);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(120, 23);
            this.btnClearLog.TabIndex = 4;
            this.btnClearLog.Text = "Limpar Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.BtnClearLog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // SettingsForm
            // 
            this.ClientSize = new System.Drawing.Size(197, 330);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnManageDocuments);
            this.Controls.Add(this.btnOnlineUsers);
            this.Controls.Add(this.btnGenerateLogReport);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de Configurações";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}