using System;
using System.Xml.Linq;

namespace Tarefa2
{
    public class ReadXML
    {
        public static void Read(string file)
        {
            XElement content = XElement.Load(file);
            foreach (var item in content.Elements())
            {
                Console.WriteLine($"{item.Element("weight").Value}");
            }
        }
    }
}