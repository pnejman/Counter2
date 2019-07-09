using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Counter2
{
    class Counter
    {
        readonly int endValue;
        int currentValue;
        readonly Timer timer = new Timer();

        public delegate void CounterDelegate(object sender, bool isFinishedMsg, string msg); //new type of delegate carrying some arguments
        public event CounterDelegate counterEvent; //new event of delegate type

        public Counter(int delay, int endValue)
        {
            this.endValue = endValue;
            this.currentValue = 0;
            this.timer.Interval = delay;
            this.timer.Elapsed += OnTimedEvent; //usbscribe to event 'elapsed' of this timer with 'OnTimedEvent' method
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            this.currentValue++;
            
            if (counterEvent != null) //event cant have no subscribers
            {
                counterEvent(this, false, $"Counter ({this.timer.Interval}ms): {this.currentValue}/{this.endValue}"); //raise event with arguments
            }

            if (this.currentValue == this.endValue)
            {
                this.timer.Enabled = false;
                if (counterEvent != null) //event cant have no subscribers
                {
                    counterEvent(this, true, $"Counter ({this.timer.Interval}ms): Finished!"); //raise event with other arguments
                }
            }
        }

        public void Start()
        {
            this.timer.Enabled = true;
        }
    }
}
