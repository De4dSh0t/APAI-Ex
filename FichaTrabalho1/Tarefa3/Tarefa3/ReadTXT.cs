using System.IO;

namespace Tarefa3
{
    public class ReadTXT
    {
        public static string[] Read(string file) //Lê o ficheiro e retorna uma string divididas por linhas
        {
            return File.ReadAllLines(file);
        }
    }
}