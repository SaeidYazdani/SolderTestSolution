using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolderTestSolution.Controls
{
    public class Pin
    {
        public PinControl Control { get; private set; }
        public int Row { get; private set; }
        public int Col { get; private set; }

        private FillColor _fillColor = FillColor.Blue;
        private FillLevel _fillLevel = FillLevel.Half;

        public Pin(int row, int col, PinControl control)
        {
            Row = row;
            Col = col;
            Control = control;
            control.FillColor = _fillColor;
            control.FillLevel = _fillLevel;
        }

        public Pin(int row, int col, PinControl control, FillColor fillColor, FillLevel fillLevel)
            : this(row, col, control)
        {
            control.FillColor = _fillColor = fillColor;
            control.FillLevel = _fillLevel = fillLevel;
        }

        public void SetColor(FillColor color)
        {
            Control.FillColor = color;
        }

        public void SetFillLevel(FillLevel level)
        {
            Control.FillLevel = level;
        }
    }
}
