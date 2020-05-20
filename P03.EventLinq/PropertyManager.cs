using P03.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P03.EventLinq
{
    public class PropertyManager
    {
        public static readonly PropertyManager instance = new PropertyManager();

        public static void ShowPropertyFields<T>(T t) where T: AbstractPerform, InterfacePerform
        {
            if (t == null)
            {
                return;
            }

            Type type = t.GetType();

            PropertyInfo[] properties = type.GetProperties();
            FieldInfo[] fields = type.GetFields();
            Console.WriteLine("show Property as below: ");
            foreach (PropertyInfo item in properties)
            {
                Console.WriteLine($" {item.Name} = {item.GetValue(t)} ");
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("show fields as below: ");
            foreach (FieldInfo item in fields)
            {
                Console.WriteLine($" {item.Name} = {item.GetValue(t)} ");
            }
            Console.WriteLine("-------------------------------------");
        }

    }
}
