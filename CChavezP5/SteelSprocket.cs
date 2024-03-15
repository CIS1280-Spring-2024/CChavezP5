using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CchavezP5
{
    internal class SteelSprocket : Sprocket
    {
        SteelSprocket() { }

        //  Each will also need constructors that can be implemented by calling the base class constructor if you want.
        SteelSprocket(int NumItems, int Numteeth, int ItemID):base(NumItems, Numteeth, ItemID)
        {
            Calc();
        }

        protected override void Calc()
        {
            //  Spacely charges
            //  5 cents per tooth for steel sprockets,
            //  The cost of a sprocket is the number of teeth times the number of sprockets times the price per tooth.
            Price = NumTeeth * NumItems * .05M;
        }
        public override string ToString()
        {
            //  The ToString should call the base class ToString and add the material (“ Material: steel” for example).
            string output = "";
            return output;
        }
    }
}
