using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Item
    {
        public double Price { get; set; }
        public double Quantity { get; set; }
        public Item(double price, double quantity)
        {
            this.Price = price;
            this.Quantity = quantity;
        }
        public void UpdateOnQuantity(double newPrice, double newQuantity)
        {
            this.Quantity += newQuantity;
            this.Price = newPrice;
        }
        public double TotalPrice()
        {
            return Price * Quantity;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Item> orders = new Dictionary<string, Item>();
            List<double> value = new List<double>();
            string[] command = Console.ReadLine().Split(' ');
            while (command[0] != "buy")
            {

                if (!orders.ContainsKey(command[0]))
                {
                    Item item = new Item(double.Parse(command[1]), double.Parse(command[2]));
                    orders.Add(command[0], item);


                }
                else
                {
                    Item curItem = orders[command[0]];
                    curItem.UpdateOnQuantity(double.Parse(command[1]), double.Parse(command[2]));

                }
                value.Clear();
                command = Console.ReadLine().Split(' ');
            }
            foreach (var penq in orders)
            {
                Console.WriteLine($"{penq.Key} -> {penq.Value.TotalPrice():F2}");
            }
        }
    }
}