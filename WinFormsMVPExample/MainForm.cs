using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsMVPExample
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 處理登入按鈕事件用的Action, 請在MainPresenter進行連結
        /// </summary>
        public event Action<string, string> LogInAction;

        /// <summary>
        /// 處理忘記密碼按鈕事件用的EventHandler, 請在MainPresenter進行連結
        /// </summary>
        public event EventHandler ForgotPasswordEvent;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogInAction.Invoke(tbAccount.Text, tbPassword.Text);
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordEvent.Invoke(sender, e);
        }
    }
}
