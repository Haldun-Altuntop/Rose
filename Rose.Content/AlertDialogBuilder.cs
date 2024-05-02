namespace Rose.Content
{
    public class AlertDialogBuilder
    {
        public string Title { get; private set; }
        public string Message { get; private set; }

        private string? positiveButtontext, negativeButtontext;
        
        public DialogType Type { get; set; }
        private Form Owner {  get; set; }

        public AlertDialogBuilder(Form owner)
        {
            Owner = owner;
        }

        public AlertDialogBuilder(Form owner, string message)
        {
            this.Title = Resources.Strings.CAUTION;
            this.Message = message;
            Owner = owner;
        }

        public AlertDialogBuilder(Form owner, string title, string message, DialogType type)
        {
            this.Title = title;
            this.Message = message;
            this.Type = type;
            Owner = owner;
        }

        private Action<object, EventArgs>? onPositiveButtonClicked;
        private Action<object, EventArgs>? onNegativeButtonClicked;

        public void SetPositiveButton(string text, Action<object, EventArgs> action)
        {
            this.onPositiveButtonClicked = action;
            positiveButtontext = text;
        }

        public void SetNegativeButton(string text, Action<object, EventArgs> action)
        {
            this.onNegativeButtonClicked = action;
            negativeButtontext = text;
        }

        [Obsolete]
        public void SetOnPositiveButtonClicked(Action<object, EventArgs> onPositiveButtonClicked)
        {
            this.onPositiveButtonClicked += onPositiveButtonClicked;
        }
        [Obsolete]
        public void SetNegativeButtonClicked(Action<object, EventArgs> onNegativeButtonClicked)
        {
            this.onNegativeButtonClicked += onNegativeButtonClicked;
        }

        public AlertDialog Create()
        {
            AlertDialog dialog = new AlertDialog();

            dialog.Tittle = this.Title;
            dialog.Message = this.Message;
            dialog.Type = this.Type;

            dialog.Owner = Owner;

            dialog.btn_ok.Text = positiveButtontext;
            dialog.btn_cancel.Text = negativeButtontext;

            dialog.onPositiveButtonClicked += onPositiveButtonClicked;
            dialog.onNegativeButtonClicked += onNegativeButtonClicked;

            if (onPositiveButtonClicked == null && string.IsNullOrEmpty(positiveButtontext))
            {
                dialog.btn_ok.Visible = false;
            }

            if (onNegativeButtonClicked == null && string.IsNullOrEmpty(negativeButtontext))
            {
                dialog.btn_cancel.Visible = false;
            }

            return dialog;
        }

        public enum DialogType
        {
            Log,
            Warning,
            Error
        }
    }
}
