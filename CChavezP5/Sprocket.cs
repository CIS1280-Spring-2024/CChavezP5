using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CchavezP5
{
    public abstract class Sprocket
    {
        //  The sprocket class and ABSTRACT class that has the following members:
        //  Fields
        //  Fully qualified properties for, number of items and number of teeth.
        private int numItems;
        private int numTeeth;
        //  A read only property for Price and ItemID.
        private readonly int itemID;
        private readonly decimal price;

        //  Properties
        public int ItemID { get; set; }
        public int NumItems { get; set; }
        public int NumTeeth { get; set; }
        public decimal Price { get; set; }

        //  Constructors
        //  A parameterless and a three-parameter constructor(itemID, numItems and numteeth).
        public Sprocket():this(0,0,0) { }

        public Sprocket(int NumItems, int Numteeth, int ItemID) 
        {
            numItems = NumItems;
            numTeeth = Numteeth;
            itemID = ItemID;
        }

        //  Methods

        //  A protected abstract void Calculate method that will be implemented in three child class to calculate
        //  the price based on the business logic described above.
        protected abstract void Calc();
        public override string ToString()
        {
            //  A ToString that concatenates order number, number, teeth, material and price. 
            string output = "";
            return output;
        }
    }
}
