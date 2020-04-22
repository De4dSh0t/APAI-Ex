using System.IO;
using System.Text;

namespace Tarefa1
{
    public class ReadText
    {
        private string fileName;

        public ReadText(string fileName)
        {
            this.fileName = fileName;
        }

        public string Read()
        {
            return File.ReadAllText(fileName, Encoding.UTF8);
        }
    }
}