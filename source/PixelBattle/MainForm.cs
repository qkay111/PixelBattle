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
    public partial class MainForm : Form
    {
        private LoginForm loginForm;
        private ColourPickForm colourPickForm = new ColourPickForm();
        private ShopForm shopForm;
        private Colour colour = new Colour();

        public MainForm(LoginForm lf)
        {
            InitializeComponent();

            loginForm = lf;
            shopForm = new ShopForm(this);

            colour.CurrentColour = Constants.Colours.WHITE;
            this.shopButton.Image = (Image)(new Bitmap("D://shopImg.png"));

            colourPickForm.colourB += new ColourPickForm.colourBHandler(colourB);
        }

        public void setUsername(string un)
        {
            this.usernameLabel.Text = un;
        }

        private void currentColourButton_Click(object sender, EventArgs e)
        {
            colourPickForm.Show();
        }

        private void colourB(object sender, EventArgs eventArgs)
        {
            colour.CurrentColour = colourPickForm.GetColour();
            this.currentColourButton.BackColor = Color.FromArgb(colourPickForm.GetColour()[0],
                                                                colourPickForm.GetColour()[1],
                                                                colourPickForm.GetColour()[2]);
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            colourPickForm.Hide();
            shopForm.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            colourPickForm.Hide();
            this.Hide();
        }

        private void logoutButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.logoutButton.ForeColor = Color.FromArgb(175, 50, 59);
            this.logoutButton.FlatAppearance.BorderColor = Color.FromArgb(175, 50, 59);
        }

        private void logoutButton_MouseMove(object sender, MouseEventArgs e)
        {
            this.logoutButton.ForeColor = Color.FromArgb(201, 194, 178);
            this.logoutButton.FlatAppearance.BorderColor = Color.FromArgb(201, 194, 178);
        }

        private void logoutButton_MouseLeave(object sender, EventArgs e)
        {
            this.logoutButton.ForeColor = Color.FromArgb(215, 199, 112);
            this.logoutButton.FlatAppearance.BorderColor = Color.FromArgb(215, 199, 112);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ServerEmu.Close = true;
            Application.Exit();
        }
    }
}
