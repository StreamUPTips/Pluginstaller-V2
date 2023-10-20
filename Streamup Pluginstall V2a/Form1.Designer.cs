namespace Streamup_Pluginstall_V2a {
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
            radioButtonRequired = new RadioButton();
            radioButtonRecommended = new RadioButton();
            radioButtonRequiredRecommended = new RadioButton();
            radioButtonAll = new RadioButton();
            groupBoxSaveLocation = new GroupBox();
            buttonSaveFolder = new Button();
            textBoxSaveLocation = new TextBox();
            button1 = new Button();
            radioButtonCustom = new RadioButton();
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
            // radioButtonRequired
            // 
            radioButtonRequired.AutoSize = true;
            radioButtonRequired.Location = new Point(12, 78);
            radioButtonRequired.Name = "radioButtonRequired";
            radioButtonRequired.Size = new Size(114, 19);
            radioButtonRequired.TabIndex = 4;
            radioButtonRequired.TabStop = true;
            radioButtonRequired.Text = "Required Plugins";
            radioButtonRequired.UseVisualStyleBackColor = true;
            // 
            // radioButtonRecommended
            // 
            radioButtonRecommended.AutoSize = true;
            radioButtonRecommended.Location = new Point(12, 103);
            radioButtonRecommended.Name = "radioButtonRecommended";
            radioButtonRecommended.Size = new Size(148, 19);
            radioButtonRecommended.TabIndex = 5;
            radioButtonRecommended.TabStop = true;
            radioButtonRecommended.Text = "Recommended Plugins";
            radioButtonRecommended.UseVisualStyleBackColor = true;
            radioButtonRecommended.CheckedChanged += radioButtonRecommended_CheckedChanged;
            // 
            // radioButtonRequiredRecommended
            // 
            radioButtonRequiredRecommended.AutoSize = true;
            radioButtonRequiredRecommended.Location = new Point(190, 78);
            radioButtonRequiredRecommended.Name = "radioButtonRequiredRecommended";
            radioButtonRequiredRecommended.Size = new Size(221, 19);
            radioButtonRequiredRecommended.TabIndex = 6;
            radioButtonRequiredRecommended.TabStop = true;
            radioButtonRequiredRecommended.Text = "Required and Recommended Plugins";
            radioButtonRequiredRecommended.UseVisualStyleBackColor = true;
            // 
            // radioButtonAll
            // 
            radioButtonAll.AutoSize = true;
            radioButtonAll.Location = new Point(190, 103);
            radioButtonAll.Name = "radioButtonAll";
            radioButtonAll.Size = new Size(81, 19);
            radioButtonAll.TabIndex = 7;
            radioButtonAll.TabStop = true;
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
            // button1
            // 
            button1.Image = Properties.Resources.Download;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(285, 496);
            button1.Name = "button1";
            button1.Size = new Size(144, 45);
            button1.TabIndex = 9;
            button1.Text = "Download Plugins";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustom
            // 
            radioButtonCustom.AutoSize = true;
            radioButtonCustom.Location = new Point(344, 103);
            radioButtonCustom.Name = "radioButtonCustom";
            radioButtonCustom.Size = new Size(67, 19);
            radioButtonCustom.TabIndex = 10;
            radioButtonCustom.TabStop = true;
            radioButtonCustom.Text = "Custom";
            radioButtonCustom.UseVisualStyleBackColor = true;
            radioButtonCustom.CheckedChanged += radioButtonCustom_CheckedChanged;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 552);
            Controls.Add(radioButtonCustom);
            Controls.Add(button1);
            Controls.Add(groupBoxSaveLocation);
            Controls.Add(radioButtonAll);
            Controls.Add(radioButtonRequiredRecommended);
            Controls.Add(radioButtonRecommended);
            Controls.Add(radioButtonRequired);
            Controls.Add(groupBoxPlugins);
            Controls.Add(label1);
            Controls.Add(labelStreamUP);
            Controls.Add(pictureBoxStreamUPLogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainWindow";
            SizeGripStyle = SizeGripStyle.Hide;
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
        private RadioButton radioButtonRequired;
        private RadioButton radioButtonRecommended;
        private RadioButton radioButtonRequiredRecommended;
        private RadioButton radioButtonAll;
        private CheckedListBox checkedListBoxPlugins;
        private GroupBox groupBoxSaveLocation;
        private TextBox textBoxSaveLocation;
        private Button buttonSaveFolder;
        private Button button1;
        private RadioButton radioButtonCustom;
    }
}