using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CchavezP5
{
    internal class SprocketOrder
    {
        //  Feilds
        //  The SprocketOrder class is a class that has a List of sprockets the customer is ordering
        private List<Sprocket> sprocketOrders = new List<Sprocket>();
        //  Properties
        //  Properties for Address, CustomerName and TotalPrice.
        public string Address {  get; set; }
        public string CustomerName { get; set; }
        public List<Sprocket> SprocketOrders { get; set; }

        public decimal TotalPrice { get; set; }

        //  Constructors
        //  Parameterless and 4-parameter constructors.
        public SprocketOrder() 
        {
        }
        public SprocketOrder(string address, String customerName, Sprocket sprocket, decimal tPrice)
        {
            Address = address;
            CustomerName = customerName;
            sprocketOrders = new List<Sprocket>();
            TotalPrice = tPrice;
            Calc();
        }
        //  Methods 
        //  Methods to Add and Remove items from the Items List.
        void Add(Sprocket sprocket)
        {
            sprocketOrders.Add(sprocket);
        }
        void Remove(Sprocket sprocket)
        {
            sprocketOrders.Remove(sprocket);
        }
        //  A private void calculate method that calculates the total price by adding all the
        //  Items List prices together.
        private void Calc()
        {
            for (int i = 0; i < sprocketOrders.Count; i++) 
            {
                TotalPrice = TotalPrice + sprocketOrders[i].Price;
            }
        }
        public override string ToString()
        {
            //  A ToString method that returns Customer name, count of items in the order, total price and address
            //  if address is not null or “Local Pickup” if address is null.
            string output = "";
            return output;
        }
    }
}
