using P03.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace P03.Interface
{
    public abstract class AbstractPerform
    {
        public string Person { get; set; }
        public string Table { get; set; }
        public string Chair { get; set; }
        public string Fan { get; set; }
        public string Ruler { get; set; }

        public void Start()
        {
            Console.WriteLine("abstract perform start method");
        }

        public abstract void DogCall();
        public abstract void PeopleCry();
        public abstract void WindCall();

        public virtual void OpeningRemark()
        {
            Console.WriteLine("abstract performance begin.....");
        }

        public virtual void ClosingRemark()
        {
            Console.WriteLine("abstract performance finished, see you...");
        }

        public void Show()
        {
            Console.WriteLine(" the exclusive skill...");
            this.ShowSkills();
            Console.WriteLine(" the exclusive skill finished...");
        }

        protected abstract void ShowSkills();

        #region event

        protected int HighTemperature = 400;//protected: only derived class can modify
        public EventHandler FireHandler;

        public void SetTemperature(int temperature)
        {
            if (temperature >= this.HighTemperature)
            {
                FireHandler?.Invoke(this,new FireEventArgs()
                    {
                        CurrentTemperature = temperature,
                        HighestTemperature = this.HighTemperature
                    }
                );
            }
            else
            {
                Console.WriteLine("normal temperature");
            }
        }

        protected void EventInvoke(FireEventArgs fireEventArgs)
        {
            FireHandler?.Invoke(this, fireEventArgs);
        }

        protected virtual bool IsOn(int temperature)
        {
            return temperature >= this.HighTemperature;
        }

        #endregion

    }
}
