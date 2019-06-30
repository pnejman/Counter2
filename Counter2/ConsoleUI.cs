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
            SetupCounters(GetNumberOfCounters());
        }

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

        private int GetNumberOfCounters()
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

        private void SetupCounters(int numberOfCounters)
        {
            if (numberOfCounters == 0)
              {
                return;
            }

            Console.WriteLine($"\r\n\r\nNumber of counters: {numberOfCounters}");

            Counter counter = new Counter(700, 30);
            counter.Start();

            Counter counter2 = new Counter(1000, 25);
            counter2.Start();

            Counter counter3 = new Counter(100, 100);
            counter3.Start();

            Console.ReadKey(true);
        }
    }
}
