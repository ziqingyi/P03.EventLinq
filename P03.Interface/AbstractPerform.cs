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

        public AbstractPerform()
        {
            // set own event
            this.FireHandler += EventStart;
        }
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
        //used for showing protected unique skills
        public void Show()
        {
            Console.WriteLine(" the exclusive skill...");
            this.ShowUniqueSkills();
            Console.WriteLine(" the exclusive skill finished...");
        }
        //only show derived classes' unique skills
        protected abstract void ShowUniqueSkills();

        #region event

        protected int HighTemperature = 400;//protected: only derived class can modify
        public event EventHandler FireHandler;

        public virtual void EventStart(object send, EventArgs args)
        {
            var argsTemp = (FireEventArgs) args;
            Console.WriteLine($"Send by {send.ToString()}, "+
                              $"my temp threshold: {argsTemp.HighestTemperature}, "+
                              $"now is : {argsTemp.CurrentTemperature} ");
        }


        #region comparing temperature and invoke event, method 1
        public void SetTemperature(int temperature)
        {
            if (temperature >= this.HighTemperature)
            {
                FireHandler?.Invoke(this, new FireEventArgs()
                    {
                        CurrentTemperature = temperature,
                        HighestTemperature = this.HighTemperature
                    }
                );// can only invoke in current class
            }
            else
            {
                Console.WriteLine("normal temperature");
            }
        }

        #endregion

        #region comparing temperature and invoke event, method 2
        protected virtual bool IsOn(int temperature)
        {
            return temperature >= this.HighTemperature;
        }
        protected void EventInvoke(FireEventArgs fireEventArgs)
        {
            // can only invoke in current class,(FireHandler in abstractPerform)
            // so build this method to be used by derived class
            FireHandler?.Invoke(this, fireEventArgs);
        }

        #endregion


        #endregion

    }
}
