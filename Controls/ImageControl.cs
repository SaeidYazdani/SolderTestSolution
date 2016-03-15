using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SolderTestSolution.Controls
{
    public partial class ImageControl : UserControl
    {
        private Bitmap _imageTopLeft;
        private Bitmap _imageTopRight;
        private Bitmap _imageBottomLeft;
        private Bitmap _imageBottomRight;

        public ImageControl()
        {
            InitializeComponent();

            pbTopLeft.SizeMode = pbTopRight.SizeMode 
                = pbBottomLeft.SizeMode = pbBottomRight.SizeMode 
                = PictureBoxSizeMode.AutoSize;
        }

        /// <summary>
        /// Loads and displays an image in the given position in the control
        /// </summary>
        /// <param name="image">Image to be displayed</param>
        /// <param name="position">Position of the image in the control</param>
        public void LoadImage(Bitmap image, ImagePosition position)
        {
            switch (position)
            {
                case ImagePosition.TopLeft:
                    pbTopLeft.Image = image;
                    pbTopLeft.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case ImagePosition.TopRight:
                    pbTopRight.Image = image;
                    break;
                case ImagePosition.BottomLeft:
                    pbBottomLeft.Image = image;
                    break;
                case ImagePosition.BottomRight:
                    pbBottomRight.Image = image;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(position), position, null);
            }
        }

        /// <summary>
        /// Loads image from a file (in local disk) and displays it in the given position
        /// </summary>
        /// <param name="file">Full path to the file</param>
        /// <param name="position">Position of the image in the control</param>
        public void LoadImage(string file, ImagePosition position)
        {
            LoadImage(new Bitmap(file), position);
        }
    }
}
