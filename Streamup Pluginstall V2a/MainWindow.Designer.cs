namespace Streamup_Pluginstall_V2 {
    partial class MainWindow {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            checkedListBoxPlugins = new CheckedListBox();
            radioButtonRecommended = new RadioButton();
            radioButtonRequired = new RadioButton();
            radioButtonRequiredAndRecommended = new RadioButton();
            radioButtonAll = new RadioButton();
            buttonSaveFolder = new Button();
            textBoxSaveLocation = new TextBox();
            buttonDownload = new Button();
            radioButtonCustom = new RadioButton();
            buttonTest = new Button();
            checkBoxExtract = new CheckBox();
            checkBoxOpenUrlsOnly = new CheckBox();
            buttonOpenFolder = new Button();
            radioButtonOutdated = new RadioButton();
            buttonUnZIP = new Button();
            pictureBoxStreamUPLogo = new PictureBox();
            panelTextBoxSaveLocation = new Panel();
            panelCheckedListBoxPlugins = new Panel();
            labelWarning1 = new Label();
            labelWarning2 = new Label();
            progressBarDownload = new ProgressBarSample.TextProgressBar();
            labelAutomaticallyExtract = new Label();
            labelOpenUrlsOnly = new Label();
            labelVersion = new Label();
            richTextBoxLog = new RichTextBox();
            panelRichTextBox = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStreamUPLogo).BeginInit();
            panelTextBoxSaveLocation.SuspendLayout();
            panelCheckedListBoxPlugins.SuspendLayout();
            panelRichTextBox.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBoxPlugins
            // 
            checkedListBoxPlugins.BackColor = Color.FromArgb(42, 44, 65);
            checkedListBoxPlugins.BorderStyle = BorderStyle.None;
            checkedListBoxPlugins.CheckOnClick = true;
            checkedListBoxPlugins.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkedListBoxPlugins.ForeColor = Color.White;
            checkedListBoxPlugins.FormattingEnabled = true;
            checkedListBoxPlugins.Location = new Point(5, 0);
            checkedListBoxPlugins.Name = "checkedListBoxPlugins";
            checkedListBoxPlugins.ScrollAlwaysVisible = true;
            checkedListBoxPlugins.Size = new Size(443, 432);
            checkedListBoxPlugins.Sorted = true;
            checkedListBoxPlugins.TabIndex = 0;
            checkedListBoxPlugins.ThreeDCheckBoxes = true;
            checkedListBoxPlugins.MouseClick += checkedListBoxPlugins_MouseClick;
            // 
            // radioButtonRecommended
            // 
            radioButtonRecommended.AutoSize = true;
            radioButtonRecommended.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonRecommended.Location = new Point(12, 109);
            radioButtonRecommended.Name = "radioButtonRecommended";
            radioButtonRecommended.Size = new Size(196, 25);
            radioButtonRecommended.TabIndex = 4;
            radioButtonRecommended.Text = "Recommended Plugins";
            radioButtonRecommended.UseVisualStyleBackColor = true;
            radioButtonRecommended.CheckedChanged += radioButtonRecommended_CheckedChanged;
            // 
            // radioButtonRequired
            // 
            radioButtonRequired.AutoSize = true;
            radioButtonRequired.Checked = true;
            radioButtonRequired.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonRequired.Location = new Point(12, 78);
            radioButtonRequired.Name = "radioButtonRequired";
            radioButtonRequired.Size = new Size(151, 25);
            radioButtonRequired.TabIndex = 5;
            radioButtonRequired.TabStop = true;
            radioButtonRequired.Text = "Required Plugins";
            radioButtonRequired.UseVisualStyleBackColor = true;
            radioButtonRequired.CheckedChanged += radioButtonRequired_CheckedChanged;
            // 
            // radioButtonRequiredAndRecommended
            // 
            radioButtonRequiredAndRecommended.AutoSize = true;
            radioButtonRequiredAndRecommended.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonRequiredAndRecommended.Location = new Point(12, 140);
            radioButtonRequiredAndRecommended.Name = "radioButtonRequiredAndRecommended";
            radioButtonRequiredAndRecommended.Size = new Size(298, 25);
            radioButtonRequiredAndRecommended.TabIndex = 6;
            radioButtonRequiredAndRecommended.Text = "Required and Recommended Plugins";
            radioButtonRequiredAndRecommended.UseVisualStyleBackColor = true;
            radioButtonRequiredAndRecommended.CheckedChanged += radioButtonRequiredRecommended_CheckedChanged;
            // 
            // radioButtonAll
            // 
            radioButtonAll.AutoSize = true;
            radioButtonAll.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonAll.Location = new Point(357, 78);
            radioButtonAll.Name = "radioButtonAll";
            radioButtonAll.Size = new Size(103, 25);
            radioButtonAll.TabIndex = 7;
            radioButtonAll.Text = "All Plugins";
            radioButtonAll.UseVisualStyleBackColor = true;
            radioButtonAll.CheckedChanged += radioButtonAll_CheckedChanged;
            // 
            // buttonSaveFolder
            // 
            buttonSaveFolder.BackColor = Color.FromArgb(66, 67, 86);
            buttonSaveFolder.FlatAppearance.BorderSize = 0;
            buttonSaveFolder.FlatStyle = FlatStyle.Flat;
            buttonSaveFolder.Image = Properties.Resources.Folder;
            buttonSaveFolder.Location = new Point(425, 609);
            buttonSaveFolder.Name = "buttonSaveFolder";
            buttonSaveFolder.Size = new Size(35, 42);
            buttonSaveFolder.TabIndex = 1;
            buttonSaveFolder.UseVisualStyleBackColor = false;
            buttonSaveFolder.Click += buttonSaveFolder_Click;
            // 
            // textBoxSaveLocation
            // 
            textBoxSaveLocation.BackColor = Color.FromArgb(42, 44, 65);
            textBoxSaveLocation.BorderStyle = BorderStyle.None;
            textBoxSaveLocation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxSaveLocation.ForeColor = Color.White;
            textBoxSaveLocation.Location = new Point(5, 10);
            textBoxSaveLocation.Margin = new Padding(30);
            textBoxSaveLocation.Name = "textBoxSaveLocation";
            textBoxSaveLocation.ReadOnly = true;
            textBoxSaveLocation.Size = new Size(395, 22);
            textBoxSaveLocation.TabIndex = 0;
            textBoxSaveLocation.WordWrap = false;
            // 
            // buttonDownload
            // 
            buttonDownload.AutoSize = true;
            buttonDownload.BackColor = Color.FromArgb(66, 67, 86);
            buttonDownload.FlatAppearance.BorderSize = 0;
            buttonDownload.FlatStyle = FlatStyle.Flat;
            buttonDownload.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDownload.Image = Properties.Resources.Download;
            buttonDownload.ImageAlign = ContentAlignment.TopRight;
            buttonDownload.Location = new Point(700, 609);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(221, 42);
            buttonDownload.TabIndex = 9;
            buttonDownload.Text = "Download Plugins";
            buttonDownload.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDownload.UseVisualStyleBackColor = false;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // radioButtonCustom
            // 
            radioButtonCustom.AutoSize = true;
            radioButtonCustom.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonCustom.Location = new Point(357, 109);
            radioButtonCustom.Name = "radioButtonCustom";
            radioButtonCustom.Size = new Size(84, 25);
            radioButtonCustom.TabIndex = 10;
            radioButtonCustom.Text = "Custom";
            radioButtonCustom.UseVisualStyleBackColor = true;
            radioButtonCustom.CheckedChanged += radioButtonCustom_CheckedChanged;
            // 
            // buttonTest
            // 
            buttonTest.BackColor = Color.FromArgb(66, 67, 86);
            buttonTest.Enabled = false;
            buttonTest.FlatAppearance.BorderSize = 0;
            buttonTest.FlatStyle = FlatStyle.Flat;
            buttonTest.Location = new Point(759, 78);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(120, 51);
            buttonTest.TabIndex = 12;
            buttonTest.Text = "Disabled for Andilippi";
            buttonTest.UseVisualStyleBackColor = false;
            buttonTest.Click += buttonExpand_Click;
            // 
            // checkBoxExtract
            // 
            checkBoxExtract.CheckAlign = ContentAlignment.BottomRight;
            checkBoxExtract.Checked = true;
            checkBoxExtract.CheckState = CheckState.Checked;
            checkBoxExtract.FlatAppearance.BorderSize = 0;
            checkBoxExtract.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxExtract.Location = new Point(473, 84);
            checkBoxExtract.Name = "checkBoxExtract";
            checkBoxExtract.Size = new Size(15, 15);
            checkBoxExtract.TabIndex = 14;
            checkBoxExtract.UseVisualStyleBackColor = true;
            checkBoxExtract.CheckedChanged += checkBoxUnzip_CheckedChanged;
            // 
            // checkBoxOpenUrlsOnly
            // 
            checkBoxOpenUrlsOnly.AutoSize = true;
            checkBoxOpenUrlsOnly.CheckAlign = ContentAlignment.BottomRight;
            checkBoxOpenUrlsOnly.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxOpenUrlsOnly.Location = new Point(473, 115);
            checkBoxOpenUrlsOnly.Name = "checkBoxOpenUrlsOnly";
            checkBoxOpenUrlsOnly.Size = new Size(15, 14);
            checkBoxOpenUrlsOnly.TabIndex = 15;
            checkBoxOpenUrlsOnly.UseVisualStyleBackColor = true;
            checkBoxOpenUrlsOnly.CheckedChanged += checkBoxOpenUrlsOnly_CheckedChanged;
            // 
            // buttonOpenFolder
            // 
            buttonOpenFolder.BackColor = Color.FromArgb(66, 67, 86);
            buttonOpenFolder.FlatAppearance.BorderSize = 0;
            buttonOpenFolder.FlatStyle = FlatStyle.Flat;
            buttonOpenFolder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOpenFolder.ForeColor = Color.White;
            buttonOpenFolder.Image = Properties.Resources.OpenFolder;
            buttonOpenFolder.Location = new Point(473, 609);
            buttonOpenFolder.Name = "buttonOpenFolder";
            buttonOpenFolder.Size = new Size(221, 42);
            buttonOpenFolder.TabIndex = 9;
            buttonOpenFolder.Text = "Open download folder";
            buttonOpenFolder.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonOpenFolder.UseVisualStyleBackColor = false;
            buttonOpenFolder.Click += buttonOpenFolder_Click;
            // 
            // radioButtonOutdated
            // 
            radioButtonOutdated.AutoSize = true;
            radioButtonOutdated.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonOutdated.ForeColor = Color.White;
            radioButtonOutdated.Location = new Point(357, 140);
            radioButtonOutdated.Name = "radioButtonOutdated";
            radioButtonOutdated.Size = new Size(98, 25);
            radioButtonOutdated.TabIndex = 16;
            radioButtonOutdated.Text = "Outdated";
            radioButtonOutdated.UseVisualStyleBackColor = false;
            radioButtonOutdated.Visible = false;
            radioButtonOutdated.CheckedChanged += radioButtonOutdated_CheckedChanged;
            // 
            // buttonUnZIP
            // 
            buttonUnZIP.BackColor = Color.FromArgb(66, 67, 86);
            buttonUnZIP.Enabled = false;
            buttonUnZIP.FlatAppearance.BorderSize = 0;
            buttonUnZIP.FlatStyle = FlatStyle.Flat;
            buttonUnZIP.Location = new Point(759, 137);
            buttonUnZIP.Name = "buttonUnZIP";
            buttonUnZIP.Size = new Size(120, 23);
            buttonUnZIP.TabIndex = 17;
            buttonUnZIP.Text = "Unzip Current Files";
            buttonUnZIP.UseVisualStyleBackColor = false;
            buttonUnZIP.Click += buttonUnZIP_Click;
            // 
            // pictureBoxStreamUPLogo
            // 
            pictureBoxStreamUPLogo.Image = Properties.Resources.StreamUP_PluginstallerV2;
            pictureBoxStreamUPLogo.Location = new Point(12, 12);
            pictureBoxStreamUPLogo.Name = "pictureBoxStreamUPLogo";
            pictureBoxStreamUPLogo.Size = new Size(909, 60);
            pictureBoxStreamUPLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxStreamUPLogo.TabIndex = 0;
            pictureBoxStreamUPLogo.TabStop = false;
            // 
            // panelTextBoxSaveLocation
            // 
            panelTextBoxSaveLocation.BackColor = Color.FromArgb(42, 44, 65);
            panelTextBoxSaveLocation.Controls.Add(textBoxSaveLocation);
            panelTextBoxSaveLocation.Location = new Point(12, 609);
            panelTextBoxSaveLocation.Name = "panelTextBoxSaveLocation";
            panelTextBoxSaveLocation.Size = new Size(407, 42);
            panelTextBoxSaveLocation.TabIndex = 18;
            // 
            // panelCheckedListBoxPlugins
            // 
            panelCheckedListBoxPlugins.BackColor = Color.FromArgb(42, 44, 65);
            panelCheckedListBoxPlugins.Controls.Add(checkedListBoxPlugins);
            panelCheckedListBoxPlugins.Location = new Point(12, 171);
            panelCheckedListBoxPlugins.Name = "panelCheckedListBoxPlugins";
            panelCheckedListBoxPlugins.Size = new Size(448, 432);
            panelCheckedListBoxPlugins.TabIndex = 23;
            // 
            // labelWarning1
            // 
            labelWarning1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelWarning1.ForeColor = Color.Red;
            labelWarning1.Location = new Point(12, 12);
            labelWarning1.Margin = new Padding(3);
            labelWarning1.Name = "labelWarning1";
            labelWarning1.Size = new Size(298, 60);
            labelWarning1.TabIndex = 24;
            labelWarning1.Text = "WARNING:\r\nOBS-STUDIO FOLDER SELECTED";
            labelWarning1.TextAlign = ContentAlignment.MiddleCenter;
            labelWarning1.Visible = false;
            // 
            // labelWarning2
            // 
            labelWarning2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelWarning2.ForeColor = Color.Red;
            labelWarning2.Location = new Point(622, 12);
            labelWarning2.Margin = new Padding(3);
            labelWarning2.Name = "labelWarning2";
            labelWarning2.Size = new Size(298, 60);
            labelWarning2.TabIndex = 24;
            labelWarning2.Text = "WARNING:\r\nRUNNING WITH ELEVATED PRIVILEGES";
            labelWarning2.TextAlign = ContentAlignment.MiddleCenter;
            labelWarning2.Visible = false;
            // 
            // progressBarDownload
            // 
            progressBarDownload.CustomText = "Made with Love by Silverlink";
            progressBarDownload.Location = new Point(473, 580);
            progressBarDownload.Name = "progressBarDownload";
            progressBarDownload.ProgressColor = Color.FromArgb(255, 134, 189);
            progressBarDownload.Size = new Size(429, 23);
            progressBarDownload.TabIndex = 25;
            progressBarDownload.TextColor = Color.Black;
            progressBarDownload.TextFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            progressBarDownload.Visible = false;
            progressBarDownload.VisualMode = ProgressBarSample.ProgressBarDisplayMode.CustomText;
            // 
            // labelAutomaticallyExtract
            // 
            labelAutomaticallyExtract.AutoSize = true;
            labelAutomaticallyExtract.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelAutomaticallyExtract.Location = new Point(494, 80);
            labelAutomaticallyExtract.Name = "labelAutomaticallyExtract";
            labelAutomaticallyExtract.Size = new Size(165, 21);
            labelAutomaticallyExtract.TabIndex = 26;
            labelAutomaticallyExtract.Text = "Automatically extract";
            // 
            // labelOpenUrlsOnly
            // 
            labelOpenUrlsOnly.AutoSize = true;
            labelOpenUrlsOnly.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelOpenUrlsOnly.Location = new Point(494, 111);
            labelOpenUrlsOnly.Name = "labelOpenUrlsOnly";
            labelOpenUrlsOnly.Size = new Size(127, 21);
            labelOpenUrlsOnly.TabIndex = 27;
            labelOpenUrlsOnly.Text = "Open URLs Only";
            // 
            // labelVersion
            // 
            labelVersion.Location = new Point(622, 9);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(308, 15);
            labelVersion.TabIndex = 28;
            labelVersion.Text = "2.0.0";
            labelVersion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // richTextBoxLog
            // 
            richTextBoxLog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            richTextBoxLog.BackColor = Color.FromArgb(42, 44, 65);
            richTextBoxLog.BorderStyle = BorderStyle.None;
            richTextBoxLog.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxLog.ForeColor = Color.White;
            richTextBoxLog.HideSelection = false;
            richTextBoxLog.Location = new Point(5, 0);
            richTextBoxLog.Name = "richTextBoxLog";
            richTextBoxLog.ReadOnly = true;
            richTextBoxLog.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            richTextBoxLog.Size = new Size(441, 432);
            richTextBoxLog.TabIndex = 29;
            richTextBoxLog.Text = "";
            richTextBoxLog.LinkClicked += richTextBoxLog_LinkClicked;
            // 
            // panelRichTextBox
            // 
            panelRichTextBox.BackColor = Color.FromArgb(42, 44, 65);
            panelRichTextBox.Controls.Add(richTextBoxLog);
            panelRichTextBox.Location = new Point(473, 171);
            panelRichTextBox.Name = "panelRichTextBox";
            panelRichTextBox.Size = new Size(448, 432);
            panelRichTextBox.TabIndex = 30;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 23, 45);
            ClientSize = new Size(932, 663);
            Controls.Add(progressBarDownload);
            Controls.Add(panelRichTextBox);
            Controls.Add(labelVersion);
            Controls.Add(labelOpenUrlsOnly);
            Controls.Add(labelAutomaticallyExtract);
            Controls.Add(labelWarning2);
            Controls.Add(labelWarning1);
            Controls.Add(buttonOpenFolder);
            Controls.Add(buttonDownload);
            Controls.Add(panelCheckedListBoxPlugins);
            Controls.Add(panelTextBoxSaveLocation);
            Controls.Add(buttonSaveFolder);
            Controls.Add(buttonUnZIP);
            Controls.Add(radioButtonOutdated);
            Controls.Add(checkBoxOpenUrlsOnly);
            Controls.Add(checkBoxExtract);
            Controls.Add(buttonTest);
            Controls.Add(radioButtonCustom);
            Controls.Add(radioButtonAll);
            Controls.Add(radioButtonRequiredAndRecommended);
            Controls.Add(radioButtonRequired);
            Controls.Add(radioButtonRecommended);
            Controls.Add(pictureBoxStreamUPLogo);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainWindow";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StreamUP Pluginstaller V2";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxStreamUPLogo).EndInit();
            panelTextBoxSaveLocation.ResumeLayout(false);
            panelTextBoxSaveLocation.PerformLayout();
            panelCheckedListBoxPlugins.ResumeLayout(false);
            panelRichTextBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton radioButtonRecommended;
        private RadioButton radioButtonRequired;
        private RadioButton radioButtonRequiredAndRecommended;
        private RadioButton radioButtonAll;
        private CheckedListBox checkedListBoxPlugins;
        private TextBox textBoxSaveLocation;
        private Button buttonSaveFolder;
        private Button buttonDownload;
        private RadioButton radioButtonCustom;
        private Button buttonTest;
        private CheckBox checkBoxExtract;
        private CheckBox checkBoxOpenUrlsOnly;
        private Button buttonOpenFolder;
        private RadioButton radioButtonOutdated;
        private Button buttonUnZIP;
        private PictureBox pictureBoxStreamUPLogo;
        private Panel panelTextBoxSaveLocation;
        private Label labelOpenUrlsOnly;
        private Panel panelCheckedListBoxPlugins;
        private Label labelWarning1;
        private Label labelWarning2;
        private ProgressBarSample.TextProgressBar progressBarDownload;
        private Label labelAutomaticallyExtract;
        private Label labelVersion;
        private RichTextBox richTextBoxLog;
        private Panel panelRichTextBox;
    }
}