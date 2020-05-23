using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P03.Utility;

namespace P03.Service
{
    public class Customer
    {
        public static void HusbandAction(object sender,EventArgs args)
        {
            Console.WriteLine("Husband  Action");
        }
        public static void WifeAction(object sender, EventArgs args)
        {
            Console.WriteLine("Wife  Action");
        }
        public static void SonAction(object sender, EventArgs args)
        {
            Console.WriteLine("Son   Action");
        }
        public static void MorePersonAction(object sender, EventArgs args)
        {
            Console.WriteLine("More Person Action");
        }
        public static void MoreChildAction(object sender, EventArgs args)
        {
            Console.WriteLine("More Child Action");
        }
        public static void MoreDogAction(object sender, EventArgs args)
        {
            Console.WriteLine("More Dog Action");
        }


    }
}
