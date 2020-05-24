using P03.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.Service
{
    public class CenterPerform: AbstractPerform, InterfacePerform
    {

        public string CenterSkillProperty { get; set; }
        public string CenterSkillField;

        //override abstract method from abstract class
        
        public override void DogCall()
        {
            Console.WriteLine("center perform dog call");
        }

        public override void PeopleCry()
        {
            Console.WriteLine("center perform people cry");
        }

        public override void WindCall()
        {
            Console.WriteLine("center perform wind call");
        }
        protected override void ShowUniqueSkills()
        {
            CenterUniqueWay();
        }

        private void CenterUniqueWay()
        {
            Console.WriteLine("Center exclusive skills .........");
        }
        //no override of virtual method from abstract class

        //implement method from interface
        public void Charge()
        {
            Console.WriteLine("center charge ");
        }


        #region  event

        public event Action BeginShowEvent;
        public event Action ShowingEvent;
        public event Action EndShowEvent;

        public void Show()
        {

          
        }



        #endregion


    }
}
