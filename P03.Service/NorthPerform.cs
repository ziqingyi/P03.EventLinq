using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using P03.Interface;
using P03.Utility;

namespace P03.Service
{
    public class NorthPerform: AbstractPerform, InterfacePerform
    {
        public string NorthSkillProperty { get; set; }
        public string NorthSkillField;
        //public new int HighTemperature = 1000;

        //must set own temperature
        public NorthPerform()
        {
            // set own temperature. 
            this.HighTemperature = 1000;
            
        }

        //override abstract method from abstract class
        public override void DogCall()
        {
            Console.WriteLine("North perform dog call");
        }

        public override void PeopleCry()
        {
            Console.WriteLine("North perform people cry");
        }
        public override void WindCall()
        {
            Console.WriteLine("North perform wind call");
        }
                  
        protected override void ShowUniqueSkills()
        {
            NorthUniqueWay();
        }
        private void NorthUniqueWay()
        {
            Console.WriteLine("North exclusive skills .........");
        }

        // override virtual method from abstract class
        public override void ClosingRemark()
        {
            Console.WriteLine("North performance finished, see you...");
        }

        //implement method from interface
        public void Charge()
        {
            Console.WriteLine("North charge ");
        }

        #region  event
         

        //override base class's way of comparing the temperature. 
        //no need to set temperature in constructor if using : return temperature > 1000. 
        protected override bool IsOn(int temperature)
        {
            Console.WriteLine("North test temperature");
            return temperature > this.HighTemperature;
        }
        //using base class's event start method
        public override void EventStart(object send, EventArgs args)
        {
            Console.WriteLine("north event start:");
            base.EventStart(send,args);
        }

   


        #endregion
    }
}
