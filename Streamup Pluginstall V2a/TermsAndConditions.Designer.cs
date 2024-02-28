namespace Streamup_Pluginstall_V2 {
    partial class TermsAndConditions {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TermsAndConditions));
            labelAgreement = new Label();
            checkBoxDontShowAgain = new CheckBox();
            buttonAgree = new Button();
            buttonDisagree = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelAgreement
            // 
            labelAgreement.Location = new Point(12, 153);
            labelAgreement.Name = "labelAgreement";
            labelAgreement.Size = new Size(1005, 285);
            labelAgreement.TabIndex = 0;
            labelAgreement.Text = resources.GetString("labelAgreement.Text");
            labelAgreement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBoxDontShowAgain
            // 
            checkBoxDontShowAgain.Anchor = AnchorStyles.Top;
            checkBoxDontShowAgain.AutoSize = true;
            checkBoxDontShowAgain.Location = new Point(392, 516);
            checkBoxDontShowAgain.Name = "checkBoxDontShowAgain";
            checkBoxDontShowAgain.Size = new Size(251, 25);
            checkBoxDontShowAgain.TabIndex = 3;
            checkBoxDontShowAgain.Text = "Don't show this message again";
            checkBoxDontShowAgain.UseVisualStyleBackColor = true;
            // 
            // buttonAgree
            // 
            buttonAgree.BackColor = Color.FromArgb(66, 67, 86);
            buttonAgree.DialogResult = DialogResult.Yes;
            buttonAgree.FlatAppearance.BorderSize = 0;
            buttonAgree.FlatStyle = FlatStyle.Flat;
            buttonAgree.Location = new Point(242, 441);
            buttonAgree.Name = "buttonAgree";
            buttonAgree.Size = new Size(224, 69);
            buttonAgree.TabIndex = 1;
            buttonAgree.Text = "Agree and continue";
            buttonAgree.UseVisualStyleBackColor = false;
            buttonAgree.Click += buttonAgree_Click;
            // 
            // buttonDisagree
            // 
            buttonDisagree.BackColor = Color.FromArgb(66, 67, 86);
            buttonDisagree.DialogResult = DialogResult.No;
            buttonDisagree.FlatAppearance.BorderSize = 0;
            buttonDisagree.FlatStyle = FlatStyle.Flat;
            buttonDisagree.Location = new Point(563, 441);
            buttonDisagree.Name = "buttonDisagree";
            buttonDisagree.Size = new Size(224, 69);
            buttonDisagree.TabIndex = 1;
            buttonDisagree.Text = "Disagree and close";
            buttonDisagree.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.StreamUP_PluginstallerV2;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1005, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // TermsAndConditions
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 23, 45);
            ClientSize = new Size(1029, 550);
            Controls.Add(pictureBox1);
            Controls.Add(checkBoxDontShowAgain);
            Controls.Add(buttonAgree);
            Controls.Add(buttonDisagree);
            Controls.Add(labelAgreement);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TermsAndConditions";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StreamUP Pluginstaller V2 :: Terms and Conditions";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAgreement;
        private CheckBox checkBoxDontShowAgain;
        private Button buttonAgree;
        private Button buttonDisagree;
        private PictureBox pictureBox1;
    }
}