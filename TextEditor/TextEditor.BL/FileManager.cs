using System.IO;
using System.Text;

namespace TextEditor.BL
{
    public interface IFileManager
    {
        string GetContent(string path, Encoding encoding);

        string GetContent(string path);

        void SaveContent(string content, string path, Encoding encoding);

        void SaveContent(string content, string path);

        int GetSymbolCount(string content);

        bool IsExist(string path);
    }

    public class FileManager : IFileManager
    {
        private readonly Encoding _encoding = Encoding.UTF8;//GetEncoding(1251);   // standart encoding

        public string GetContent(string path, Encoding encoding)
        {
            return File.ReadAllText(path, encoding);
        }

        public string GetContent(string path)
        {
            return GetContent(path, _encoding);
        }

        public void SaveContent(string content, string path, Encoding encoding)
        {
            File.WriteAllText(path, content, encoding);
        }

        public void SaveContent(string content, string path)
        {
            SaveContent(content, path, _encoding);
        }

        public int GetSymbolCount(string content)
        {
            return content.Length;
        }

        public bool IsExist(string path)
        {
            return File.Exists(path);
        }
    }
}