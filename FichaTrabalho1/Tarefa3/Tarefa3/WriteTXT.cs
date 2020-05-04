using System.IO;

namespace Tarefa3
{
    public class WriteTXT
    {
        private static string[] InvertOrder(string[] lines)
        {
            int index = lines.Length - 1;
            string[] compLines = new string[lines.Length]; //Serve como complemento ao array lines (para fazer a inversão)
            for (int i = 0; i < lines.Length; i++)
            {
                compLines[i] = lines[index--];
            }

            return compLines;
        }

        public static void Write(string[] lines) //Escreve o ficheiro txt na pasta bin (no momento da execução do programa)
        {
            File.WriteAllLines("lines_inverted.txt", InvertOrder(lines));
        }
    }
}