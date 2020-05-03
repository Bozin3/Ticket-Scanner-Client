using System;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketDataHandler;
using TicketDataHandler.Models;
using TicketDataHandler.Responses;

namespace TicketScannerClient
{
    public partial class LoginForm : Form
    {
        private Auth authHandler;

        public LoginForm()
        {

            HttpClientBuilder.Init();
            authHandler = new Auth();
            InitializeComponent();

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            await PerformLoginAction();
        }

        private async Task PerformLoginAction()
        {
            if (ValidateControls())
            {
                var clientCreds = new ClientCreds()
                {
                    Clientname = tbClientName.Text,
                    Password = tbPassword.Text
                };

                AuthResponse authResponse = await authHandler.Authenticate(clientCreds);
                if (authResponse == null)
                {
                    MessageBox.Show("Auth failed, response is null");
                }
                else
                {
                    if (authResponse.Error)
                    {
                        MessageBox.Show("Auth error, message: " + authResponse.Message);
                    }
                    else
                    {
                        Core.Auth = authResponse;
                        TicketScannerForm mainForm = new TicketScannerForm();
                        mainForm.Show();
                    }
                }

            }
        }

        private bool ValidateControls()
        {
            if (tbClientName.Text.Equals(""))
            {
                MessageBox.Show("Please provide client name!");
                return false;
            }

            if (tbPassword.Text.Equals(""))
            {
                MessageBox.Show("Please provide password!");
                return false;
            }

            return true;
        }

        private async void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                await PerformLoginAction();
            }
        }

        private async void tbClientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                await PerformLoginAction();
            }
        }

        private async void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                await PerformLoginAction();
            }
        }
    }
}
