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
            pictureBoxStreamUPLogo = new PictureBox();
            labelStreamUP = new Label();
            label1 = new Label();
            groupBoxPlugins = new GroupBox();
            checkedListBoxPlugins = new CheckedListBox();
            radioButtonRecommended = new RadioButton();
            radioButtonRequired = new RadioButton();
            radioButtonRequiredAndRecommended = new RadioButton();
            radioButtonAll = new RadioButton();
            groupBoxSaveLocation = new GroupBox();
            buttonSaveFolder = new Button();
            textBoxSaveLocation = new TextBox();
            buttonDownload = new Button();
            radioButtonCustom = new RadioButton();
            labelStatus = new Label();
            buttonExpand = new Button();
            textBoxLogging = new TextBox();
            checkBoxUnzip = new CheckBox();
            checkBoxOpenUrlsOnly = new CheckBox();
            buttonOpenFolder = new Button();
            radioButtonOutdated = new RadioButton();
            buttonUnZIP = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStreamUPLogo).BeginInit();
            groupBoxPlugins.SuspendLayout();
            groupBoxSaveLocation.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxStreamUPLogo
            // 
            pictureBoxStreamUPLogo.Image = Properties.Resources.sulogosmall;
            pictureBoxStreamUPLogo.Location = new Point(12, 12);
            pictureBoxStreamUPLogo.Name = "pictureBoxStreamUPLogo";
            pictureBoxStreamUPLogo.Size = new Size(60, 60);
            pictureBoxStreamUPLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStreamUPLogo.TabIndex = 0;
            pictureBoxStreamUPLogo.TabStop = false;
            // 
            // labelStreamUP
            // 
            labelStreamUP.AutoSize = true;
            labelStreamUP.BackColor = Color.Transparent;
            labelStreamUP.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelStreamUP.Location = new Point(76, 17);
            labelStreamUP.Name = "labelStreamUP";
            labelStreamUP.Size = new Size(195, 50);
            labelStreamUP.TabIndex = 1;
            labelStreamUP.Text = "StreamUP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(258, 31);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 2;
            label1.Text = "Pluginstaller V2";
            // 
            // groupBoxPlugins
            // 
            groupBoxPlugins.Controls.Add(checkedListBoxPlugins);
            groupBoxPlugins.ForeColor = Color.White;
            groupBoxPlugins.Location = new Point(12, 128);
            groupBoxPlugins.Name = "groupBoxPlugins";
            groupBoxPlugins.Size = new Size(423, 284);
            groupBoxPlugins.TabIndex = 3;
            groupBoxPlugins.TabStop = false;
            groupBoxPlugins.Text = "Plugins";
            // 
            // checkedListBoxPlugins
            // 
            checkedListBoxPlugins.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkedListBoxPlugins.BackColor = Color.FromArgb(42, 44, 65);
            checkedListBoxPlugins.BorderStyle = BorderStyle.FixedSingle;
            checkedListBoxPlugins.CheckOnClick = true;
            checkedListBoxPlugins.ForeColor = Color.White;
            checkedListBoxPlugins.FormattingEnabled = true;
            checkedListBoxPlugins.Location = new Point(9, 19);
            checkedListBoxPlugins.Name = "checkedListBoxPlugins";
            checkedListBoxPlugins.SelectionMode = SelectionMode.None;
            checkedListBoxPlugins.Size = new Size(411, 254);
            checkedListBoxPlugins.Sorted = true;
            checkedListBoxPlugins.TabIndex = 0;
            checkedListBoxPlugins.ThreeDCheckBoxes = true;
            // 
            // radioButtonRecommended
            // 
            radioButtonRecommended.AutoSize = true;
            radioButtonRecommended.Location = new Point(12, 103);
            radioButtonRecommended.Name = "radioButtonRecommended";
            radioButtonRecommended.Size = new Size(148, 19);
            radioButtonRecommended.TabIndex = 4;
            radioButtonRecommended.Text = "Recommended Plugins";
            radioButtonRecommended.UseVisualStyleBackColor = true;
            radioButtonRecommended.CheckedChanged += radioButtonRecommended_CheckedChanged;
            // 
            // radioButtonRequired
            // 
            radioButtonRequired.AutoSize = true;
            radioButtonRequired.Checked = true;
            radioButtonRequired.Location = new Point(12, 78);
            radioButtonRequired.Name = "radioButtonRequired";
            radioButtonRequired.Size = new Size(114, 19);
            radioButtonRequired.TabIndex = 5;
            radioButtonRequired.TabStop = true;
            radioButtonRequired.Text = "Required Plugins";
            radioButtonRequired.UseVisualStyleBackColor = true;
            radioButtonRequired.CheckedChanged += radioButtonRequired_CheckedChanged;
            // 
            // radioButtonRequiredAndRecommended
            // 
            radioButtonRequiredAndRecommended.AutoSize = true;
            radioButtonRequiredAndRecommended.Location = new Point(200, 78);
            radioButtonRequiredAndRecommended.Name = "radioButtonRequiredAndRecommended";
            radioButtonRequiredAndRecommended.Size = new Size(221, 19);
            radioButtonRequiredAndRecommended.TabIndex = 6;
            radioButtonRequiredAndRecommended.Text = "Required and Recommended Plugins";
            radioButtonRequiredAndRecommended.UseVisualStyleBackColor = true;
            radioButtonRequiredAndRecommended.CheckedChanged += radioButtonRequiredRecommended_CheckedChanged;
            // 
            // radioButtonAll
            // 
            radioButtonAll.AutoSize = true;
            radioButtonAll.Location = new Point(200, 103);
            radioButtonAll.Name = "radioButtonAll";
            radioButtonAll.Size = new Size(81, 19);
            radioButtonAll.TabIndex = 7;
            radioButtonAll.Text = "All Plugins";
            radioButtonAll.UseVisualStyleBackColor = true;
            radioButtonAll.CheckedChanged += radioButtonAll_CheckedChanged;
            // 
            // groupBoxSaveLocation
            // 
            groupBoxSaveLocation.Controls.Add(buttonSaveFolder);
            groupBoxSaveLocation.Controls.Add(textBoxSaveLocation);
            groupBoxSaveLocation.ForeColor = Color.White;
            groupBoxSaveLocation.Location = new Point(12, 418);
            groupBoxSaveLocation.Name = "groupBoxSaveLocation";
            groupBoxSaveLocation.Size = new Size(417, 72);
            groupBoxSaveLocation.TabIndex = 8;
            groupBoxSaveLocation.TabStop = false;
            groupBoxSaveLocation.Text = "Save Location";
            // 
            // buttonSaveFolder
            // 
            buttonSaveFolder.BackColor = Color.FromArgb(66, 67, 86);
            buttonSaveFolder.FlatAppearance.BorderSize = 0;
            buttonSaveFolder.FlatStyle = FlatStyle.Flat;
            buttonSaveFolder.Image = Properties.Resources.Folder;
            buttonSaveFolder.Location = new Point(370, 22);
            buttonSaveFolder.Name = "buttonSaveFolder";
            buttonSaveFolder.Size = new Size(41, 33);
            buttonSaveFolder.TabIndex = 1;
            buttonSaveFolder.UseVisualStyleBackColor = false;
            buttonSaveFolder.Click += buttonSaveFolder_Click;
            // 
            // textBoxSaveLocation
            // 
            textBoxSaveLocation.BackColor = Color.FromArgb(42, 44, 65);
            textBoxSaveLocation.BorderStyle = BorderStyle.FixedSingle;
            textBoxSaveLocation.ForeColor = Color.White;
            textBoxSaveLocation.Location = new Point(6, 28);
            textBoxSaveLocation.Name = "textBoxSaveLocation";
            textBoxSaveLocation.ReadOnly = true;
            textBoxSaveLocation.Size = new Size(358, 23);
            textBoxSaveLocation.TabIndex = 0;
            // 
            // buttonDownload
            // 
            buttonDownload.BackColor = Color.FromArgb(66, 67, 86);
            buttonDownload.FlatAppearance.BorderSize = 0;
            buttonDownload.FlatStyle = FlatStyle.Flat;
            buttonDownload.Image = Properties.Resources.Download;
            buttonDownload.Location = new Point(691, 498);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(144, 45);
            buttonDownload.TabIndex = 9;
            buttonDownload.Text = "Download Plugins";
            buttonDownload.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDownload.UseVisualStyleBackColor = false;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // radioButtonCustom
            // 
            radioButtonCustom.AutoSize = true;
            radioButtonCustom.Location = new Point(368, 103);
            radioButtonCustom.Name = "radioButtonCustom";
            radioButtonCustom.Size = new Size(67, 19);
            radioButtonCustom.TabIndex = 10;
            radioButtonCustom.Text = "Custom";
            radioButtonCustom.UseVisualStyleBackColor = true;
            radioButtonCustom.CheckedChanged += radioButtonCustom_CheckedChanged;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(12, 511);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(39, 15);
            labelStatus.TabIndex = 11;
            labelStatus.Text = "Status";
            labelStatus.Visible = false;
            // 
            // buttonExpand
            // 
            buttonExpand.BackColor = Color.FromArgb(66, 67, 86);
            buttonExpand.FlatAppearance.BorderSize = 0;
            buttonExpand.FlatStyle = FlatStyle.Flat;
            buttonExpand.Location = new Point(715, 62);
            buttonExpand.Name = "buttonExpand";
            buttonExpand.Size = new Size(120, 51);
            buttonExpand.TabIndex = 12;
            buttonExpand.Text = "Test Button";
            buttonExpand.UseVisualStyleBackColor = false;
            buttonExpand.Visible = false;
            buttonExpand.Click += buttonExpand_Click;
            // 
            // textBoxLogging
            // 
            textBoxLogging.BackColor = Color.FromArgb(42, 44, 65);
            textBoxLogging.BorderStyle = BorderStyle.FixedSingle;
            textBoxLogging.ForeColor = Color.White;
            textBoxLogging.Location = new Point(455, 128);
            textBoxLogging.Multiline = true;
            textBoxLogging.Name = "textBoxLogging";
            textBoxLogging.ReadOnly = true;
            textBoxLogging.ScrollBars = ScrollBars.Vertical;
            textBoxLogging.Size = new Size(380, 362);
            textBoxLogging.TabIndex = 13;
            // 
            // checkBoxUnzip
            // 
            checkBoxUnzip.AutoSize = true;
            checkBoxUnzip.Checked = true;
            checkBoxUnzip.CheckState = CheckState.Checked;
            checkBoxUnzip.Location = new Point(455, 12);
            checkBoxUnzip.Name = "checkBoxUnzip";
            checkBoxUnzip.Size = new Size(228, 19);
            checkBoxUnzip.TabIndex = 14;
            checkBoxUnzip.Text = "Automatically UnZIP downloaded files";
            checkBoxUnzip.UseVisualStyleBackColor = true;
            checkBoxUnzip.CheckedChanged += checkBoxUnzip_CheckedChanged;
            // 
            // checkBoxOpenUrlsOnly
            // 
            checkBoxOpenUrlsOnly.AutoSize = true;
            checkBoxOpenUrlsOnly.Location = new Point(455, 31);
            checkBoxOpenUrlsOnly.Name = "checkBoxOpenUrlsOnly";
            checkBoxOpenUrlsOnly.Size = new Size(110, 19);
            checkBoxOpenUrlsOnly.TabIndex = 15;
            checkBoxOpenUrlsOnly.Text = "Only open URLs";
            checkBoxOpenUrlsOnly.UseVisualStyleBackColor = true;
            checkBoxOpenUrlsOnly.CheckedChanged += checkBoxOpenUrlsOnly_CheckedChanged;
            // 
            // buttonOpenFolder
            // 
            buttonOpenFolder.BackColor = Color.FromArgb(66, 67, 86);
            buttonOpenFolder.FlatAppearance.BorderSize = 0;
            buttonOpenFolder.FlatStyle = FlatStyle.Flat;
            buttonOpenFolder.ForeColor = Color.White;
            buttonOpenFolder.Image = Properties.Resources.OpenFolder;
            buttonOpenFolder.Location = new Point(539, 498);
            buttonOpenFolder.Name = "buttonOpenFolder";
            buttonOpenFolder.Size = new Size(144, 45);
            buttonOpenFolder.TabIndex = 9;
            buttonOpenFolder.Text = "Open download folder";
            buttonOpenFolder.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonOpenFolder.UseVisualStyleBackColor = false;
            buttonOpenFolder.Click += buttonOpenFolder_Click;
            // 
            // radioButtonOutdated
            // 
            radioButtonOutdated.AutoSize = true;
            radioButtonOutdated.ForeColor = Color.White;
            radioButtonOutdated.Location = new Point(287, 103);
            radioButtonOutdated.Name = "radioButtonOutdated";
            radioButtonOutdated.Size = new Size(75, 19);
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
            buttonUnZIP.Location = new Point(715, 9);
            buttonUnZIP.Name = "buttonUnZIP";
            buttonUnZIP.Size = new Size(120, 23);
            buttonUnZIP.TabIndex = 17;
            buttonUnZIP.Text = "Unzip Current Files";
            buttonUnZIP.UseVisualStyleBackColor = false;
            buttonUnZIP.Click += buttonUnZIP_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 23, 45);
            ClientSize = new Size(847, 552);
            Controls.Add(buttonUnZIP);
            Controls.Add(radioButtonOutdated);
            Controls.Add(checkBoxOpenUrlsOnly);
            Controls.Add(checkBoxUnzip);
            Controls.Add(textBoxLogging);
            Controls.Add(buttonExpand);
            Controls.Add(labelStatus);
            Controls.Add(radioButtonCustom);
            Controls.Add(buttonOpenFolder);
            Controls.Add(buttonDownload);
            Controls.Add(groupBoxSaveLocation);
            Controls.Add(radioButtonAll);
            Controls.Add(radioButtonRequiredAndRecommended);
            Controls.Add(radioButtonRequired);
            Controls.Add(radioButtonRecommended);
            Controls.Add(groupBoxPlugins);
            Controls.Add(label1);
            Controls.Add(labelStreamUP);
            Controls.Add(pictureBoxStreamUPLogo);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainWindow";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StreamUP Pluginstaller V2";
            FormClosing += MainWindow_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxStreamUPLogo).EndInit();
            groupBoxPlugins.ResumeLayout(false);
            groupBoxSaveLocation.ResumeLayout(false);
            groupBoxSaveLocation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxStreamUPLogo;
        private Label labelStreamUP;
        private Label label1;
        private GroupBox groupBoxPlugins;
        private RadioButton radioButtonRecommended;
        private RadioButton radioButtonRequired;
        private RadioButton radioButtonRequiredAndRecommended;
        private RadioButton radioButtonAll;
        private CheckedListBox checkedListBoxPlugins;
        private GroupBox groupBoxSaveLocation;
        private TextBox textBoxSaveLocation;
        private Button buttonSaveFolder;
        private Button buttonDownload;
        private RadioButton radioButtonCustom;
        private Label labelStatus;
        private Button buttonExpand;
        private TextBox textBoxLogging;
        private CheckBox checkBoxUnzip;
        private CheckBox checkBoxOpenUrlsOnly;
        private Button buttonOpenFolder;
        private RadioButton radioButtonOutdated;
        private Button buttonUnZIP;
    }
}