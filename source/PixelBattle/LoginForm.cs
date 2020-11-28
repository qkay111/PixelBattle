using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelBattle
{
    public partial class LoginForm : Form
    {
        private MainForm mainForm;

        public LoginForm()
        {
            InitializeComponent();
            mainForm = new MainForm(this);
        }

        private void tryLoginButton_Click(object sender, EventArgs e)
        {
            if (this.loginTextBox.Text.Length != 0 && this.passwordTextBox.Text.Length != 0 && ServerEmu.TryLogin(this.loginTextBox.Text, this.passwordTextBox.Text))
            {
                mainForm.setUsername(ServerEmu.getUsername());
                mainForm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Error",
                                "Login Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);

            this.loginTextBox.Clear();
            this.passwordTextBox.Clear();
        }
    }
}
