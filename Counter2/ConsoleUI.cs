using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter2
{
    class ConsoleUI
    {
        public void ConsoleUIMain()
        {
            if (SetupCounters(EnterNumberOfCounters()) == true) StartCounters(this.counterList);
        }

        List<Counter> counterList = new List<Counter>();

        private int ReadDataAsNumbers(string countersNumberGivenByUser)
        {

            int result;
            try
            {
                result = Int32.Parse(countersNumberGivenByUser);
                if (result == 0)
                {
                    Console.Write("\r\nError. Number of counters can't be 0. Try again or type \"exit\" to exit program.\r\n>");
                }
                return result;
            }
            catch
            {
                Console.Write("\r\nError. Invalid integer number. Try again or type \"exit\" to exit program.\r\n>");
                return 0;
            }

        }

        private int ReadDataAsWords(string countersNumberGivenByUser)
        {
            int result;
            string wordSearcher = ""; //temporary field to read input char by char
            string extractedNumber = ""; //temporary field to save extracted numbers as digits, but still as string

            for (int currentChar = 0; currentChar < countersNumberGivenByUser.Length; currentChar++)
            {
                wordSearcher += countersNumberGivenByUser[currentChar]; //extract number from user input to temporary variable, letter by letter

                if (currentChar != countersNumberGivenByUser.Length - 1) //not the last word
                {
                    switch (wordSearcher)
                    {
                        case "twenty":
                            extractedNumber += "2";
                            wordSearcher = "";
                            break;
                        case "thirty":
                            extractedNumber += "3";
                            wordSearcher = "";
                            break;
                        case "fourty":
                            extractedNumber += "4";
                            wordSearcher = "";
                            break;
                        case "fifty":
                            extractedNumber += "5";
                            wordSearcher = "";
                            break;
                        case "sixty":
                            extractedNumber += "6";
                            wordSearcher = "";
                            break;
                        case "seventy":
                            extractedNumber += "7";
                            wordSearcher = "";
                            break;
                        case "eighty":
                            extractedNumber += "8";
                            wordSearcher = "";
                            break;
                        case "ninety":
                            extractedNumber += "9";
                            wordSearcher = "";
                            break;
                        case " ":
                        case "-":
                        case "one":
                            wordSearcher = "";
                            break;
                    }
                }

                if (currentChar == countersNumberGivenByUser.Length - 1) //last word
                {
                    switch (wordSearcher)
                    {
                        case "one":
                            extractedNumber += "1";
                            wordSearcher = "";
                            break;
                        case "two":
                            extractedNumber += "2";
                            wordSearcher = "";
                            break;
                        case "three":
                            extractedNumber += "3";
                            wordSearcher = "";
                            break;
                        case "four":
                            extractedNumber += "4";
                            wordSearcher = "";
                            break;
                        case "five":
                            extractedNumber += "5";
                            wordSearcher = "";
                            break;
                        case "six":
                            extractedNumber += "6";
                            wordSearcher = "";
                            break;
                        case "seven":
                            extractedNumber += "7";
                            wordSearcher = "";
                            break;
                        case "eight":
                            extractedNumber += "8";
                            wordSearcher = "";
                            break;
                        case "nine":
                            extractedNumber += "9";
                            wordSearcher = "";
                            break;
                        case "ten":
                            extractedNumber += "10";
                            wordSearcher = "";
                            break;
                        case "eleven":
                            extractedNumber += "11";
                            wordSearcher = "";
                            break;
                        case "twelve":
                            extractedNumber += "12";
                            wordSearcher = "";
                            break;
                        case "thirteen":
                            extractedNumber += "13";
                            wordSearcher = "";
                            break;
                        case "fourteen":
                            extractedNumber += "14";
                            wordSearcher = "";
                            break;
                        case "fifteen":
                            extractedNumber += "15";
                            wordSearcher = "";
                            break;
                        case "sixteen":
                            extractedNumber += "16";
                            wordSearcher = "";
                            break;
                        case "seventeen":
                            extractedNumber += "17";
                            wordSearcher = "";
                            break;
                        case "eighteen":
                            extractedNumber += "18";
                            wordSearcher = "";
                            break;
                        case "nineteen":
                            extractedNumber += "19";
                            wordSearcher = "";
                            break;
                        case "twenty":
                            extractedNumber += "20";
                            wordSearcher = "";
                            break;
                        case "thirty":
                            extractedNumber += "30";
                            wordSearcher = "";
                            break;
                        case "fourty":
                            extractedNumber += "40";
                            wordSearcher = "";
                            break;
                        case "fifty":
                            extractedNumber += "50";
                            wordSearcher = "";
                            break;
                        case "sixty":
                            extractedNumber += "60";
                            wordSearcher = "";
                            break;
                        case "seventy":
                            extractedNumber += "70";
                            wordSearcher = "";
                            break;
                        case "eighty":
                            extractedNumber += "80";
                            wordSearcher = "";
                            break;
                        case "ninety":
                            extractedNumber += "90";
                            wordSearcher = "";
                            break;
                        case "hundred":
                            extractedNumber += "100";
                            wordSearcher = "";
                            break;
                        case "exit":
                            return 0;
                        default:
                            Console.Write($"\r\nError. Can't parse \"{countersNumberGivenByUser}\" into integer number. Make sure to write number in proper english. Number can't exceed one hundred neither. Please try again, or type \"exit\" to exit program.\r\n>");
                            return 0;
                    }
                }
            }

            try
            {
                result = Int32.Parse(extractedNumber);
            }
            catch
            {
                return 0;
            }

            if (result == 0)
            {
                Console.Write("\r\nError. Number of counters can't be 0. Try again or type \"exit\" to exit program.\r\n>");
            }

            if (result > 100)
            {
                Console.Write("\r\nError. Number of counters can't be higher than one hundred. Try again or type \"exit\" to exit program.\r\n>");
                return 0;
            }

            return result;
        }

        private int EnterNumberOfCounters()
        {
            bool useNumbers = false;

            Console.Write("Press a key to select input type:\r\n" +
                          "1. Numeric\r\n" +
                          "2. Words\r\n" +
                          ">");
            ConsoleKeyInfo choice;

            do
            {
                choice = Console.ReadKey();

                switch (choice.KeyChar)
                {
                    case '1':
                        useNumbers = true;
                        break;

                    case '2':
                        useNumbers = false;
                        break;

                    case (char)27: //"esc" key
                        return 0;

                    default:
                        Console.Write("\r\nError. There is no such option. Try again or press \"Esc\" to exit program.\r\n>");
                        break;
                }

            } while ((choice.KeyChar != '1') && (choice.KeyChar != '2'));

            Console.Write("\r\n\r\nInput number of counters:\r\n>");
            int countersNumberParsed = 0;
            do
            {
                string countersNumberGivenByUser = Console.ReadLine();

                if (countersNumberGivenByUser.ToLower() == "exit")
                {
                    return 0;
                }

                if (useNumbers == true)
                {
                    countersNumberParsed = ReadDataAsNumbers(countersNumberGivenByUser);
                }
                else if (useNumbers == false)
                {
                    countersNumberParsed = ReadDataAsWords(countersNumberGivenByUser.ToLower());
                }

            } while (countersNumberParsed == 0);

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
            } while (delayValueEnteredInt == 0);

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
            } while (endValueEnteredInt == 0);

            return endValueEnteredInt;
        }

        private bool SetupCounters(int numberOfCounters)
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
                if (delayValueEnteredInt == -1) return false; //-1 is set if user type "exit"

                int endValueEnteredInt = EnterCounterEndvalue();
                if (endValueEnteredInt == -1) return false; //-1 is set if user type "exit"

                this.counterList.Add(new Counter(delayValueEnteredInt, endValueEnteredInt));
            }
            return true;
        }

        private void StartCounters(List<Counter> counterList)
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
            } while (typedCaptcha != captchaFinal);

            for (int currentCounter = 0; currentCounter < counterList.Count; currentCounter++)
            {
                counterList[currentCounter].Start();
            }
            Console.ReadKey(true);
        }
    }
}
