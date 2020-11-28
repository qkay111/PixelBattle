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
    public partial class ShopForm : Form
    {
        MainForm mainForm;
        private long basketMoney = 0;

        public ShopForm(MainForm mf)
        {
            InitializeComponent();

            mainForm = mf;

            this.basketMoneyLabel.Text = basketMoney.ToString();
            this.coinsCountLabel.Text = ServerEmu.getCoins().ToString();
        }

        private void ShopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ServerEmu.Close)
                e.Cancel = true;
            mainForm.Show();
            this.Hide();
        }

        private void buyCurrencyButton_Click(object sender, EventArgs e)
        {

        }

        private void buyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
