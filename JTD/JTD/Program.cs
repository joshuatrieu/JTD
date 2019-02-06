using System;

namespace JTD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time to be productive! Please select an option.");

            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create Item");
                Console.WriteLine("2. Change Status");
                Console.WriteLine("3. View List");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Goodbye.");
                        return;
                    case "1":
                        Console.Write("I want to: ");
                        var itemContent = Console.ReadLine();
                        var myItem = ItemFactory.CreateItem(itemContent);
                        Console.WriteLine($"({myItem.ItemNumber}) {myItem.ItemContent}, Create Date: {myItem.CreateDate},");
                        break;
                    case "2":
                        ItemFactory.PrintList();
                        Console.WriteLine("Please Select a number from the list.");
                        var itemNumber = Convert.ToInt32(Console.ReadLine());
                        var itemStatuses = Enum.GetNames(typeof(Statuses));
                        for (var i = 0; i < itemStatuses.Length; i++)
                        {
                            Console.WriteLine($"{ i + 1}. {itemStatuses[i]}");
                        }
                        Console.WriteLine($"What do you want to set item {itemNumber} to?");
                        var itemStatus = Convert.ToInt32(Console.ReadLine());
                        ItemFactory.ChangeStatus(itemNumber, itemStatus);
                        ItemFactory.PrintList();
                        break;
                    case "3":
                        ItemFactory.PrintList();
                        break;
                }
            }
        }
    }
}
