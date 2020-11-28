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
    public partial class ColourPickForm : Form
    {
        private Colour colour = new Colour();
        public int[] GetColour()
        {
            return colour.CurrentColour;
        }

        public event colourBHandler colourB;
        public delegate void colourBHandler(object sender, EventArgs eventArgs);

        public ColourPickForm()
        {
            InitializeComponent();

            colour.CurrentColour = Constants.Colours.WHITE;

            this.redButton.BackColor = Color.FromArgb(Constants.Colours.RED[0], Constants.Colours.RED[1], Constants.Colours.RED[2]);
            this.greenButton.BackColor = Color.FromArgb(Constants.Colours.GREEN[0], Constants.Colours.GREEN[1], Constants.Colours.GREEN[2]);
            this.blueButton.BackColor = Color.FromArgb(Constants.Colours.BLUE[0], Constants.Colours.BLUE[1], Constants.Colours.BLUE[2]);
            this.whiteButton.BackColor = Color.FromArgb(Constants.Colours.WHITE[0], Constants.Colours.WHITE[1], Constants.Colours.WHITE[2]);
            this.blackButton.BackColor = Color.FromArgb(Constants.Colours.BLACK[0], Constants.Colours.BLACK[1], Constants.Colours.BLACK[2]);
            this.orangeButton.BackColor = Color.FromArgb(Constants.Colours.ORANGE[0], Constants.Colours.ORANGE[1], Constants.Colours.ORANGE[2]);
            this.purpleButton.BackColor = Color.FromArgb(Constants.Colours.PURPLE[0], Constants.Colours.PURPLE[1], Constants.Colours.PURPLE[2]);
            this.yellowButton.BackColor = Color.FromArgb(Constants.Colours.YELLOW[0], Constants.Colours.YELLOW[1], Constants.Colours.YELLOW[2]);
            this.lGreenButton.BackColor = Color.FromArgb(Constants.Colours.LIGHT_GREEN[0], Constants.Colours.LIGHT_GREEN[1], Constants.Colours.LIGHT_GREEN[2]);
            this.lBlueButton.BackColor = Color.FromArgb(Constants.Colours.LIGHT_BLUE[0], Constants.Colours.LIGHT_BLUE[1], Constants.Colours.LIGHT_BLUE[2]);
            this.pinkButton.BackColor = Color.FromArgb(Constants.Colours.PINK[0], Constants.Colours.PINK[1], Constants.Colours.PINK[2]);
            this.grayButton.BackColor = Color.FromArgb(Constants.Colours.GRAY[0], Constants.Colours.GRAY[1], Constants.Colours.GRAY[2]);

            UpdateColours();
        }

        public void UpdateColours()
        {
            Constants.ColoursIndexes i = 0;
            foreach (bool tmp in ServerEmu.availableColours)
            {
                switch (i++)
                {
                    case Constants.ColoursIndexes.RED:
                        if (tmp) this.redButton.Show();
                        else this.redButton.Hide();
                        break;
                    case Constants.ColoursIndexes.GREEN:
                        if (tmp) this.greenButton.Show();
                        else this.greenButton.Hide();
                        break;
                    case Constants.ColoursIndexes.BLUE:
                        if (tmp) this.blueButton.Show();
                        else this.blueButton.Hide();
                        break;
                    case Constants.ColoursIndexes.WHITE:
                        if (tmp) this.whiteButton.Show();
                        else this.whiteButton.Hide();
                        break;
                    case Constants.ColoursIndexes.BLACK:
                        if (tmp) this.blackButton.Show();
                        else this.blackButton.Hide();
                        break;
                    case Constants.ColoursIndexes.ORANGE:
                        if (tmp) this.orangeButton.Show();
                        else this.orangeButton.Hide();
                        break;
                    case Constants.ColoursIndexes.PURPLE:
                        if (tmp) this.purpleButton.Show();
                        else this.purpleButton.Hide();
                        break;
                    case Constants.ColoursIndexes.YELLOW:
                        if (tmp) this.yellowButton.Show();
                        else this.yellowButton.Hide();
                        break;
                    case Constants.ColoursIndexes.LIGHT_GREEN:
                        if (tmp) this.lGreenButton.Show();
                        else this.lGreenButton.Hide();
                        break;
                    case Constants.ColoursIndexes.LIGHT_BLUE:
                        if (tmp) this.lBlueButton.Show();
                        else this.lBlueButton.Hide();
                        break;
                    case Constants.ColoursIndexes.PINK:
                        if (tmp) this.pinkButton.Show();
                        else this.pinkButton.Hide();
                        break;
                    case Constants.ColoursIndexes.GRAY:
                        if (tmp) this.grayButton.Show();
                        else this.grayButton.Hide();
                        break;
                }
            }
        }

        private void ColourPickForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ServerEmu.Close)
                e.Cancel = true;
            this.Hide();
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            colour.CurrentColour = Constants.Colours.RED;
            colourB(this, new EventArgs());
            this.Hide();
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            colour.CurrentColour = Constants.Colours.GREEN;
            colourB(this, new EventArgs());
            this.Hide();
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            colour.CurrentColour = Constants.Colours.BLUE;
            colourB(this, new EventArgs());
            this.Hide();
        }

        private void whiteButton_Click(object sender, EventArgs e)
        {
            colour.CurrentColour = Constants.Colours.WHITE;
            colourB(this, new EventArgs());
            this.Hide();
        }

        private void blackButton_Click(object sender, EventArgs e)
        {
            colour.CurrentColour = Constants.Colours.BLACK;
            colourB(this, new EventArgs());
            this.Hide();
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            colour.CurrentColour = Constants.Colours.ORANGE;
            colourB(this, new EventArgs());
            this.Hide();
        }

        private void purpleButton_Click(object sender, EventArgs e)
        {
            colour.CurrentColour = Constants.Colours.PURPLE;
            colourB(this, new EventArgs());
            this.Hide();
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            colour.CurrentColour = Constants.Colours.YELLOW;
            colourB(this, new EventArgs());
            this.Hide();
        }

        private void lGreenButton_Click(object sender, EventArgs e)
        {
            colour.CurrentColour = Constants.Colours.LIGHT_GREEN;
            colourB(this, new EventArgs());
            this.Hide();
        }

        private void lBlueButton_Click(object sender, EventArgs e)
        {
            colour.CurrentColour = Constants.Colours.LIGHT_BLUE;
            colourB(this, new EventArgs());
            this.Hide();
        }

        private void pinkButton_Click(object sender, EventArgs e)
        {
            colour.CurrentColour = Constants.Colours.PINK;
            colourB(this, new EventArgs());
            this.Hide();
        }

        private void grayButton_Click(object sender, EventArgs e)
        {
            colour.CurrentColour = Constants.Colours.GRAY;
            colourB(this, new EventArgs());
            this.Hide();
        }
    }
}
