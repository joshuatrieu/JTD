using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace JTD
{
    static class ItemFactory
    {
        public static List<Item> ItemList = new List<Item>();
        public static Item CreateItem(string itemContent)
        {
            var item = new Item(itemContent);

            ItemList.Add(item);
            return item;
        }


        public static void PrintList()
        {
            foreach (var item in ItemList)
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<Item> GetItems(int itemNumber)
        {
            return ItemList.Where(a => a.ItemNumber == itemNumber);
        }

        public static void ChangeStatus(int itemNumber, int itemStatus)
        {
            var item = ItemList.SingleOrDefault(a => a.ItemNumber == itemNumber);
            if (item == null)
            {
                return;
            }
            else if (itemStatus == 1)
            {
                item.Status = Statuses.New;
            }
            else if (itemStatus == 2)
            {
                item.Status = Statuses.Working;
            }
            else if (itemStatus == 3)
            {
                item.Status = Statuses.Finished;
            }
            else if (itemStatus == 4)
            {
                item.Status = Statuses.Abandoned;
            }
            else
            {
                Console.WriteLine("Enter a correct input");
            }
        }
    }
}