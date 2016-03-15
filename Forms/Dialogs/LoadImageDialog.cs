using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SolderTestSolution.Controls;

namespace SolderTestSolution.Forms.Dialogs
{
    public class LoadImageDialog : BaseDialog
    {
       public string FileTopLeft { get; private set; }
       public string FileTopRight { get; private set; }
        public string FileBottomLeft { get; private set; }
        public string FileBottomRight { get; private set; }

        private System.Windows.Forms.Button _buttonBottomRight;
        private System.Windows.Forms.Button _buttonBottomLeft;
        private System.Windows.Forms.Button _buttonTopRight;
        private System.Windows.Forms.Button _buttonTopLeft;
        private System.Windows.Forms.GroupBox groupBox1;

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._buttonTopLeft = new System.Windows.Forms.Button();
            this._buttonTopRight = new System.Windows.Forms.Button();
            this._buttonBottomLeft = new System.Windows.Forms.Button();
            this._buttonBottomRight = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(253, 166);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(172, 166);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._buttonBottomRight);
            this.groupBox1.Controls.Add(this._buttonBottomLeft);
            this.groupBox1.Controls.Add(this._buttonTopRight);
            this.groupBox1.Controls.Add(this._buttonTopLeft);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load Images";
            // 
            // buttonTopLeft
            // 
            this._buttonTopLeft.Location = new System.Drawing.Point(6, 19);
            this._buttonTopLeft.Name = "_buttonTopLeft";
            this._buttonTopLeft.Size = new System.Drawing.Size(304, 23);
            this._buttonTopLeft.TabIndex = 0;
            this._buttonTopLeft.Text = "Top Left";
            this._buttonTopLeft.UseVisualStyleBackColor = true;
            // 
            // buttonTopRight
            // 
            this._buttonTopRight.Location = new System.Drawing.Point(6, 48);
            this._buttonTopRight.Name = "_buttonTopRight";
            this._buttonTopRight.Size = new System.Drawing.Size(304, 23);
            this._buttonTopRight.TabIndex = 1;
            this._buttonTopRight.Text = "Top Right";
            this._buttonTopRight.UseVisualStyleBackColor = true;
            // 
            // ButtonBottomLeft
            // 
            this._buttonBottomLeft.Location = new System.Drawing.Point(6, 77);
            this._buttonBottomLeft.Name = "_buttonBottomLeft";
            this._buttonBottomLeft.Size = new System.Drawing.Size(304, 23);
            this._buttonBottomLeft.TabIndex = 2;
            this._buttonBottomLeft.Text = "Bottom Left";
            this._buttonBottomLeft.UseVisualStyleBackColor = true;
            // 
            // ButtonBottomRight
            // 
            this._buttonBottomRight.Location = new System.Drawing.Point(6, 106);
            this._buttonBottomRight.Name = "_buttonBottomRight";
            this._buttonBottomRight.Size = new System.Drawing.Size(304, 23);
            this._buttonBottomRight.TabIndex = 3;
            this._buttonBottomRight.Text = "Bottom Right";
            this._buttonBottomRight.UseVisualStyleBackColor = true;
            // 
            // LoadImageDialog
            // 
            this.ClientSize = new System.Drawing.Size(340, 201);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoadImageDialog";
            this.Controls.SetChildIndex(this.buttonAccept, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public LoadImageDialog()
        {
            InitializeComponent();

            buttonAccept.Enabled = false;

            _buttonTopLeft.Click += delegate
            {
                _buttonTopLeft.Tag = FileTopLeft = ShowFileDialog();
                CheckAcceptCondition();
            };

            _buttonTopRight.Click += delegate
            {
                _buttonTopRight.Tag = FileTopRight = ShowFileDialog();
                CheckAcceptCondition();
            };

            _buttonBottomLeft.Click += delegate
            {
                _buttonBottomLeft.Tag = FileBottomLeft = ShowFileDialog();
                CheckAcceptCondition();
            };

            _buttonBottomRight.Click += delegate
            {
                _buttonBottomRight.Tag = FileBottomRight = ShowFileDialog();
                CheckAcceptCondition();
            };
        }

        private string ShowFileDialog()
        {
             OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            ofd.CheckFileExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }

            return null;
        }

        private void CheckAcceptCondition()
        {
            buttonAccept.Enabled = _buttonTopLeft.Tag != null && _buttonTopRight.Tag != null
                                   && _buttonBottomLeft.Tag != null && _buttonBottomRight.Tag != null;
        }
    }
}
