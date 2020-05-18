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

        protected override void ShowSkills()
        {
            CenterUniqueWay();
        }

        public void CenterUniqueWay()
        {
            Console.WriteLine("Center exclusive skills .........");
        }

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

        public void Charge()
        {
            Console.WriteLine("center charge ");
        }

        public event Action BeginShowEvent;
        public event Action ShowingEvent;
        public event Action EndShowEvent;

        public void Show()
        {
            this.Start();
            this.OpeningRemarks();
            BeginShowEvent?.Invoke();
            this.DogCall();
            this.PeopleCry();
            this.WindCall();
            this.ShowSkills();
            ShowingEvent?.Invoke();
            this.ClosingRemark();
            this.Charge();
            EndShowEvent?.Invoke();
        }
    }
}
