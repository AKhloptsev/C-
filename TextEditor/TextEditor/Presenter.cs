using System;
using TextEditor.BL;

namespace TextEditor
{
    public class Presenter
    {
        private readonly IMainForm _view;
        private readonly IFileManager _manager;
        private readonly IMessages _message;
        private string _currentFilePath;

        public Presenter(IMainForm view, IFileManager manager, IMessages message)
        {
            _view = view;
            _manager = manager;
            _message = message;

            _view.SetSymbolCount(0);

            _view.ContentChanged += _view_ContentChanged;
            _view.FileOpenClick += _view_FileOpenClick;
            _view.FileSaveClick += _view_FileSaveClick;
        }

        private void _view_FileSaveClick(object sender, EventArgs e)
        {
            try
            {
                string content = _view.Content;
                _manager.SaveContent(content, _currentFilePath);
                _message.ShowMessage("File successfully saved");
            }
            catch (Exception ex)
            {
                _message.ShowError(ex.Message);
            }
        }

        private void _view_FileOpenClick(object sender, EventArgs e)
        {
            try
            {
                string filePath = _view.FilePath;

                bool isExist = _manager.IsExist(filePath);
                if (!isExist)
                {
                    _message.ShowExclamation("File is absent");
                    return;
                }
                _currentFilePath = filePath;
                string content = _manager.GetContent(_currentFilePath);
                int count = _manager.GetSymbolCount(content);
                _view.Content = content;
                _view.SetSymbolCount(count);
            }
            catch (Exception ex)
            {
                _message.ShowError(ex.Message);
            }
        }

        //+
        private void _view_ContentChanged(object sender, EventArgs e)
        {
            string content = _view.Content;

            int count = _manager.GetSymbolCount(content);

            _view.SetSymbolCount(count);
        }
    }
}