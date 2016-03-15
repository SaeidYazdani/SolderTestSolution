using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;


namespace SolderTestSolution.Controls
{
    public class PinManager
    {
        private List<Pin> _pins; 
        private int _rows = 0;
        private int _cols = 0;
        private StateControl _host;

        public PinManager(int rows, int cols, StateControl host)
        {
            _rows = rows;
            _cols = cols;
            _host = host;

            //create rows*cols pin controls
            //calculate width and height of each control
            int width = host.Width/(cols + 1); //+1 is for free space for shifting in alternate rows
            int height = width; //we want circles...so be it!
            int halfWidth = width/2;

            //check if we can fit the pins in the host control
            if (height*rows > host.Height)
            {
                Debug.WriteLine("Requesting height increase for StateControl to fit pins");
                host.Height = height*rows;
            }

            _pins = new List<Pin>();
            _host.SuspendLayout();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    PinControl pc = new PinControl(i, j, "Pin " + i + "," + j)
                    {
                        Width = width,
                        Height = height
                    };

                    _pins.Add(new Pin(i,j, pc));

                    pc.Location = i%2 == 0 ? new Point(halfWidth + (j*width), i * height) 
                        : new Point(j*width, i*height);

                    Debug.WriteLine("Adding PinControl [{0}, {1}] to StateControl at [{2},{3}]"
                        , i, j, pc.Location.X, pc.Location.Y);
                    _host.Controls.Add(pc);

                }
            }
            _host.ResumeLayout(false);

            _host.PinManager = this;
        }

        /// <summary>
        /// Get <see cref="Pin"/> at specific row and column
        /// </summary>
        /// <param name="row">Row of the pin</param>
        /// <param name="col">Column of the pin</param>
        /// <returns><see cref="Pin"/></returns>
        public Pin GetPinAt(int row, int col)
        {
            return _pins.FirstOrDefault(p => p.Row == row && p.Col == col);
        }

        /// <summary>
        /// Set <see cref="FillColor"/> of a <see cref="Pin"/> at specific row and column
        /// </summary>
        /// <param name="row">Row of the pin</param>
        /// <param name="col">Column of the pin</param>
        /// <param name="color">Color to be set for the <see cref="Pin"/></param>
        public void SetPinColor(int row, int col, FillColor color)
        {
            GetPinAt(row, col).SetColor(color);
        }

        /// <summary>
        /// Set the <see cref="FillLevel"/> of a <see cref="Pin"/> at specific row and column
        /// </summary>
        /// <param name="row">Row of the pin</param>
        /// <param name="col">Column of the pin</param>
        /// <param name="level">Fill level to be set for the <see cref="Pin"/></param>
        public void SetPinFillLevel(int row, int col, FillLevel level)
        {
            GetPinAt(row, col).SetFillLevel(level);
        }

        /// <summary>
        /// Get a reference to list of all <see cref="Pin"/> items
        /// </summary>
        /// <returns>List of <see cref="Pin"/></returns>
        public List<Pin> GetAllPins()
        {
            if (_pins == null || _pins.Count == 0)
            {
                throw new NullReferenceException("List of pins is null or does not contain any pin");
            }

            return _pins;
        }
    }
}
