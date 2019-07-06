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
        public int CurrentValue //do you need it? And why not use an auto property?
        {
            get
            { return this.currentValue; }
        }

        readonly Timer timer = new Timer();

        public Counter(int delay, int endValue)
        {
            this.endValue = endValue;
            this.currentValue = 0;
            this.timer.Interval = delay;
            this.timer.Elapsed += OnTimedEvent;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            this.currentValue++;
            ShowMsg($"Counter ({this.timer.Interval}ms): {this.currentValue}/{this.endValue}");
            if (this.currentValue == this.endValue)
            {
                this.timer.Enabled = false;
                End();
            }
        }

        public void Start()
        {
            this.timer.Enabled = true;
        }

        public virtual void ShowMsg(string msg) //overridible... why public?
        {
            Console.WriteLine(msg);
        }

        public virtual void End() //overridible... why public? 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Counter ({this.timer.Interval}ms): Finished!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
