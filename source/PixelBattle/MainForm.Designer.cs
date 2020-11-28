namespace PixelBattle
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.fieldPictureBox = new System.Windows.Forms.PictureBox();
            this.scaleTrackBar = new System.Windows.Forms.TrackBar();
            this.logoutButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.currentColourLabel = new System.Windows.Forms.Label();
            this.currentColourButton = new System.Windows.Forms.Button();
            this.shopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fieldPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.IsSplitterFixed = true;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.fieldPictureBox);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(33)))), ((int)(((byte)(41)))));
            this.mainSplitContainer.Panel2.Controls.Add(this.scaleTrackBar);
            this.mainSplitContainer.Panel2.Controls.Add(this.logoutButton);
            this.mainSplitContainer.Panel2.Controls.Add(this.usernameLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.scaleLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.currentColourLabel);
            this.mainSplitContainer.Panel2.Controls.Add(this.currentColourButton);
            this.mainSplitContainer.Panel2.Controls.Add(this.shopButton);
            this.mainSplitContainer.Size = new System.Drawing.Size(1264, 681);
            this.mainSplitContainer.SplitterDistance = 865;
            this.mainSplitContainer.SplitterWidth = 3;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // fieldPictureBox
            // 
            this.fieldPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldPictureBox.Location = new System.Drawing.Point(0, 0);
            this.fieldPictureBox.Name = "fieldPictureBox";
            this.fieldPictureBox.Size = new System.Drawing.Size(863, 679);
            this.fieldPictureBox.TabIndex = 0;
            this.fieldPictureBox.TabStop = false;
            // 
            // scaleTrackBar
            // 
            this.scaleTrackBar.Location = new System.Drawing.Point(36, 573);
            this.scaleTrackBar.Minimum = 5;
            this.scaleTrackBar.Name = "scaleTrackBar";
            this.scaleTrackBar.Size = new System.Drawing.Size(329, 45);
            this.scaleTrackBar.TabIndex = 6;
            this.scaleTrackBar.Value = 5;
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(199)))), ((int)(((byte)(112)))));
            this.logoutButton.FlatAppearance.BorderSize = 3;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Imprint MT Shadow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(199)))), ((int)(((byte)(112)))));
            this.logoutButton.Location = new System.Drawing.Point(315, 32);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(50, 50);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "X";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            this.logoutButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logoutButton_MouseDown);
            this.logoutButton.MouseLeave += new System.EventHandler(this.logoutButton_MouseLeave);
            this.logoutButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logoutButton_MouseMove);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernameLabel.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(194)))), ((int)(((byte)(178)))));
            this.usernameLabel.Location = new System.Drawing.Point(30, 41);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(131, 32);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scaleLabel.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scaleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(194)))), ((int)(((byte)(178)))));
            this.scaleLabel.Location = new System.Drawing.Point(30, 519);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(82, 34);
            this.scaleLabel.TabIndex = 3;
            this.scaleLabel.Text = "Scale:";
            // 
            // currentColourLabel
            // 
            this.currentColourLabel.AutoSize = true;
            this.currentColourLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentColourLabel.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentColourLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(194)))), ((int)(((byte)(178)))));
            this.currentColourLabel.Location = new System.Drawing.Point(30, 230);
            this.currentColourLabel.Name = "currentColourLabel";
            this.currentColourLabel.Size = new System.Drawing.Size(187, 34);
            this.currentColourLabel.TabIndex = 2;
            this.currentColourLabel.Text = "Current colour :";
            // 
            // currentColourButton
            // 
            this.currentColourButton.BackColor = System.Drawing.Color.White;
            this.currentColourButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.currentColourButton.FlatAppearance.BorderSize = 0;
            this.currentColourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentColourButton.Location = new System.Drawing.Point(315, 228);
            this.currentColourButton.Name = "currentColourButton";
            this.currentColourButton.Size = new System.Drawing.Size(50, 50);
            this.currentColourButton.TabIndex = 1;
            this.currentColourButton.UseVisualStyleBackColor = false;
            this.currentColourButton.Click += new System.EventHandler(this.currentColourButton_Click);
            // 
            // shopButton
            // 
            this.shopButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(199)))), ((int)(((byte)(112)))));
            this.shopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shopButton.FlatAppearance.BorderSize = 0;
            this.shopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.shopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(194)))), ((int)(((byte)(178)))));
            this.shopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shopButton.Location = new System.Drawing.Point(36, 320);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(329, 88);
            this.shopButton.TabIndex = 0;
            this.shopButton.UseVisualStyleBackColor = false;
            this.shopButton.Click += new System.EventHandler(this.shopButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.mainSplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PixelBattle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fieldPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.PictureBox fieldPictureBox;
        private System.Windows.Forms.Button shopButton;
        private System.Windows.Forms.Label currentColourLabel;
        private System.Windows.Forms.Button currentColourButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.TrackBar scaleTrackBar;
    }
}

