using System.ComponentModel;

namespace _06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string info = Console.ReadLine();
            
            List<Box> boxes = new List<Box>();

            while (info != "end")
            {
                string[] infoAsArray = info.Split();

                string serialNumber = infoAsArray[0];
                string itemName = infoAsArray[1];
                int ItemQuantity = int.Parse(infoAsArray[2]);
                decimal ItemPrice = decimal.Parse(infoAsArray[3]);

                Item item = new Item()
                {
                    Name = itemName,
                    Price = ItemPrice,
                };

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = item,
                    ItemQuantity = ItemQuantity,
                    priceForBox = ItemQuantity * ItemPrice,

                };
                boxes.Add(box);

                info = Console.ReadLine();
            }

            foreach (var box in boxes.OrderByDescending(x => x.priceForBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.priceForBox:F2}");
            }
        }

        public class Item
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
        public class Box
        {
            public string SerialNumber { get; set; }
            public Item Item { get; set; }

            public int ItemQuantity { get; set; }
            public decimal priceForBox { get; set; }
        }
    }
}