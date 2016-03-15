using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SolderTestSolution.Controls
{
    public sealed class PinControl : Control
    {
        /// <summary>
        /// Get or Set the filling level of the circle
        /// </summary>
        public FillLevel FillLevel { get { return _fill; } set { _fill = value; Invalidate(); } }
        /// <summary>
        /// Get or Set the color of the circle
        /// </summary>
        public FillColor FillColor { get { return _fillColor; }
            set
            {
                _fillColor = value;
                _color = Helpers.GetColorFromEnum(value);
                Invalidate();
            }
        }

        private int _row = 0;
        private int _col = 0;
        private const int PADDING = 4;
        private Rectangle _rectMain;
        private Color _color;
        private FillColor _fillColor;
        private FillLevel _fill;

        private PinControl() : base()
        {
           Padding = new Padding(10);
           FillLevel = FillLevel.Half;
           FillColor = FillColor.Green;
           _rectMain = Helpers.GetPaddedRect(ClientRectangle, PADDING);
        }

        public PinControl(int row, int col, string text) : this()
        {
            _row = row;
            _col = col;
            Text = text;

            if (string.IsNullOrEmpty(Name))
            {
                Name = "PinControl_" + _row + "_" + _col;
            }
        }

        protected override void OnResize(EventArgs e)
        {
           base.OnResize(e);
            _rectMain = Helpers.GetPaddedRect(ClientRectangle, PADDING);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            DrawContainer(e);
            DrawState(e);
        }

        private void DrawContainer(PaintEventArgs p)
        {
            Brush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(brush);
            pen.Width = 4;
            p.Graphics.DrawEllipse(pen, _rectMain);

        }
        
        private void DrawState(PaintEventArgs p)
        {
            Brush brush = new SolidBrush(_color);

            switch (_fill)
            {
                case FillLevel.Empty:
                    //Do nothing :)
                    break;
                case FillLevel.Half:
                    p.Graphics.FillPie(brush, _rectMain, 0, 180);
                    break;
                case FillLevel.Full:
                    p.Graphics.FillPie(brush, _rectMain, 0, 360);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("FillLevel", "Unknown enum value");
            }
        }
    }
}
