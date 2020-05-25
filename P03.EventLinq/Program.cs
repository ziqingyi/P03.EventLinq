using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P03.Utility;

namespace P03.EventLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("**********************Show Performance****************************");
                //ShowPerformMethod.Show();
            }
            

            {
                Console.WriteLine("********************Linq Extension to get random number*********************");
                List<int> list = new List<int>()
                {
                    1, 3, 4, 5, 6, 7, 8, 9, 91, 44, 56, 46, 99, 190, 33, 23, 123, 12, 56
                };

                var random1 = list.GetRandomList(5);
                foreach (var item in random1)
                {
                    Console.WriteLine(item);
                }
                var random2 = list.GetRandomInCollection(5);
                foreach (var item in random1)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("order by ----");

                var order1 = list.OrderBy(x => Guid.NewGuid()).Take(5);
                foreach (var item in order1)
                {
                    Console.WriteLine(item);
                }
                var order2 = list.OrderBy(x => 1).Take(5);
                foreach (var item in order2)
                {
                    Console.WriteLine(item);
                }
                var order3 = list.OrderBy(x => x *-1 ).Take(5);
                foreach (var item in order3)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
