namespace PixelBattle
{
    partial class ShopForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buyButton = new System.Windows.Forms.Button();
            this.basketPictureBox = new System.Windows.Forms.PictureBox();
            this.basketLabel = new System.Windows.Forms.Label();
            this.buyCurrencyButton = new System.Windows.Forms.Button();
            this.coinsLabel = new System.Windows.Forms.Label();
            this.basketMoneyLabel = new System.Windows.Forms.Label();
            this.coinsCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basketPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.splitContainer1.Panel2.Controls.Add(this.coinsCountLabel);
            this.splitContainer1.Panel2.Controls.Add(this.basketMoneyLabel);
            this.splitContainer1.Panel2.Controls.Add(this.coinsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.buyCurrencyButton);
            this.splitContainer1.Panel2.Controls.Add(this.basketLabel);
            this.splitContainer1.Panel2.Controls.Add(this.basketPictureBox);
            this.splitContainer1.Panel2.Controls.Add(this.buyButton);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 681);
            this.splitContainer1.SplitterDistance = 504;
            this.splitContainer1.TabIndex = 2;
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(199)))), ((int)(((byte)(112)))));
            this.buyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyButton.FlatAppearance.BorderSize = 0;
            this.buyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.buyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(194)))), ((int)(((byte)(178)))));
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyButton.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyButton.Location = new System.Drawing.Point(33, 96);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(150, 50);
            this.buyButton.TabIndex = 0;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // basketPictureBox
            // 
            this.basketPictureBox.Enabled = false;
            this.basketPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("basketPictureBox.Image")));
            this.basketPictureBox.Location = new System.Drawing.Point(33, 23);
            this.basketPictureBox.Name = "basketPictureBox";
            this.basketPictureBox.Size = new System.Drawing.Size(50, 50);
            this.basketPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.basketPictureBox.TabIndex = 2;
            this.basketPictureBox.TabStop = false;
            // 
            // basketLabel
            // 
            this.basketLabel.AutoSize = true;
            this.basketLabel.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basketLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(194)))), ((int)(((byte)(178)))));
            this.basketLabel.Location = new System.Drawing.Point(99, 23);
            this.basketLabel.Name = "basketLabel";
            this.basketLabel.Size = new System.Drawing.Size(125, 39);
            this.basketLabel.TabIndex = 3;
            this.basketLabel.Text = "Basket :";
            // 
            // buyCurrencyButton
            // 
            this.buyCurrencyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(199)))), ((int)(((byte)(112)))));
            this.buyCurrencyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyCurrencyButton.FlatAppearance.BorderSize = 0;
            this.buyCurrencyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.buyCurrencyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(194)))), ((int)(((byte)(178)))));
            this.buyCurrencyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyCurrencyButton.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyCurrencyButton.Location = new System.Drawing.Point(209, 96);
            this.buyCurrencyButton.Name = "buyCurrencyButton";
            this.buyCurrencyButton.Size = new System.Drawing.Size(313, 50);
            this.buyCurrencyButton.TabIndex = 4;
            this.buyCurrencyButton.Text = "Buy game currency";
            this.buyCurrencyButton.UseVisualStyleBackColor = false;
            this.buyCurrencyButton.Click += new System.EventHandler(this.buyCurrencyButton_Click);
            // 
            // coinsLabel
            // 
            this.coinsLabel.AutoSize = true;
            this.coinsLabel.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(194)))), ((int)(((byte)(178)))));
            this.coinsLabel.Location = new System.Drawing.Point(548, 107);
            this.coinsLabel.Name = "coinsLabel";
            this.coinsLabel.Size = new System.Drawing.Size(182, 39);
            this.coinsLabel.TabIndex = 5;
            this.coinsLabel.Text = "Your coins :";
            // 
            // basketMoneyLabel
            // 
            this.basketMoneyLabel.AutoSize = true;
            this.basketMoneyLabel.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basketMoneyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(194)))), ((int)(((byte)(178)))));
            this.basketMoneyLabel.Location = new System.Drawing.Point(230, 23);
            this.basketMoneyLabel.Name = "basketMoneyLabel";
            this.basketMoneyLabel.Size = new System.Drawing.Size(0, 39);
            this.basketMoneyLabel.TabIndex = 6;
            // 
            // coinsCountLabel
            // 
            this.coinsCountLabel.AutoSize = true;
            this.coinsCountLabel.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinsCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(194)))), ((int)(((byte)(178)))));
            this.coinsCountLabel.Location = new System.Drawing.Point(736, 107);
            this.coinsCountLabel.Name = "coinsCountLabel";
            this.coinsCountLabel.Size = new System.Drawing.Size(0, 39);
            this.coinsCountLabel.TabIndex = 7;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "ShopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShopForm_FormClosing);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.basketPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label basketLabel;
        private System.Windows.Forms.PictureBox basketPictureBox;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button buyCurrencyButton;
        private System.Windows.Forms.Label coinsLabel;
        private System.Windows.Forms.Label coinsCountLabel;
        private System.Windows.Forms.Label basketMoneyLabel;
    }
}