using P03.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P03.Interface;

namespace P03.EventLinq
{
    public static class ShowPerformAttr
    {
        public static void Show()
        {
            NorthPerform n1 = new NorthPerform()
            {
                Chair = "North Chair 1",
                Fan = "North Fan 1",
                NorthSkillField = "North Skill Field",
                NorthSkillProperty = "North skill Property",
                Person = "North Person 1",
                Ruler = "North Ruler 1",
                Table = "North Table 1",
            };
            {
                PropertyManager.ShowPropertyFields(n1);
                Console.WriteLine("-----------show North Performance---------------------");
                n1.Start();
                n1.OpeningRemark();
                n1.DogCall();
                n1.PeopleCry();
                n1.WindCall();
                n1.Show();// this will call Show method in abstract class. 
                n1.ClosingRemark();
                n1.Charge();
            }
            {
                Console.WriteLine("------------show North Event--------------------------------------");
                // connection between subscriber and publisher
                Customer CusWantToSee = new Customer();
                n1.FireHandler += Customer.HusbandAction;
                n1.FireHandler += Customer.WifeAction;
                n1.FireHandler += Customer.MoreChildAction;
                n1.FireHandler += Customer.MorePersonAction;
                n1.FireHandler += Customer.MoreDogAction;

                n1.SetTemperature(1200);


            }





        }

     


    }
}
