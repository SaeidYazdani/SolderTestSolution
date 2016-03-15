using System.Windows.Forms;
using SolderTestSolution.Controls;
using SolderTestSolution.Forms.Dialogs;

namespace SolderTestSolution.Forms
{
    /// <summary>
    /// This class is the main UI form
    /// </summary>
    public partial class MainForm : Form
    {
        private PinManager _pinManager;

        /// <summary>
        /// Default constructor for the MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            //just a simple test
            stateControl1.SetColorForAll(FillColor.Red);
            stateControl1.SetFillLevelForAll(FillLevel.Full);

            _pinManager.GetPinAt(0,3).SetColor(FillColor.Green);
            _pinManager.GetPinAt(0,3).SetFillLevel(FillLevel.Full);

            _pinManager.GetPinAt(1, 3).SetColor(FillColor.Green);
            _pinManager.GetPinAt(1, 3).SetFillLevel(FillLevel.Full);

            _pinManager.GetPinAt(2, 3).SetColor(FillColor.Blue);
            _pinManager.GetPinAt(2, 3).SetFillLevel(FillLevel.Half);

            _pinManager.GetPinAt(4, 0).SetColor(FillColor.Blue);
            _pinManager.GetPinAt(4, 0).SetFillLevel(FillLevel.Full);

            _pinManager.GetPinAt(5, 0).SetColor(FillColor.Blue);
            _pinManager.GetPinAt(5, 0).SetFillLevel(FillLevel.Full);

            _pinManager.GetPinAt(6, 0).SetColor(FillColor.Blue);
            _pinManager.GetPinAt(6, 0).SetFillLevel(FillLevel.Full);

            _pinManager.GetPinAt(7, 0).SetColor(FillColor.Blue);
            _pinManager.GetPinAt(7, 0).SetFillLevel(FillLevel.Full);

            _pinManager.GetPinAt(8, 0).SetColor(FillColor.Green);
            _pinManager.GetPinAt(8, 0).SetFillLevel(FillLevel.Half);

            _pinManager.GetPinAt(3, 0).SetColor(FillColor.Blue);
            _pinManager.GetPinAt(3, 0).SetFillLevel(FillLevel.Full);
                                 
            _pinManager.GetPinAt(3, 1).SetColor(FillColor.Blue);
            _pinManager.GetPinAt(3, 1).SetFillLevel(FillLevel.Full);
                                 
            _pinManager.GetPinAt(3, 2).SetColor(FillColor.Blue);
            _pinManager.GetPinAt(3, 2).SetFillLevel(FillLevel.Empty);
                                 
            _pinManager.GetPinAt(3, 3).SetColor(FillColor.Blue);
            _pinManager.GetPinAt(3, 3).SetFillLevel(FillLevel.Half);
                                 
            _pinManager.GetPinAt(3, 4).SetColor(FillColor.Green);
            _pinManager.GetPinAt(3, 4).SetFillLevel(FillLevel.Half);
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            _pinManager = new PinManager(11,12, stateControl1);
        }

        private void loadImagesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            LoadImageDialog lid = new LoadImageDialog();
            lid.FormClosing += delegate
            {
                if (lid.DialogResult == DialogResult.OK)
                {
                    imageControl1.LoadImage(lid.FileTopLeft, ImagePosition.TopLeft);
                    imageControl1.LoadImage(lid.FileTopRight, ImagePosition.TopRight);
                    imageControl1.LoadImage(lid.FileBottomLeft, ImagePosition.BottomLeft);
                    imageControl1.LoadImage(lid.FileBottomRight, ImagePosition.BottomRight);
                }             
            };
            lid.ShowDialog();
        }
    }
}
