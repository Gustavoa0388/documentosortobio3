using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace DocumentosOrtobio
{
    public partial class SettingsForm : Form
    {
        private readonly string basePath = @"\\D4MDP574\Doc Viewer\Documentos";
        private readonly Dictionary<string, List<string>> categoriesWithSubmenus = new Dictionary<string, List<string>>
        {
            { "Documentos Vigentes", new List<string> { "DT", "EC", "EMF", "GR", "NP", "RM", "RMP", "SF" } },
            { "Documentos Obsoletos", new List<string> { "DT", "EC", "EMF", "GR", "NP", "RM", "RMP", "SF" } },
           { "Validações", new List < string > { "Validações" } }
        };

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void BtnManageDocuments_Click(object sender, EventArgs e)
        {
            if (CurrentUserIsAdmin())
            {
                var docManagementForm = new DocumentManagementForm(basePath, categoriesWithSubmenus);
                docManagementForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Acesso negado. Apenas administradores podem acessar esta funcionalidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CurrentUserIsAdmin()
        {
            // Implementar a lógica para verificar se o usuário atual é administrador
            // Por exemplo, verificando um campo na classe de usuário atual
            return true; // Substituir pela lógica real
        }

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            if (createUserForm.ShowDialog() == DialogResult.OK)
            {
                LogActivity("Criou um novo usuário.");
            }
        }

        private void BtnGenerateLogReport_Click(object sender, EventArgs e)
        {
            GenerateLogReport();
        }

        private void GenerateLogReport()
        {
            string logReportPath = Path.Combine(basePath, "log_report.txt");
            string logContent = File.ReadAllText(Path.Combine(basePath, "activity_log.txt"));
            File.WriteAllText(logReportPath, logContent);
            MessageBox.Show($"Relatório de logs gerado em: {logReportPath}");
            LogActivity("Gerou um relatório de logs.");
        }

        private void BtnOnlineUsers_Click(object sender, EventArgs e)
        {
            OnlineUsersForm onlineUsersForm = new OnlineUsersForm();
            onlineUsersForm.ShowDialog();
            LogActivity("Abriu o painel de controle de usuários online.");
        }

        private void BtnClearLog_Click(object sender, EventArgs e)
        {
            try
            {
                string logFilePath = Path.Combine(basePath, "activity_log.txt");
                if (File.Exists(logFilePath))
                {
                    File.WriteAllText(logFilePath, string.Empty);
                    MessageBox.Show("Log de atividades foi limpo.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Log de atividades não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao limpar log: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogActivity(string activity)
        {
            string logFilePath = Path.Combine(basePath, "activity_log.txt");
            string logMessage = $"{DateTime.Now:dd-MM-yyyy HH:mm:ss} - {GetLocalIPAddress()} - {Environment.UserName} - {activity}{Environment.NewLine}";
            File.AppendAllText(logFilePath, logMessage);
        }

        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "Local IP Address Not Found!";
        }
    }
}