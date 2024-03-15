using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CchavezP5
{
    internal class Address
    {
        //  Create a class to hold an address:
        //  Properties
        public string Street { get; set; }
        public string City {  get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        //  Methods
        public override string ToString()
        {
            string output = "Address:\n"+ Street + "\n" +
                            City + ", " + State + ", " + ZipCode + "\n";
            return output;
        }
    }
}
