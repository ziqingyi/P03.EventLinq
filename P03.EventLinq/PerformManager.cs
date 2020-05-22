using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.EventLinq
{
    public class PerformManager
    {
        public static readonly PerformManager instance = new PerformManager();

        public void PerformShow(Action action)
        {
            Console.WriteLine("show action");
            action.Invoke();
            Console.WriteLine("action finish");
        }



    }
}
