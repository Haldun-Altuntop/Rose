using Rose.Resources;
using System;
using System.Windows.Forms;
using static Rose.Content.AlertDialogBuilder;

namespace Rose.Content
{
    public partial class AlertDialog : Form
    {
        private DialogType type;

        public AlertDialog()
        {
            InitializeComponent();
        }

        public Action<object, EventArgs> onPositiveButtonClicked;
        public Action<object, EventArgs> onNegativeButtonClicked;

        private void OnPositiveButtonClicked(object sender, EventArgs e)
        {
            if (onPositiveButtonClicked != null) onPositiveButtonClicked(sender, e);
            Close();
        }

        private void OnNegativeButtonClicked(object sender, EventArgs e)
        {
            if (onNegativeButtonClicked != null) onNegativeButtonClicked(sender, e);
            Close();
        }

        public string Tittle
        {
            get
            {
                return this.Text;
            }

            internal set
            {
                this.Text = value;
            }
        }

        public string Message
        {
            get
            {
                return label.Text;
            }

            internal set
            {
                label.Text = value;
            }
        }

        public DialogType Type
        {
            get
            {
                return type;
            }

            internal set
            {
                type = value;

                if (type == DialogType.Log)
                {
                    
                }

                if (type == DialogType.Warning)
                {

                    pictureBox.Image = Utility.BytesToIcon(Resources.Drawable.warning).ToBitmap();
                }

                if (type == DialogType.Error)
                {
                    pictureBox.Image = Utility.BytesToIcon(Resources.Drawable.warning).ToBitmap();
                }
            }
        }
    }
}
