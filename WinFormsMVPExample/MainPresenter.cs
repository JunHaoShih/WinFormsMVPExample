using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsMVPExample
{
    public class MainPresenter
    {
        private readonly MainForm mainForm;

        public MainPresenter(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeLinks();
        }

        private void InitializeLinks()
        {
            mainForm.LogInAction += LogIn;
            mainForm.ForgotPasswordEvent += ForgotPassword;
        }

        private void LogIn(string account, string password)
        {
            MessageBox.Show($"Log in with account: {account}");
        }

        private void ForgotPassword(object sender, EventArgs e)
        {
            MessageBox.Show($"I forgot password!");
        }
    }
}
