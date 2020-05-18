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

        protected override void ShowSkills()
        {
            this.SouthUniqueWay();
        }
        public void SouthUniqueWay()
        {
            Console.WriteLine("Center exclusive skills .........");
        }
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
        public override void OpeningRemarks()
        {
            Console.WriteLine("South perform will begin now");
        }
        public void Charge()
        {
            Console.WriteLine("center charge ");
        }

        public void FireStart(object send, EventArgs args)
        {

        }

    }
}
