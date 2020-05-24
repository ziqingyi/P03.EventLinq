using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P03.Interface;

namespace P03.Service
{
    public class SouthPerform : AbstractPerform, InterfacePerform
    {
        public string SouthSkillProperty { get; set; }
        public string SouthSkillField;

        public SouthPerform()
        {
            this.HighTemperature = 800;
        }

        //override abstract method from abstract class

        public override void DogCall()
        {
            Console.WriteLine("South perform dog call");
        }
        public override void PeopleCry()
        {
            Console.WriteLine("South perform people cry");
        }
        public override void WindCall()
        {
            Console.WriteLine("South perform wind call");
        }
        protected override void ShowUniqueSkills()
        {
            this.SouthUniqueWay();
        }
        private void SouthUniqueWay()
        {
            Console.WriteLine("Center exclusive skills .........");
        }
        // override virtual method from abstract class
        public override void OpeningRemark()
        {
            Console.WriteLine("South perform will begin now");
        }
        //implement method from interface
        public void Charge()
        {
            Console.WriteLine("center charge ");
        }


        #region  event





        #endregion


    }
}
