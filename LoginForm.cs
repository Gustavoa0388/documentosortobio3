using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DocumentosOrtobio
{
    public partial class LoginForm : Form
    {
        private Dictionary<string, bool> userLoginStatus;
        private readonly string basePath = @"\\D4MDP574\Doc Viewer\Banco de dados";

        public LoginForm()
        {
            InitializeComponent();
            LoadUserLoginStatus();
        }

        private void LoadUserLoginStatus()
        {
            string userLoginStatusFilePath = Path.Combine(basePath, "userLoginStatus.json");

            if (File.Exists(userLoginStatusFilePath))
            {
                userLoginStatus = JsonConvert.DeserializeObject<Dictionary<string, bool>>(File.ReadAllText(userLoginStatusFilePath));
            }
            else
            {
                userLoginStatus = new Dictionary<string, bool>();
            }
        }

        private void SaveUserLoginStatus()
        {
            string userLoginStatusFilePath = Path.Combine(basePath, "userLoginStatus.json");
            File.WriteAllText(userLoginStatusFilePath, JsonConvert.SerializeObject(userLoginStatus, Formatting.Indented));
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string usersFilePath = Path.Combine(basePath, "users.json");

            var users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(usersFilePath));
            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                if (userLoginStatus.ContainsKey(username) && userLoginStatus[username])
                {
                    MessageBox.Show("O usuário já está logado em outro terminal.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                userLoginStatus[username] = true;
                SaveUserLoginStatus();

                SaveCurrentUserDetails(username, GetLocalIPAddress(), DateTime.Now);

                Form1 mainForm = new Form1(user);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciais inválidas.");
            }
        }

        private void SaveCurrentUserDetails(string username, string ip, DateTime loginTime)
        {
            string currentUserDetailsFilePath = Path.Combine(basePath, "currentUsers.json");
            var currentUserDetails = File.Exists(currentUserDetailsFilePath)
                ? JsonConvert.DeserializeObject<List<UserLoginDetail>>(File.ReadAllText(currentUserDetailsFilePath))
                : new List<UserLoginDetail>();

            currentUserDetails.Add(new UserLoginDetail
            {
                Username = username,
                IPAddress = ip,
                LoginTime = loginTime.ToString("dd-MM-yyyy HH:mm:ss"),
                OnlineTime = TimeSpan.Zero.ToString(@"hh\:mm\:ss") // Inicialmente zero, será atualizado posteriormente
            });

            File.WriteAllText(currentUserDetailsFilePath, JsonConvert.SerializeObject(currentUserDetails, Formatting.Indented));
        }

        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "Local IP Address Not Found!";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Fecha o aplicativo completamente
            Application.Exit();
        }
    }
}