using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Part_2
{
    class Inventory
    {
        public void LoadInventoryFromFile(string filePath)
        {
            _itemList.Clear();
            AddInventoryFromFile(filePath);
        }

        public void AddInventoryFromFile(string filePath)
        {
            //string str;
            string[] str;
            
            using (StreamReader sr = new StreamReader(filePath))
            {

                while (!sr.EndOfStream)
                {
                    str = sr.ReadLine().Split(',');
                    string name = str[0];
                    int quantity = Convert.ToInt32(str[1]);
                    int price = Convert.ToInt32(str[2]);
                    for (int i = 0; i < _itemList.Count; i++)
                    {
                        if(_itemList[i].GetName() == name)
                        {
                            var q = _itemList[i].GetQuantity();
                            _itemList[i].SetQuantity(q + quantity);
                            quantity = 0;
                        }
                    }

                    if (quantity != 0)
                    {
                        Item item = new Item(name, quantity, price);
                        _itemList.Add(item);
                    }
                }
            }
        }

        public void WriteInventoryToFile(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath)) {
                for(int i = 0; i < _itemList.Count; i++)
                {
                    Item o = _itemList[i];
                    string name = o.GetName();
                    int quantity = o.GetQuantity();
                    int value = o.GetPrice();

                    sw.WriteLine(name + "," + quantity + "," + value);
                }
            }
            
        }

        public int TotalNumberOfItems()
        {
            int itemcount = 0;
            for (int i = 0; i < _itemList.Count; i++)
            {
                itemcount += _itemList[i].GetQuantity();
            }
            return itemcount;
        }

        public int InventoryValue()
        {
            int value = 0; 
            for(int i = 0; i < _itemList.Count; i++)
            {
                value += _itemList[i].GetPrice();
            }
            return value;
        }
        class Item
        {
            string _name;
            int _quantity;
            int _price;

            public Item(string name, int quantity, int price)
            {
                _name = name;
                _quantity = quantity;
                _price = price;
            }

            public string GetName()
            {
                return _name;
            }

            public int GetQuantity()
            {
                return _quantity;
            }

            public void SetQuantity(int amount)
            {
                _quantity = amount;
            }

            public int GetPrice()
            {
                return _price;
            }
        }

        List<Item> _itemList = new List<Item>();

        public int GetEntryCount()
        {
            return _itemList.Count;
        }

        public void ShowInventory(int y = 0)
        {
            int quantityPos = 30;
            int pricePos = 40;
            Console.SetCursorPosition(0, y);
            Console.Write("Item");
            Console.SetCursorPosition(quantityPos, y);
            Console.Write("Quantity");
            Console.SetCursorPosition(pricePos, y);
            Console.WriteLine("Price");
            Console.WriteLine("-----------------------------------------------------------");

            for (int i = 0; i < _itemList.Count; i++)
            {
                Console.SetCursorPosition(0, y + i + 2);
                Console.Write(_itemList[i].GetName());
                Console.SetCursorPosition(quantityPos, y + i + 2);
                Console.Write(_itemList[i].GetQuantity());
                Console.SetCursorPosition(pricePos, y + i + 2);
                Console.WriteLine(_itemList[i].GetPrice());
            }
            Console.WriteLine();

            Console.Write("Total number of items: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(TotalNumberOfItems());
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Value of inventory: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(InventoryValue());
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
