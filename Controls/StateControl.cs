using System.Diagnostics;
using System.Windows.Forms;

namespace SolderTestSolution.Controls
{
    public partial class StateControl: UserControl
    {

        public PinManager PinManager { get; set; }

        private bool _circlesArePlaced = false;

        public StateControl()
        {
            InitializeComponent();
        }

        public void SetColorForAll(FillColor color)
        {
            foreach (var c in Controls)
            {
                ((PinControl) c).FillColor = color;
            }
        }

        public void SetFillLevelForAll(FillLevel level)
        {
            foreach (var c in Controls)
            {
                ((PinControl)c).FillLevel = level;
            }
        }

    }
}
