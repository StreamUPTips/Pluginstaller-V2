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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            checkedListBoxPlugins = new CheckedListBox();
            buttonSaveFolder = new Button();
            textBoxSaveLocation = new TextBox();
            buttonDownload = new Button();
            buttonTest = new Button();
            checkBoxExtract = new CheckBox();
            checkBoxOpenUrlsOnly = new CheckBox();
            buttonOpenFolder = new Button();
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
            buttonClearSelection = new Button();
            buttonAbout = new Button();
            radioButtonRequired = new Custom_Controls.RadioButtonFlat();
            radioButtonRecommended = new Custom_Controls.RadioButtonFlat();
            radioButtonRequiredAndRecommended = new Custom_Controls.RadioButtonFlat();
            radioButtonAll = new Custom_Controls.RadioButtonFlat();
            radioButtonCustom = new Custom_Controls.RadioButtonFlat();
            radioButtonOutdated = new Custom_Controls.RadioButtonFlat();
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
            // buttonSaveFolder
            // 
            buttonSaveFolder.BackColor = Color.FromArgb(66, 67, 86);
            buttonSaveFolder.FlatAppearance.BorderSize = 0;
            buttonSaveFolder.FlatStyle = FlatStyle.Flat;
            buttonSaveFolder.Image = Properties.Resources.Folder;
            buttonSaveFolder.Location = new Point(425, 609);
            buttonSaveFolder.Name = "buttonSaveFolder";
            buttonSaveFolder.Size = new Size(35, 42);
            buttonSaveFolder.TabIndex = 13;
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
            buttonDownload.TabIndex = 15;
            buttonDownload.Text = "Download Plugins";
            buttonDownload.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDownload.UseVisualStyleBackColor = false;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // buttonTest
            // 
            buttonTest.BackColor = Color.FromArgb(66, 67, 86);
            buttonTest.FlatAppearance.BorderSize = 0;
            buttonTest.FlatStyle = FlatStyle.Flat;
            buttonTest.Location = new Point(799, 78);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(120, 51);
            buttonTest.TabIndex = 12;
            buttonTest.TabStop = false;
            buttonTest.Text = "Disabled for Andilippi";
            buttonTest.UseVisualStyleBackColor = false;
            buttonTest.Visible = false;
            buttonTest.Click += buttonExpand_Click;
            // 
            // checkBoxExtract
            // 
            checkBoxExtract.BackColor = Color.Transparent;
            checkBoxExtract.Checked = true;
            checkBoxExtract.CheckState = CheckState.Checked;
            checkBoxExtract.FlatAppearance.BorderSize = 0;
            checkBoxExtract.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxExtract.Location = new Point(473, 88);
            checkBoxExtract.Name = "checkBoxExtract";
            checkBoxExtract.Size = new Size(15, 15);
            checkBoxExtract.TabIndex = 6;
            checkBoxExtract.UseVisualStyleBackColor = false;
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
            checkBoxOpenUrlsOnly.TabIndex = 7;
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
            buttonOpenFolder.TabIndex = 14;
            buttonOpenFolder.Text = "Open download folder";
            buttonOpenFolder.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonOpenFolder.UseVisualStyleBackColor = false;
            buttonOpenFolder.Click += buttonOpenFolder_Click;
            // 
            // buttonUnZIP
            // 
            buttonUnZIP.BackColor = Color.FromArgb(66, 67, 86);
            buttonUnZIP.Enabled = false;
            buttonUnZIP.FlatAppearance.BorderSize = 0;
            buttonUnZIP.FlatStyle = FlatStyle.Flat;
            buttonUnZIP.Location = new Point(604, 142);
            buttonUnZIP.Name = "buttonUnZIP";
            buttonUnZIP.Size = new Size(125, 25);
            buttonUnZIP.TabIndex = 9;
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
            panelTextBoxSaveLocation.TabIndex = 12;
            // 
            // panelCheckedListBoxPlugins
            // 
            panelCheckedListBoxPlugins.BackColor = Color.FromArgb(42, 44, 65);
            panelCheckedListBoxPlugins.Controls.Add(checkedListBoxPlugins);
            panelCheckedListBoxPlugins.Location = new Point(12, 171);
            panelCheckedListBoxPlugins.Name = "panelCheckedListBoxPlugins";
            panelCheckedListBoxPlugins.Size = new Size(448, 432);
            panelCheckedListBoxPlugins.TabIndex = 10;
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
            progressBarDownload.TabIndex = 15;
            progressBarDownload.TextColor = Color.Black;
            progressBarDownload.TextFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            progressBarDownload.Visible = false;
            progressBarDownload.VisualMode = ProgressBarSample.ProgressBarDisplayMode.CustomText;
            // 
            // labelAutomaticallyExtract
            // 
            labelAutomaticallyExtract.AutoSize = true;
            labelAutomaticallyExtract.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelAutomaticallyExtract.Location = new Point(494, 84);
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
            labelVersion.Size = new Size(260, 15);
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
            richTextBoxLog.TabIndex = 0;
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
            panelRichTextBox.TabIndex = 11;
            // 
            // buttonClearSelection
            // 
            buttonClearSelection.BackColor = Color.FromArgb(66, 67, 86);
            buttonClearSelection.Enabled = false;
            buttonClearSelection.FlatAppearance.BorderSize = 0;
            buttonClearSelection.FlatStyle = FlatStyle.Flat;
            buttonClearSelection.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClearSelection.Location = new Point(473, 142);
            buttonClearSelection.Name = "buttonClearSelection";
            buttonClearSelection.Size = new Size(125, 25);
            buttonClearSelection.TabIndex = 8;
            buttonClearSelection.Text = "Clear Selection";
            buttonClearSelection.UseVisualStyleBackColor = false;
            buttonClearSelection.Click += buttonClearSelection_Click;
            // 
            // buttonAbout
            // 
            buttonAbout.BackgroundImage = Properties.Resources.AboutButton;
            buttonAbout.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAbout.FlatAppearance.BorderSize = 0;
            buttonAbout.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 43, 65);
            buttonAbout.FlatStyle = FlatStyle.Flat;
            buttonAbout.Location = new Point(888, 9);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(31, 31);
            buttonAbout.TabIndex = 16;
            buttonAbout.TextAlign = ContentAlignment.BottomCenter;
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // radioButtonRequired
            // 
            radioButtonRequired.AutoSize = true;
            radioButtonRequired.Checked = true;
            radioButtonRequired.CheckedColor = Color.WhiteSmoke;
            radioButtonRequired.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonRequired.Location = new Point(12, 78);
            radioButtonRequired.MinimumSize = new Size(0, 21);
            radioButtonRequired.Name = "radioButtonRequired";
            radioButtonRequired.Size = new Size(163, 25);
            radioButtonRequired.TabIndex = 0;
            radioButtonRequired.TabStop = true;
            radioButtonRequired.Text = "Required Plugins";
            radioButtonRequired.UncheckedColor = Color.Gray;
            radioButtonRequired.UseVisualStyleBackColor = true;
            radioButtonRequired.CheckedChanged += radioButtonRequired_CheckedChanged;
            // 
            // radioButtonRecommended
            // 
            radioButtonRecommended.AutoSize = true;
            radioButtonRecommended.CheckedColor = Color.WhiteSmoke;
            radioButtonRecommended.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonRecommended.Location = new Point(12, 109);
            radioButtonRecommended.MinimumSize = new Size(0, 21);
            radioButtonRecommended.Name = "radioButtonRecommended";
            radioButtonRecommended.Size = new Size(208, 25);
            radioButtonRecommended.TabIndex = 1;
            radioButtonRecommended.Text = "Recommended Plugins";
            radioButtonRecommended.UncheckedColor = Color.Gray;
            radioButtonRecommended.UseVisualStyleBackColor = true;
            radioButtonRecommended.CheckedChanged += radioButtonRecommended_CheckedChanged;
            // 
            // radioButtonRequiredAndRecommended
            // 
            radioButtonRequiredAndRecommended.AutoSize = true;
            radioButtonRequiredAndRecommended.CheckedColor = Color.WhiteSmoke;
            radioButtonRequiredAndRecommended.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonRequiredAndRecommended.Location = new Point(12, 140);
            radioButtonRequiredAndRecommended.MinimumSize = new Size(0, 21);
            radioButtonRequiredAndRecommended.Name = "radioButtonRequiredAndRecommended";
            radioButtonRequiredAndRecommended.Size = new Size(310, 25);
            radioButtonRequiredAndRecommended.TabIndex = 2;
            radioButtonRequiredAndRecommended.Text = "Required and Recommended Plugins";
            radioButtonRequiredAndRecommended.UncheckedColor = Color.Gray;
            radioButtonRequiredAndRecommended.UseVisualStyleBackColor = true;
            radioButtonRequiredAndRecommended.CheckedChanged += radioButtonRequiredRecommended_CheckedChanged;
            // 
            // radioButtonAll
            // 
            radioButtonAll.AutoSize = true;
            radioButtonAll.CheckedColor = Color.WhiteSmoke;
            radioButtonAll.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonAll.Location = new Point(329, 78);
            radioButtonAll.MinimumSize = new Size(0, 21);
            radioButtonAll.Name = "radioButtonAll";
            radioButtonAll.Size = new Size(115, 25);
            radioButtonAll.TabIndex = 3;
            radioButtonAll.Text = "All Plugins";
            radioButtonAll.UncheckedColor = Color.Gray;
            radioButtonAll.UseVisualStyleBackColor = true;
            radioButtonAll.CheckedChanged += radioButtonAll_CheckedChanged;
            // 
            // radioButtonCustom
            // 
            radioButtonCustom.AutoSize = true;
            radioButtonCustom.CheckedColor = Color.WhiteSmoke;
            radioButtonCustom.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonCustom.Location = new Point(329, 140);
            radioButtonCustom.MinimumSize = new Size(0, 21);
            radioButtonCustom.Name = "radioButtonCustom";
            radioButtonCustom.Size = new Size(96, 25);
            radioButtonCustom.TabIndex = 5;
            radioButtonCustom.Text = "Custom";
            radioButtonCustom.UncheckedColor = Color.Gray;
            radioButtonCustom.UseVisualStyleBackColor = true;
            radioButtonCustom.CheckedChanged += radioButtonCustom_CheckedChanged;
            // 
            // radioButtonOutdated
            // 
            radioButtonOutdated.AutoSize = true;
            radioButtonOutdated.CheckedColor = Color.WhiteSmoke;
            radioButtonOutdated.Enabled = false;
            radioButtonOutdated.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonOutdated.Location = new Point(329, 109);
            radioButtonOutdated.MinimumSize = new Size(0, 21);
            radioButtonOutdated.Name = "radioButtonOutdated";
            radioButtonOutdated.Size = new Size(110, 25);
            radioButtonOutdated.TabIndex = 4;
            radioButtonOutdated.Text = "Outdated";
            radioButtonOutdated.UncheckedColor = Color.Gray;
            radioButtonOutdated.UseVisualStyleBackColor = true;
            radioButtonOutdated.CheckedChanged += radioButtonOutdated_CheckedChanged;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 23, 45);
            ClientSize = new Size(932, 663);
            Controls.Add(labelAutomaticallyExtract);
            Controls.Add(checkBoxExtract);
            Controls.Add(buttonClearSelection);
            Controls.Add(radioButtonOutdated);
            Controls.Add(radioButtonCustom);
            Controls.Add(radioButtonAll);
            Controls.Add(radioButtonRequiredAndRecommended);
            Controls.Add(radioButtonRecommended);
            Controls.Add(radioButtonRequired);
            Controls.Add(buttonAbout);
            Controls.Add(progressBarDownload);
            Controls.Add(panelRichTextBox);
            Controls.Add(labelVersion);
            Controls.Add(labelOpenUrlsOnly);
            Controls.Add(labelWarning2);
            Controls.Add(labelWarning1);
            Controls.Add(buttonOpenFolder);
            Controls.Add(buttonDownload);
            Controls.Add(panelCheckedListBoxPlugins);
            Controls.Add(panelTextBoxSaveLocation);
            Controls.Add(buttonSaveFolder);
            Controls.Add(buttonUnZIP);
            Controls.Add(checkBoxOpenUrlsOnly);
            Controls.Add(buttonTest);
            Controls.Add(pictureBoxStreamUPLogo);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private CheckedListBox checkedListBoxPlugins;
        private TextBox textBoxSaveLocation;
        private Button buttonSaveFolder;
        private Button buttonDownload;
        private Button buttonTest;
        private CheckBox checkBoxExtract;
        private CheckBox checkBoxOpenUrlsOnly;
        private Button buttonOpenFolder;
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
        private Button buttonAbout;
        private Button buttonClearSelection;
        private Custom_Controls.RadioButtonFlat radioButtonRequired;
        private Custom_Controls.RadioButtonFlat radioButtonRecommended;
        private Custom_Controls.RadioButtonFlat radioButtonRequiredAndRecommended;
        private Custom_Controls.RadioButtonFlat radioButtonAll;
        private Custom_Controls.RadioButtonFlat radioButtonCustom;
        private Custom_Controls.RadioButtonFlat radioButtonOutdated;
    }
}