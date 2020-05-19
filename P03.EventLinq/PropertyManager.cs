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

        public static void Show<T>(T t) where T: AbstractPerform, InterfacePerform
        {
            if (t == null)
            {
                return;
            }

            Type type = t.GetType();

            PropertyInfo[] properties = type.GetProperties();
            FieldInfo[] fields = type.GetFields();
            foreach (var item in properties)
            {
                Console.WriteLine($" {item.Name} = {item.GetValue(t)} ");
            }

            foreach (var item in fields)
            {
                Console.WriteLine($" {item.Name} = {item.GetValue(t)} ");
            }

            t.Start();
            t.OpeningRemark();
            t.DogCall();
            t.PeopleCry();
            t.WindCall();
            t.ClosingRemark();
            t.Charge();

        }

    }
}
