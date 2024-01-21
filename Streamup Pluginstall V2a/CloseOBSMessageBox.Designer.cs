namespace Streamup_Pluginstall_V2 {
    partial class CloseOBSMessageBox {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloseOBSMessageBox));
            buttonYes = new Button();
            buttonNo = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonYes
            // 
            buttonYes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonYes.AutoSize = true;
            buttonYes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonYes.BackColor = Color.FromArgb(66, 67, 86);
            buttonYes.DialogResult = DialogResult.Yes;
            buttonYes.FlatAppearance.BorderSize = 0;
            buttonYes.FlatStyle = FlatStyle.Flat;
            buttonYes.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonYes.ForeColor = Color.White;
            buttonYes.Location = new Point(387, 182);
            buttonYes.MinimumSize = new Size(100, 40);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(254, 40);
            buttonYes.TabIndex = 0;
            buttonYes.Text = "Yes force close OBS-Studio for me!";
            buttonYes.UseVisualStyleBackColor = false;
            // 
            // buttonNo
            // 
            buttonNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNo.AutoSize = true;
            buttonNo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonNo.BackColor = Color.FromArgb(66, 67, 86);
            buttonNo.DialogResult = DialogResult.No;
            buttonNo.FlatAppearance.BorderSize = 0;
            buttonNo.FlatStyle = FlatStyle.Flat;
            buttonNo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNo.ForeColor = Color.White;
            buttonNo.Location = new Point(647, 182);
            buttonNo.MinimumSize = new Size(100, 40);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(243, 40);
            buttonNo.TabIndex = 0;
            buttonNo.Text = "No I will close OBS-Studio myself";
            buttonNo.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AndiGasmRight;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(167, 12);
            label1.Name = "label1";
            label1.Size = new Size(722, 147);
            label1.TabIndex = 2;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CloseOBSMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 23, 45);
            ClientSize = new Size(902, 234);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonNo);
            Controls.Add(buttonYes);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CloseOBSMessageBox";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Uh Oh You didn't close your OBS!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonYes;
        private Button buttonNo;
        private PictureBox pictureBox1;
        private Label label1;
    }
}