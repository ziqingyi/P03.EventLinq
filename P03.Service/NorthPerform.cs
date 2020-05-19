﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P03.Interface;

namespace P03.Service
{
    public class NorthPerform: AbstractPerform, InterfacePerform
    {
        public string NorthSkillProperty { get; set; }
        public string NorthSkillField;

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
        protected override void ShowSkills()
        {
            NorthUniqueWay();
        }
        public void NorthUniqueWay()
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







        #endregion
    }
}