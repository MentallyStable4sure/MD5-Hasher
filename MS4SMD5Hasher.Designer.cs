namespace MS4S_MD5Hasher
{
    partial class MS4SMD5Hasher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MS4SMD5Hasher));
            browseButton = new Button();
            pathBox = new TextBox();
            folderBrowser = new FolderBrowserDialog();
            startEncodeButton = new Button();
            loadingAnimation = new PictureBox();
            separatorBox = new TextBox();
            closeButton = new Button();
            filenameBox = new TextBox();
            themeBox = new ComboBox();
            compareModeButton = new Button();
            encodeModeButton = new Button();
            labelOr = new Label();
            compareBox2 = new TextBox();
            startCompareButton = new Button();
            menuButton = new Button();
            separatorCompare1 = new TextBox();
            separatorCompare2 = new TextBox();
            compareBox1 = new TextBox();
            browseFirstFile = new Button();
            browseSecondFile = new Button();
            ((System.ComponentModel.ISupportInitialize)loadingAnimation).BeginInit();
            SuspendLayout();
            // 
            // browseButton
            // 
            browseButton.BackColor = SystemColors.Control;
            browseButton.BackgroundImageLayout = ImageLayout.Stretch;
            browseButton.FlatAppearance.BorderSize = 0;
            browseButton.Font = new Font("Century Gothic", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            browseButton.Location = new Point(145, 491);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(101, 28);
            browseButton.TabIndex = 0;
            browseButton.Text = "Browse Folder";
            browseButton.TextImageRelation = TextImageRelation.TextAboveImage;
            browseButton.UseVisualStyleBackColor = false;
            browseButton.Visible = false;
            browseButton.Click += button1_Click;
            // 
            // pathBox
            // 
            pathBox.Enabled = false;
            pathBox.Font = new Font("Perpetua Titling MT", 8F, FontStyle.Bold, GraphicsUnit.Point);
            pathBox.ForeColor = Color.DarkRed;
            pathBox.Location = new Point(-5, 201);
            pathBox.Multiline = true;
            pathBox.Name = "pathBox";
            pathBox.Size = new Size(397, 36);
            pathBox.TabIndex = 1;
            pathBox.TextAlign = HorizontalAlignment.Center;
            pathBox.Visible = false;
            // 
            // startEncodeButton
            // 
            startEncodeButton.BackColor = SystemColors.Control;
            startEncodeButton.FlatAppearance.BorderSize = 0;
            startEncodeButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            startEncodeButton.Location = new Point(117, 519);
            startEncodeButton.Name = "startEncodeButton";
            startEncodeButton.Size = new Size(155, 30);
            startEncodeButton.TabIndex = 2;
            startEncodeButton.Text = "Start Encoding";
            startEncodeButton.UseVisualStyleBackColor = false;
            startEncodeButton.Visible = false;
            startEncodeButton.Click += startButton_Click;
            // 
            // loadingAnimation
            // 
            loadingAnimation.BackColor = Color.Transparent;
            loadingAnimation.BackgroundImageLayout = ImageLayout.Stretch;
            loadingAnimation.Enabled = false;
            loadingAnimation.Image = Properties.Resources.loading;
            loadingAnimation.Location = new Point(119, 339);
            loadingAnimation.Name = "loadingAnimation";
            loadingAnimation.Size = new Size(155, 146);
            loadingAnimation.SizeMode = PictureBoxSizeMode.StretchImage;
            loadingAnimation.TabIndex = 3;
            loadingAnimation.TabStop = false;
            loadingAnimation.Visible = false;
            // 
            // separatorBox
            // 
            separatorBox.Font = new Font("Perpetua Titling MT", 8F, FontStyle.Bold, GraphicsUnit.Point);
            separatorBox.ForeColor = SystemColors.ActiveCaptionText;
            separatorBox.Location = new Point(23, 253);
            separatorBox.MaxLength = 27000;
            separatorBox.Name = "separatorBox";
            separatorBox.PlaceholderText = "Custom Separator";
            separatorBox.Size = new Size(154, 20);
            separatorBox.TabIndex = 4;
            separatorBox.TextAlign = HorizontalAlignment.Center;
            separatorBox.Visible = false;
            // 
            // closeButton
            // 
            closeButton.BackColor = SystemColors.Control;
            closeButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.Location = new Point(363, 2);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(26, 26);
            closeButton.TabIndex = 6;
            closeButton.Text = "X";
            closeButton.TextImageRelation = TextImageRelation.TextAboveImage;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // filenameBox
            // 
            filenameBox.Font = new Font("Perpetua Titling MT", 8F, FontStyle.Bold, GraphicsUnit.Point);
            filenameBox.ForeColor = SystemColors.ActiveCaptionText;
            filenameBox.Location = new Point(225, 254);
            filenameBox.MaxLength = 27000;
            filenameBox.Name = "filenameBox";
            filenameBox.PlaceholderText = "Custom File Name";
            filenameBox.Size = new Size(131, 20);
            filenameBox.TabIndex = 8;
            filenameBox.TextAlign = HorizontalAlignment.Center;
            filenameBox.Visible = false;
            // 
            // themeBox
            // 
            themeBox.BackColor = Color.RosyBrown;
            themeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            themeBox.FlatStyle = FlatStyle.Flat;
            themeBox.Font = new Font("Perpetua Titling MT", 8F, FontStyle.Bold, GraphicsUnit.Point);
            themeBox.ForeColor = Color.Indigo;
            themeBox.FormattingEnabled = true;
            themeBox.Items.AddRange(new object[] { "Maf with Beer", "Underwater Flow", "Elf Forest", "Church Goth", "Ayaka Black Bra [16+]", "Sona Cyan Bra [16+]", "Raiden Purple Bra [16+]" });
            themeBox.Location = new Point(-143, 541);
            themeBox.Name = "themeBox";
            themeBox.Size = new Size(161, 21);
            themeBox.TabIndex = 10;
            // 
            // compareModeButton
            // 
            compareModeButton.BackColor = SystemColors.Control;
            compareModeButton.FlatAppearance.BorderSize = 0;
            compareModeButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            compareModeButton.Location = new Point(119, 193);
            compareModeButton.Name = "compareModeButton";
            compareModeButton.Size = new Size(166, 51);
            compareModeButton.TabIndex = 12;
            compareModeButton.Text = "Compare 2 checksum files";
            compareModeButton.UseVisualStyleBackColor = false;
            compareModeButton.Click += compareModeButton_Click;
            // 
            // encodeModeButton
            // 
            encodeModeButton.BackColor = SystemColors.Control;
            encodeModeButton.FlatAppearance.BorderSize = 0;
            encodeModeButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            encodeModeButton.Location = new Point(117, 281);
            encodeModeButton.Name = "encodeModeButton";
            encodeModeButton.Size = new Size(166, 52);
            encodeModeButton.TabIndex = 13;
            encodeModeButton.Text = "Encode checksums from folder";
            encodeModeButton.UseVisualStyleBackColor = false;
            encodeModeButton.Click += encodeModeButton_Click;
            // 
            // labelOr
            // 
            labelOr.AutoSize = true;
            labelOr.BackColor = Color.IndianRed;
            labelOr.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelOr.Location = new Point(184, 253);
            labelOr.Name = "labelOr";
            labelOr.Size = new Size(35, 20);
            labelOr.TabIndex = 14;
            labelOr.Text = "OR";
            // 
            // compareBox2
            // 
            compareBox2.Enabled = false;
            compareBox2.Font = new Font("Perpetua Titling MT", 8F, FontStyle.Bold, GraphicsUnit.Point);
            compareBox2.ForeColor = Color.DarkRed;
            compareBox2.Location = new Point(-4, 291);
            compareBox2.Multiline = true;
            compareBox2.Name = "compareBox2";
            compareBox2.Size = new Size(397, 36);
            compareBox2.TabIndex = 15;
            compareBox2.TextAlign = HorizontalAlignment.Center;
            compareBox2.Visible = false;
            // 
            // startCompareButton
            // 
            startCompareButton.BackColor = SystemColors.Control;
            startCompareButton.FlatAppearance.BorderSize = 0;
            startCompareButton.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            startCompareButton.Location = new Point(117, 519);
            startCompareButton.Name = "startCompareButton";
            startCompareButton.Size = new Size(155, 30);
            startCompareButton.TabIndex = 16;
            startCompareButton.Text = "Start Comparing";
            startCompareButton.UseVisualStyleBackColor = false;
            startCompareButton.Visible = false;
            // 
            // menuButton
            // 
            menuButton.Location = new Point(4, 2);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(56, 27);
            menuButton.TabIndex = 17;
            menuButton.Text = "<";
            menuButton.UseVisualStyleBackColor = true;
            menuButton.Click += menuButton_Click;
            // 
            // separatorCompare1
            // 
            separatorCompare1.Font = new Font("Perpetua Titling MT", 8F, FontStyle.Bold, GraphicsUnit.Point);
            separatorCompare1.ForeColor = SystemColors.ActiveCaptionText;
            separatorCompare1.Location = new Point(120, 167);
            separatorCompare1.MaxLength = 27000;
            separatorCompare1.Name = "separatorCompare1";
            separatorCompare1.PlaceholderText = "Custom Separator ':'";
            separatorCompare1.Size = new Size(154, 20);
            separatorCompare1.TabIndex = 18;
            separatorCompare1.TextAlign = HorizontalAlignment.Center;
            separatorCompare1.Visible = false;
            // 
            // separatorCompare2
            // 
            separatorCompare2.Font = new Font("Perpetua Titling MT", 8F, FontStyle.Bold, GraphicsUnit.Point);
            separatorCompare2.ForeColor = SystemColors.ActiveCaptionText;
            separatorCompare2.Location = new Point(118, 339);
            separatorCompare2.MaxLength = 27000;
            separatorCompare2.Name = "separatorCompare2";
            separatorCompare2.PlaceholderText = "Custom Separator ':'";
            separatorCompare2.Size = new Size(154, 20);
            separatorCompare2.TabIndex = 19;
            separatorCompare2.TextAlign = HorizontalAlignment.Center;
            separatorCompare2.Visible = false;
            // 
            // compareBox1
            // 
            compareBox1.Enabled = false;
            compareBox1.Font = new Font("Perpetua Titling MT", 8F, FontStyle.Bold, GraphicsUnit.Point);
            compareBox1.ForeColor = Color.DarkRed;
            compareBox1.Location = new Point(-4, 201);
            compareBox1.Multiline = true;
            compareBox1.Name = "compareBox1";
            compareBox1.Size = new Size(397, 36);
            compareBox1.TabIndex = 20;
            compareBox1.TextAlign = HorizontalAlignment.Center;
            compareBox1.Visible = false;
            // 
            // browseFirstFile
            // 
            browseFirstFile.BackColor = SystemColors.Control;
            browseFirstFile.BackgroundImageLayout = ImageLayout.Stretch;
            browseFirstFile.FlatAppearance.BorderSize = 0;
            browseFirstFile.Font = new Font("Century Gothic", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            browseFirstFile.Location = new Point(149, 133);
            browseFirstFile.Name = "browseFirstFile";
            browseFirstFile.Size = new Size(101, 28);
            browseFirstFile.TabIndex = 21;
            browseFirstFile.Text = "Browse File 1";
            browseFirstFile.TextImageRelation = TextImageRelation.TextAboveImage;
            browseFirstFile.UseVisualStyleBackColor = false;
            browseFirstFile.Visible = false;
            // 
            // browseSecondFile
            // 
            browseSecondFile.BackColor = SystemColors.Control;
            browseSecondFile.BackgroundImageLayout = ImageLayout.Stretch;
            browseSecondFile.FlatAppearance.BorderSize = 0;
            browseSecondFile.Font = new Font("Century Gothic", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            browseSecondFile.Location = new Point(145, 365);
            browseSecondFile.Name = "browseSecondFile";
            browseSecondFile.Size = new Size(101, 28);
            browseSecondFile.TabIndex = 22;
            browseSecondFile.Text = "Browse File 2";
            browseSecondFile.TextImageRelation = TextImageRelation.TextAboveImage;
            browseSecondFile.UseVisualStyleBackColor = false;
            browseSecondFile.Visible = false;
            // 
            // MS4SMD5Hasher
            // 
            AutoScaleDimensions = new SizeF(10F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.beermaf;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(390, 561);
            Controls.Add(browseSecondFile);
            Controls.Add(browseFirstFile);
            Controls.Add(compareBox1);
            Controls.Add(separatorCompare2);
            Controls.Add(separatorCompare1);
            Controls.Add(menuButton);
            Controls.Add(labelOr);
            Controls.Add(encodeModeButton);
            Controls.Add(compareModeButton);
            Controls.Add(themeBox);
            Controls.Add(filenameBox);
            Controls.Add(closeButton);
            Controls.Add(separatorBox);
            Controls.Add(loadingAnimation);
            Controls.Add(browseButton);
            Controls.Add(pathBox);
            Controls.Add(compareBox2);
            Controls.Add(startEncodeButton);
            Controls.Add(startCompareButton);
            DoubleBuffered = true;
            Font = new Font("Perpetua Titling MT", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "MS4SMD5Hasher";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MS4S MD5 Hasher";
            ((System.ComponentModel.ISupportInitialize)loadingAnimation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Button browseButton;
        private TextBox pathBox;
        private FolderBrowserDialog folderBrowser;
        private Button startEncodeButton;
        private PictureBox loadingAnimation;
        private TextBox separatorBox;
        private Button closeButton;
        private CheckBox checkBox1;
        private TextBox filenameBox;
        private CheckBox checkBox2;
        private ComboBox themeBox;
        private Label orLabel;
        private Button compareModeButton;
        private Button encodeModeButton;
        private Label labelOr;
        private TextBox compareBox2;
        private Button startCompareButton;
        private Button menuButton;
        private TextBox separatorCompare1;
        private TextBox separatorCompare2;
        private TextBox compareBox1;
        private Button browseFirstFile;
        private Button browseSecondFile;
    }
}