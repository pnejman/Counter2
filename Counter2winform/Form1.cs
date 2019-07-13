using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter2winform
{
    public partial class Form1 : Form
    {
        List<MyLittleCounter.Counter> counterList = new List<MyLittleCounter.Counter>(); //rather than using fully qualified name, add a 'using MyLittleCounter' directive to file or namespace
        MyConverter.Operation converter = new MyConverter.Operation(); //create new Converter to convert user input (numeric or word) to integer
        int numberOfCounters;

        public Form1()
        {
            InitializeComponent();
            converter.alertFromConverter += OnAlertFromConverter; //subscribe to converter's alert msgs
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            EnterNoOfCounters();
        }

        private void EnterNoOfCounters()
        {
            int countersNumberParsed = 0;

            if (checkboxInputAsWords.Checked == false)
            {
                countersNumberParsed = converter.ReadDataAsNumbers(textboxInputNumber.Text);
            }
            else
            {
                countersNumberParsed = converter.ReadDataAsWords(textboxInputNumber.Text.ToLower());
            }

            if (countersNumberParsed != 0)
            {
                this.numberOfCounters = countersNumberParsed;

                consoleBox.AppendText($"\r\nNumber of counters: {countersNumberParsed}");

                //what if your UI becomes bigger? 
                //this set true/false becomes unmanageable...
                buttonSubmitNumberOf.Enabled = false;
                textboxInputNumber.Enabled = false;
                checkboxInputAsWords.Enabled = false;
                labelEnterNumberLabel.Enabled = false;

                labelSetupCounter.Enabled = true;
                labelCurrentCounter.Enabled = true;
                buttonSubmitSetup.Enabled = true;
                labelDelay.Enabled = true;
                textboxDelay.Enabled = true;
                labelEndValue.Enabled = true;
                textboxEndValue.Enabled = true;
                labelCurrentCounter.Visible = true;
                labelCurrentCounter.Text = $"1 of {countersNumberParsed}";
            }
        }

        private void OnAlertFromConverter(string alertMsg) //event handler
        {
            consoleBox.Text += alertMsg;
        }

        private void ButtonSubmitSetup_Click(object sender, EventArgs e) //setup single counter
        {
            try
            {
                SetupSingleCounter(Int32.Parse(textboxDelay.Text), Int32.Parse(textboxEndValue.Text));
            }
            catch //it is better to catch the exception variable and inform the user at least a bit on what is wrong
            {
                consoleBox.AppendText($"\r\nError. Please input valid integer numbers.");
            }
        }

        private void SetupSingleCounter(int counterDelay, int counterEndValue)
        {
            this.counterList.Add(new MyLittleCounter.Counter(counterDelay, counterEndValue));
            counterList[counterList.Count - 1].counterEvent += OnCounterEvent;

            if (counterList.Count != numberOfCounters)
            {
                labelCurrentCounter.Text = $"{counterList.Count + 1} of {numberOfCounters}";
            }
            else
            {
                labelSetupCounter.Enabled = false;
                labelCurrentCounter.Enabled = false;
                buttonSubmitSetup.Enabled = false;
                labelDelay.Enabled = false;
                textboxDelay.Enabled = false;
                labelEndValue.Enabled = false;
                textboxEndValue.Enabled = false;
                labelCurrentCounter.Visible = false;
                buttonLaunch.Enabled = true;
                consoleBox.AppendText("\r\n");
            }
        }

        private void OnCounterEvent(bool isFinishedMsg, string msg) //event handler
        {
            if (isFinishedMsg == false)
            {
                consoleBox.Invoke(new Action(() => consoleBox.AppendText($"{msg}\r\n"))); //BeginInvoke might be a better idea than Invoke (as BeginInvoke will not block the UI thread until the delegate is complete)
            }
            else
            {
                //change color maybe?
                consoleBox.Invoke(new Action(() => consoleBox.AppendText($"***** {msg}\r\n")));
            }
        }

        private void ButtonLaunch_Click(object sender, EventArgs e)
        {
            buttonLaunch.Enabled = false;
            for (int currentCounter = 0; currentCounter < counterList.Count; currentCounter++) //why not foreach loop?
            {
                counterList[currentCounter].Start();
            }
        }
    }
}
