using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CchavezP5
{
    internal class PlasticSprocket:Sprocket
    {
        PlasticSprocket() { }
        PlasticSprocket(int NumItems, int Numteeth, int ItemID) : base(NumItems, Numteeth, ItemID)
        {
            Calc();
        }

        protected override void Calc()
        {
            //  Spacely charges
            //  2 cents per tooth for plastic.
            //  The cost of a sprocket is the number of teeth times the number of sprockets times the price per tooth.
            Price = NumTeeth * NumItems * .02M;
        }
        public override string ToString()
        {
            //  The ToString should call the base class ToString and add the material (“ Material: steel” for example).
            string output = "";
            return output;
        }
    }
}
