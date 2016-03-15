namespace SolderTestSolution.Controls
{
    partial class ImageControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbTopLeft = new System.Windows.Forms.PictureBox();
            this.pbTopRight = new System.Windows.Forms.PictureBox();
            this.pbBottomLeft = new System.Windows.Forms.PictureBox();
            this.pbBottomRight = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBottomLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBottomRight)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pbBottomRight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbBottomLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbTopRight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbTopLeft, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 300);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pbTopLeft
            // 
            this.pbTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTopLeft.Location = new System.Drawing.Point(3, 3);
            this.pbTopLeft.Name = "pbTopLeft";
            this.pbTopLeft.Size = new System.Drawing.Size(194, 144);
            this.pbTopLeft.TabIndex = 0;
            this.pbTopLeft.TabStop = false;
            // 
            // pbTopRight
            // 
            this.pbTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTopRight.Location = new System.Drawing.Point(203, 3);
            this.pbTopRight.Name = "pbTopRight";
            this.pbTopRight.Size = new System.Drawing.Size(194, 144);
            this.pbTopRight.TabIndex = 1;
            this.pbTopRight.TabStop = false;
            // 
            // pbBottomLeft
            // 
            this.pbBottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBottomLeft.Location = new System.Drawing.Point(3, 153);
            this.pbBottomLeft.Name = "pbBottomLeft";
            this.pbBottomLeft.Size = new System.Drawing.Size(194, 144);
            this.pbBottomLeft.TabIndex = 2;
            this.pbBottomLeft.TabStop = false;
            // 
            // pbBottomRight
            // 
            this.pbBottomRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBottomRight.Location = new System.Drawing.Point(203, 153);
            this.pbBottomRight.Name = "pbBottomRight";
            this.pbBottomRight.Size = new System.Drawing.Size(194, 144);
            this.pbBottomRight.TabIndex = 3;
            this.pbBottomRight.TabStop = false;
            // 
            // ImageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ImageControl";
            this.Size = new System.Drawing.Size(400, 300);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTopLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBottomLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBottomRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbBottomRight;
        private System.Windows.Forms.PictureBox pbBottomLeft;
        private System.Windows.Forms.PictureBox pbTopRight;
        private System.Windows.Forms.PictureBox pbTopLeft;
    }
}
