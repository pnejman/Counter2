using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MyLittleCounter //again, not the best name (also, the file name should not contain the namespace name)
{
    public class Counter
    {
        readonly int endValue;
        int currentValue;
        readonly Timer timer = new Timer();

        public delegate void CounterDelegate(bool isFinishedMsg, string msg); //new type of delegate carrying some arguments
        //prefer to use existing EventHander<T> class, and wrap the event arguments in an extended version of EventArgs class (see the timer.Elapsed event for example)
        public event CounterDelegate counterEvent; //new event of delegate type
        //look at the events that other objects expose (e.g timer, button etc) by reading the name of the event you know what happened (Elapsed, Clicked etc). CounterEvent does not tell what happened.

        public Counter(int delay, int endValue)
        {
            this.endValue = endValue;
            this.currentValue = 0;
            this.timer.Interval = delay;
            this.timer.Elapsed += OnTimedEvent; //subscribe to event 'elapsed' of this timer with 'OnTimedEvent' method
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            this.currentValue++;

            if (counterEvent != null) //event cant have no subscribers
            {
                counterEvent(false, $"Counter ({this.timer.Interval}ms): {this.currentValue}/{this.endValue}"); //raise event with arguments
            }

            if (this.currentValue == this.endValue) //perhaps you need two events? 
            {
                this.timer.Enabled = false;
                if (counterEvent != null) //event cant have no subscribers
                {
                    counterEvent(true, $"Counter ({this.timer.Interval}ms): Finished!"); //raise event with other arguments
                }
            }
        }

        public void Start()
        {
            this.timer.Enabled = true;
        }
    }
}
