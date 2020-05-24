using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P03.Interface;
using P03.Utility;

namespace P03.Service
{
    public class EastPerform: AbstractPerform,InterfacePerform
    {
        public string EastSkillProperty { get; set; }
        public string EastSkillField;

        public EastPerform()
        {
            this.FireHandler += EventStart;

        }
        //override abstract method from abstract class
        public override void DogCall()
        {
            Console.WriteLine("East perform dog call");
        }
        public override void PeopleCry()
        {
            Console.WriteLine("East perform people cry");
        }

        public override void WindCall()
        {
            Console.WriteLine("East perform wind call");
        }

        protected override void ShowSkills()
        {
            EastUniqueWay();
        }
        public void EastUniqueWay()
        {
            Console.WriteLine("East exclusive skills .........");
        }
        //no override of virtual method from abstract class

        //implement method from interface
        public void Charge()
        {
            Console.WriteLine("East charge ");
        }

        #region  event



        public override void EventStart(object send, EventArgs args)
        {
            Console.WriteLine("East event start:");
            base.EventStart(send,args);
        }



        #endregion

    }
}
