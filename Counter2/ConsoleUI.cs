using System;
using System.Collections.Generic;

namespace Counter2
{
    class ConsoleUI
    {
        public void ConsoleUIStart()
        {
            if (SetupCounters(EnterNumberOfCounters()) == true)
            {
                StartCounters(this.counterList);
            }
        }

        List<MyLittleCounter.Counter> counterList = new List<MyLittleCounter.Counter>();

        private int EnterNumberOfCounters() //this method does 2 things, doesnt it? (select type & enter number)
        {
            MyConverter.Operation converter = new MyConverter.Operation(); //create new Converter to convert user input (numeric or word) to integer
            converter.alertFromConverter += OnAlertFromConverter; //subscribe to converter's alert msgs

            // bool useNumbers = false;
            int methodChosen = -1;

            Console.Write("Press a key to select input type:\r\n" +
                          "0. Numeric - Arabic\r\n" +
                          "1. Numeric - Roman\r\n" +
                          "2. Words\r\n" +
                          ">");
            ConsoleKeyInfo choice;

            do
            {
                choice = Console.ReadKey();

                switch (choice.KeyChar)
                {
                    case '0':
                        methodChosen = 0;
                        break;
                    case '1':
                        methodChosen = 1;
                        break;

                    case '2':
                        methodChosen = 2;
                        break;

                    case (char)27: //"esc" key
                        return 0; //so here you exit the loop by 'ESC' key... but below you need to type 'exit'?

                    default:
                        Console.Write("\r\nError. There is no such option. Try again or press \"Esc\" to exit program.\r\n>");
                        break;
                }

            } while ((choice.KeyChar != '0') && (choice.KeyChar != '1') && (choice.KeyChar != '2'));

            Console.Write("\r\n\r\nInput number of counters:\r\n>");
            int countersNumberParsed = 0;
            do
            {
                string countersNumberGivenByUser = Console.ReadLine();

                if (countersNumberGivenByUser.ToLower() == "exit") //see above for the 'escape loop' logic
                {
                    return 0;
                }
                //how about change it a bit to a 'if - else' logic?
                if (methodChosen == 1)
                {
                    countersNumberParsed = converter.ReadDataAsNumbers(countersNumberGivenByUser);
                }
                else if (methodChosen == 2)
                {
                    countersNumberParsed = converter.ReadDataAsWords(countersNumberGivenByUser.ToLower());
                }
                else if (methodChosen == 0)
                {
                    countersNumberParsed = converter.RomanToInteger(countersNumberGivenByUser.ToLower());
                }

            } while (countersNumberParsed == 0);
            //it's cool that you allow retry rather than kill the app if user makes a mistake:)
            return countersNumberParsed;
        }

        private int EnterCounterDelay()
        {
            Console.Write("Enter delay in miliseconds (e.g. 700 or 1200):\r\n" +
               ">");

            int delayValueEnteredInt = 0;
            string delayValueEnteredString;

            do
            {
                delayValueEnteredString = Console.ReadLine();

                if (delayValueEnteredString.ToLower() == "exit")
                {
                    return -1;
                }

                try
                {
                    delayValueEnteredInt = Int32.Parse(delayValueEnteredString);
                }
                catch
                {
                    Console.Write($"Error. \"{delayValueEnteredString}\" is not valid integer number. Try again or type \"exit\" to exit program.\r\n" +
                                  $">");
                }
            } while (delayValueEnteredInt == 0); //you have this do-while quite a few times in your code... perhaps this algorithm can be extracted somewhere and reused? DRY

            return delayValueEnteredInt;
        }

        private int EnterCounterEndvalue()
        {
            Console.Write("Enter counter length (e.g. 5 or 30):\r\n" +
                                          ">");

            int endValueEnteredInt = 0;
            string endValueEnteredString;

            do
            {
                endValueEnteredString = Console.ReadLine();

                if (endValueEnteredString.ToLower() == "exit")
                {
                    return -1;
                }

                try
                {
                    endValueEnteredInt = Int32.Parse(endValueEnteredString);
                }
                catch
                {
                    Console.Write($"Error. \"{endValueEnteredString}\" is not valid integer number. Try again or type \"exit\" to exit program.\r\n" +
                                  $">");
                }
            } while (endValueEnteredInt == 0); //you have this do-while quite a few times in your code... perhaps this algorithm can be extracted somewhere and reused? DRY

            return endValueEnteredInt;
        }

        private bool SetupCounters(int numberOfCounters) //its a good practice to make the boolean methods name in a way that 'answer a question', e.g. "AreCountersSetUp()"
        {
            if (numberOfCounters == 0)
            {
                return false;
            }

            Console.WriteLine($"\r\nNumber of counters: {numberOfCounters}");

            for (int currentCounter = 0; currentCounter < numberOfCounters; currentCounter++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\r\nCounter #{currentCounter}:");
                Console.ForegroundColor = ConsoleColor.Gray;

                int delayValueEnteredInt = EnterCounterDelay();
                if (delayValueEnteredInt == -1)
                {
                    return false;
                }//-1 is set if user type "exit" 

                int endValueEnteredInt = EnterCounterEndvalue();
                if (endValueEnteredInt == -1)
                {
                    return false; //-1 is set if user type "exit"
                }

                this.counterList.Add(new MyLittleCounter.Counter(delayValueEnteredInt, endValueEnteredInt));
                counterList[counterList.Count - 1].counterEvent += OnCounterEvent; //subscribe to the newly created counter with "OnCounterEvent" method
                //do you think you could rewrite the 2 lines above to be clearer (and more potentially efficient, though in this case it won't be noticeable)?
            }
            return true;
        }

        private void StartCounters(List<MyLittleCounter.Counter> counterList)
        {
            Console.WriteLine("\r\nAll counters have been set. Type code below to launch or type \"cancel\" to exit program.");

            string typedCaptcha;
            string captchaFinal;
            do
            {
                Random captchaRandomized = new Random();
                captchaFinal = ((int)captchaRandomized.Next(9000) + 1000).ToString();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"« { captchaFinal} »");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write($">");

                typedCaptcha = Console.ReadLine();
                if (typedCaptcha.ToLower() == "cancel") return;
                else if (typedCaptcha != captchaFinal)
                {
                    Console.WriteLine("Invalid launch code. Try again or type \"cancel\" to exit program.");
                }
            } while (typedCaptcha != captchaFinal);  //lol, what?

            for (int currentCounter = 0; currentCounter < counterList.Count; currentCounter++)
            {
                counterList[currentCounter].Start();
            }
            Console.ReadKey(true);
        }

        private void OnCounterEvent(bool isFinishedMsg, string msg) //event handler
        {
            if (isFinishedMsg == false)
            {
                Console.WriteLine(msg);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(msg);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        private void OnAlertFromConverter(string alertMsg) //event handler
        {
            Console.WriteLine(alertMsg);
        }
    }
}