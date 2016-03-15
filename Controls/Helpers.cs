using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SolderTestSolution.Controls
{
    internal static class Helpers
    {
        public static Rectangle GetPaddedRect(Rectangle src, Padding padding)
        {
            Rectangle dest = new Rectangle();
            dest.X = src.X + padding.Left;
            dest.Y = src.Y + padding.Top;
            dest.Width = src.Width - (padding.Left + padding.Right);
            dest.Height = src.Height - (padding.Top + padding.Bottom);
            
            return dest;
        }

        public static Rectangle GetPaddedRect(Rectangle src, int all)
        {
            Rectangle dest = new Rectangle();
            dest.X = src.X + all;
            dest.Y = src.Y + all;
            dest.Width = src.Width - (all + all);
            dest.Height = src.Height - (all + all);

            return dest;
        }

        public static RectangleF GetPaddedRectF(Rectangle src, float all)
        {
            RectangleF dest = new RectangleF();
            dest.X = src.X + all;
            dest.Y = src.Y + all;
            dest.Width = src.Width - (all + all);
            dest.Height = src.Height - (all + all);

            return dest;
        }

        public static Color GetColorFromEnum(FillColor fc)
        {
            switch (fc)
            {
                case FillColor.Red:
                    return Color.Red;
                case FillColor.Green:
                    return Color.Green;
                case FillColor.Blue:
                    return Color.Blue;
                default:
                    throw new ArgumentOutOfRangeException(nameof(fc), fc, null);
            }
        }

    }
}
