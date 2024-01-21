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
    public class ToggleButton : CheckBox {
        // Fields
        private Color onBackColor = ColorTranslator.FromHtml("#157BF4");
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private bool solidStyle = true;

        [Category("Customization")]
        public Color OnBackColor { get => onBackColor; set { onBackColor = value; this.Invalidate(); }}

        [Category("Customization")]
        public Color OnToggleColor { get => onToggleColor; set { onToggleColor = value; this.Invalidate(); }}

        [Category("Customization")]
        public Color OffBackColor { get => offBackColor; set { offBackColor = value; this.Invalidate(); }}

        [Category("Customization")]
        public Color OffToggleColor { get => offToggleColor; set { offToggleColor = value; this.Invalidate(); }}    
        
        [DefaultValue(true)]
        [Category("Customization")]
        public bool SolidStyle { get => solidStyle; set { solidStyle = value; this.Invalidate(); }}

        // Disable Text Input
        public override string Text { get => base.Text; set { } }

        // Constructor
        public ToggleButton() {
            this.MinimumSize = new Size(50, 25);
        }

        // Methods
        private GraphicsPath GetFigurePath() {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e) {
            int toggleSize = this.Height - 5;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked) {
                if (solidStyle) {
                    e.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                } else {
                    e.Graphics.DrawPath(new Pen(onBackColor, 2), GetFigurePath());
                }

                e.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            } else {
                if (solidStyle) {
                    e.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                    e.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
                } else {
                    e.Graphics.DrawPath(new Pen(offBackColor, 2), GetFigurePath());
                }
                
                e.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }

            
        }
    }
}
