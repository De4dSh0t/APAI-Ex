using System;
using System.Text;
using System.Xml.Linq;

namespace Tarefa2
{
    public class ReadXML
    {
        public static void Read(string file)
        {
            Inventory inventory = new Inventory();
            XElement content = XElement.Load(file);
            foreach (var item in content.Elements())
            {
                //Adiciona à lista do "Inventory" os elementos defenidos através do construtor do "InventoryItem"
                inventory.AddToList(new InventoryItem(item.Element("name").Value, 
                    Int32.Parse(item.Element("weight").Value), 
                    Int32.Parse(item.Element("quantity").Value)));
                
                //Escreve na consola os items
                Console.WriteLine(inventory.ToString());
            }
        }
    }
}