using System;
using System.Windows.Forms;
using TextEditor.BL;

namespace TextEditor
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            Messages messages = new Messages();
            FileManager manager = new FileManager();

            Presenter presenter = new Presenter(form, manager, messages);
            Application.Run(form);
        }
    }
}