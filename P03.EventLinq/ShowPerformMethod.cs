using P03.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using P03.Interface;
using P03.Utility;

namespace P03.EventLinq
{
    public static class ShowPerformMethod
    {
        public static void Show()
        {
            #region  initialise different performer. 
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
            PropertyManager.ShowPropertyFields(n1);
            EastPerform e1 = new EastPerform()
            {
                Chair = "East Chair 1",
                Fan = "East Fan 1",
                EastSkillField = "East Skill Field",
                EastSkillProperty = "East skill Property",
                Person = "East Person 1",
                Ruler = "East Ruler 1",
                Table = "East Table 1",
            };
            PropertyManager.ShowPropertyFields(e1);
            SouthPerform s1 = new SouthPerform()
            {
                Chair = "South Chair 1",
                Fan = "South Fan 1",
                SouthSkillField = "South Skill Field",
                SouthSkillProperty = "South skill Property",
                Person = "South Person 1",
                Ruler = "South Ruler 1",
                Table = "South Table 1",
            };
            PropertyManager.ShowPropertyFields(s1);
            WestPerform w1 = new WestPerform()
            {
                Chair = "West Chair 1",
                Fan = "West Fan 1",
                WestSkillField = "West Skill Field",
                WestSkillProperty = "West skill Property",
                Person = "West Person 1",
                Ruler = "West Ruler 1",
                Table = "West Table 1",
            };
            PropertyManager.ShowPropertyFields(w1);
            CenterPerform c1 = new CenterPerform()
            {
                Chair = "Center Chair 1",
                Fan = "Center Fan 1",
                CenterSkillField = "Center Skill Field",
                CenterSkillProperty = "Center skill Property",
                Person = "Center Person 1",
                Ruler = "Center Ruler 1",
                Table = "Center Table 1",
            };
            PropertyManager.ShowPropertyFields(c1);
            #endregion


            {
                Console.WriteLine("-----------show North Performance---------------------");
                n1.Start();
                n1.OpeningRemark();
                n1.DogCall();
                n1.PeopleCry();
                n1.WindCall();
                n1.Show();// this will call Show method in abstract class. 
                n1.ClosingRemark();
                n1.Charge();
                Console.WriteLine("-----------North Performance Finish------------------");
            }
            {
                Console.WriteLine("------------Show North Event---------------------");
                // connection between subscriber and publisher
                n1.FireHandler += Customer.HusbandAction;
                n1.FireHandler += Customer.WifeAction;
                n1.FireHandler += Customer.MoreChildAction;
                n1.FireHandler += Customer.MorePersonAction;
                n1.FireHandler += Customer.MoreDogAction;

                n1.SetTemperature(1200);
                Console.WriteLine("------------North Event Finish---------------------");
            }
            {
                Console.WriteLine("------------Show East Event---------------------");
                // connection between subscriber and publisher
                e1.FireHandler += Customer.HusbandAction;
                e1.FireHandler += Customer.WifeAction;
                e1.FireHandler += Customer.MoreChildAction;
                e1.FireHandler += Customer.MorePersonAction;
                e1.FireHandler += Customer.MoreDogAction;

                e1.SetTemperature(500);
                Console.WriteLine("------------East Event Finish---------------------");
            }
            {
                Console.WriteLine("------------Show South Event---------------------");
                // connection between subscriber and publisher
                s1.FireHandler += (sender, args) =>
                {
                    Console.WriteLine("register event from lambda");
                    Console.WriteLine($"invoke by temperature {((FireEventArgs)args).CurrentTemperature}");
                };
                s1.FireHandler += (sender, args) => {
                    Console.WriteLine("Husband, Wife, Child, Dog , more people actions");
                };

                s1.SetTemperature(900);
                Console.WriteLine("------------South Event Finish---------------------");
            }
            {
                Console.WriteLine("------------Show West Event---------------------");
                // connection between subscriber and publisher
                w1.FireHandler += (sender, args) =>
                {
                    Console.WriteLine("register event from lambda");
                    Console.WriteLine($"invoke by temperature {((FireEventArgs)args).CurrentTemperature}");
                };
                w1.FireHandler += (sender, args) => {
                    Console.WriteLine("Husband, Wife, Child, Dog , more people actions");
                };

                w1.SetTemperature(550);
                Console.WriteLine("------------West Event Finish---------------------");
            }
            {
                Console.WriteLine("------------Center West Event---------------------");
                // connection between subscriber and publisher
                c1.FireHandler += Customer.HusbandAction;
                c1.FireHandler += Customer.WifeAction;
                c1.FireHandler += (sender, args) =>
                {
                    Console.WriteLine("register event from lambda for center ");
                    Console.WriteLine($"invoke by temperature {((FireEventArgs)args).CurrentTemperature}");
                };

                c1.BeginShowEvent += () => { Console.WriteLine("welcome to our center show!!!"); };
                c1.ShowingEvent += () => { Console.WriteLine("this is excellent center show!!!"); };
                c1.EndShowEvent += () => { Console.WriteLine("do you want to join our review??"); };


                c1.Show();


                Console.WriteLine("------------Center Event Finish---------------------");
            }

        }

     


    }
}
