using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Streamup_Pluginstall_V2.Custom_Controls {
    public class RadioButtonFlat : RadioButton {
        private Color checkedColor = Color.MediumSlateBlue;
        private Color uncheckedColor = Color.Gray;

        public Color CheckedColor { get => checkedColor; set { checkedColor = value; this.Invalidate(); }}
        public Color UncheckedColor { get => uncheckedColor; set { uncheckedColor = value; this.Invalidate(); }}

        // Constructor
        public RadioButtonFlat() {
            this.MinimumSize = new Size(0, 21);
        }

        // Overridden Methods
        protected override void OnPaint(PaintEventArgs e) {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            float rbBorderSize = 18F;
            float rbCheckSize = 12F;

            RectangleF rectRbBorder = new RectangleF() {
                X = 0.5F,
                Y = (this.Height - rbBorderSize) / 2,
                Width = rbBorderSize,
                Height = rbBorderSize
            };

            RectangleF rectRbCheck = new RectangleF() {
                X = rectRbBorder.X + ((rectRbBorder.Width - rbCheckSize) / 2),
                Y = (this.Height - rbCheckSize) / 2,
                Width = rbCheckSize,
                Height = rbCheckSize
            };

            using (Pen penBorder = new Pen(CheckedColor, 1.6F))
            using (SolidBrush brushRbCheck = new SolidBrush(checkedColor))
            using (SolidBrush brushText = new SolidBrush(this.ForeColor)) {

                SolidBrush textColor = brushText;

                graphics.Clear(this.BackColor);
                if (this.Checked) {
                    graphics.DrawEllipse(penBorder, rectRbBorder); // Circle Border
                    graphics.FillEllipse(brushRbCheck, rectRbCheck); // Fill the Circle
                } else {
                    penBorder.Color = uncheckedColor;
                    graphics.DrawEllipse(penBorder, rectRbBorder); // Circle Border
                }

                if (this.Enabled == false) {
                    textColor = new SolidBrush(Color.DimGray);
                }

                graphics.DrawString(this.Text, this.Font, textColor, rbBorderSize + 8, (this.Height - TextRenderer.MeasureText(this.Text, this.Font).Height) / 2);
            };
        }

        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            this.Width = TextRenderer.MeasureText(this.Text, this.Font).Width + 30;
        }
    }
}
