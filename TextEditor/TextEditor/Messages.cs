using System.Windows.Forms;

namespace TextEditor
{
    public interface IMessages
    {
        void ShowMessage(string message);

        void ShowExclamation(string message);

        void ShowError(string message);
    }

    public class Messages : IMessages
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowExclamation(string message)
        {
            MessageBox.Show(message, "Exclamation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}