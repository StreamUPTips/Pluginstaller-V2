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
            radioButtonSuggested = new RadioButton();
            radioButtonRecommended = new RadioButton();
            radioButtonRecommendedSuggested = new RadioButton();
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
            groupBoxPlugins.Location = new Point(12, 128);
            groupBoxPlugins.Name = "groupBoxPlugins";
            groupBoxPlugins.Size = new Size(423, 284);
            groupBoxPlugins.TabIndex = 3;
            groupBoxPlugins.TabStop = false;
            groupBoxPlugins.Text = "Plugins";
            // 
            // checkedListBoxPlugins
            // 
            checkedListBoxPlugins.FormattingEnabled = true;
            checkedListBoxPlugins.Location = new Point(6, 22);
            checkedListBoxPlugins.Name = "checkedListBoxPlugins";
            checkedListBoxPlugins.SelectionMode = SelectionMode.None;
            checkedListBoxPlugins.Size = new Size(411, 256);
            checkedListBoxPlugins.Sorted = true;
            checkedListBoxPlugins.TabIndex = 0;
            checkedListBoxPlugins.ThreeDCheckBoxes = true;
            // 
            // radioButtonSuggested
            // 
            radioButtonSuggested.AutoSize = true;
            radioButtonSuggested.Location = new Point(12, 103);
            radioButtonSuggested.Name = "radioButtonSuggested";
            radioButtonSuggested.Size = new Size(122, 19);
            radioButtonSuggested.TabIndex = 4;
            radioButtonSuggested.Text = "Suggested Plugins";
            radioButtonSuggested.UseVisualStyleBackColor = true;
            radioButtonSuggested.CheckedChanged += radioButtonSuggested_CheckedChanged;
            // 
            // radioButtonRecommended
            // 
            radioButtonRecommended.AutoSize = true;
            radioButtonRecommended.Checked = true;
            radioButtonRecommended.Location = new Point(12, 78);
            radioButtonRecommended.Name = "radioButtonRecommended";
            radioButtonRecommended.Size = new Size(148, 19);
            radioButtonRecommended.TabIndex = 5;
            radioButtonRecommended.TabStop = true;
            radioButtonRecommended.Text = "Recommended Plugins";
            radioButtonRecommended.UseVisualStyleBackColor = true;
            radioButtonRecommended.CheckedChanged += radioButtonRecommended_CheckedChanged;
            // 
            // radioButtonRecommendedSuggested
            // 
            radioButtonRecommendedSuggested.AutoSize = true;
            radioButtonRecommendedSuggested.Location = new Point(190, 78);
            radioButtonRecommendedSuggested.Name = "radioButtonRecommendedSuggested";
            radioButtonRecommendedSuggested.Size = new Size(229, 19);
            radioButtonRecommendedSuggested.TabIndex = 6;
            radioButtonRecommendedSuggested.Text = "Recommended and Suggested Plugins";
            radioButtonRecommendedSuggested.UseVisualStyleBackColor = true;
            radioButtonRecommendedSuggested.CheckedChanged += radioButtonRecommendedSuggested_CheckedChanged;
            // 
            // radioButtonAll
            // 
            radioButtonAll.AutoSize = true;
            radioButtonAll.Location = new Point(190, 103);
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
            groupBoxSaveLocation.Location = new Point(12, 418);
            groupBoxSaveLocation.Name = "groupBoxSaveLocation";
            groupBoxSaveLocation.Size = new Size(417, 72);
            groupBoxSaveLocation.TabIndex = 8;
            groupBoxSaveLocation.TabStop = false;
            groupBoxSaveLocation.Text = "Save Location";
            // 
            // buttonSaveFolder
            // 
            buttonSaveFolder.Image = Properties.Resources.Folder;
            buttonSaveFolder.Location = new Point(370, 22);
            buttonSaveFolder.Name = "buttonSaveFolder";
            buttonSaveFolder.Size = new Size(41, 33);
            buttonSaveFolder.TabIndex = 1;
            buttonSaveFolder.UseVisualStyleBackColor = true;
            buttonSaveFolder.Click += buttonSaveFolder_Click;
            // 
            // textBoxSaveLocation
            // 
            textBoxSaveLocation.BackColor = SystemColors.ControlLightLight;
            textBoxSaveLocation.Location = new Point(6, 28);
            textBoxSaveLocation.Name = "textBoxSaveLocation";
            textBoxSaveLocation.ReadOnly = true;
            textBoxSaveLocation.Size = new Size(358, 23);
            textBoxSaveLocation.TabIndex = 0;
            // 
            // buttonDownload
            // 
            buttonDownload.Image = Properties.Resources.Download;
            buttonDownload.Location = new Point(691, 496);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(144, 45);
            buttonDownload.TabIndex = 9;
            buttonDownload.Text = "Download Plugins";
            buttonDownload.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // radioButtonCustom
            // 
            radioButtonCustom.AutoSize = true;
            radioButtonCustom.Location = new Point(344, 103);
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
            buttonExpand.Location = new Point(380, 12);
            buttonExpand.Name = "buttonExpand";
            buttonExpand.Size = new Size(55, 23);
            buttonExpand.TabIndex = 12;
            buttonExpand.Text = ">>";
            buttonExpand.UseVisualStyleBackColor = true;
            buttonExpand.Visible = false;
            buttonExpand.Click += buttonExpand_Click;
            // 
            // textBoxLogging
            // 
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
            buttonOpenFolder.Image = Properties.Resources.OpenFolder;
            buttonOpenFolder.Location = new Point(539, 496);
            buttonOpenFolder.Name = "buttonOpenFolder";
            buttonOpenFolder.Size = new Size(144, 45);
            buttonOpenFolder.TabIndex = 9;
            buttonOpenFolder.Text = "Open download folder";
            buttonOpenFolder.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonOpenFolder.UseVisualStyleBackColor = true;
            buttonOpenFolder.Click += buttonOpenFolder_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 552);
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
            Controls.Add(radioButtonRecommendedSuggested);
            Controls.Add(radioButtonRecommended);
            Controls.Add(radioButtonSuggested);
            Controls.Add(groupBoxPlugins);
            Controls.Add(label1);
            Controls.Add(labelStreamUP);
            Controls.Add(pictureBoxStreamUPLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainWindow";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StreamUP Pluginstaller V2";
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
        private RadioButton radioButtonSuggested;
        private RadioButton radioButtonRecommended;
        private RadioButton radioButtonRecommendedSuggested;
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
    }
}