﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P03.Interface;

namespace P03.Service
{
    public class WestPerform : AbstractPerform,InterfacePerform
    {
        public string WestSkillProperty { get; set; }
        public string WestSkillField;

        //override abstract method from abstract class
        public override void DogCall()
        {
            Console.WriteLine("West perform dog call");
        }
        public override void PeopleCry()
        {
            Console.WriteLine("West perform people cry");
        }
        public override void WindCall()
        {
            Console.WriteLine("West perform wind call");
        }
        protected override void ShowUniqueSkills()
        {
            WestUniqueWay();
        }
        private void WestUniqueWay()
        {
            Console.WriteLine("West exclusive skills .........");
        }
        // override virtual method from abstract class
        public override void OpeningRemark()
        {
            Console.WriteLine("West performance begin ....");
        }
        public override void ClosingRemark()
        {
            Console.WriteLine("performance finished, see you...");
        }
        // implement method from interface
        public void Charge()
        {
            Console.WriteLine("West charge ");
        }


        #region event





        #endregion 




    }
}
