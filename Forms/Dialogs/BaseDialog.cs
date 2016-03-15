using System.Drawing;
using System.Windows.Forms;

namespace SolderTestSolution.Forms.Dialogs
{
    /// <summary>
    /// Base class for dialog forms. This class is abstract and can not be instanciated.
    /// </summary>
    public class BaseDialog : Form
    {
        protected Button buttonAccept;
        protected Button buttonCancel;

        private void InitializeComponent()
        {
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.Location = new System.Drawing.Point(253, 245);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 0;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(172, 245);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // BaseDialog
            // 
            this.AcceptButton = this.buttonAccept;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(340, 280);
            this.ControlBox = false;
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Name = "BaseDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        public BaseDialog()
        {
            InitializeComponent();
            
            Load += delegate
            {
                CenterToParent();
            };

            buttonAccept.Click += delegate
            {
                DialogResult = DialogResult.OK;
                Close();
            };

            buttonCancel.Click += delegate
            {
                DialogResult = DialogResult.Cancel;
                Close();
            };
        }
    }
}
