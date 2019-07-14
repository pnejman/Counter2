using System;
using System.Collections.Generic;

namespace MyConverter
{
    public class Operation //not a very good name, sorry
    {
        public delegate void AlertFromConverter(string alertMsg); //not always do you need to create custom delegates to support even handling. There is a build in delegate called EventHandler
        public event AlertFromConverter alertFromConverter; //event to send alerts as strings
        public event EventHandler<OperationEventArgs> myAlert;

        public class OperationEventArgs : EventArgs
        {
            public string Msg { get; set; }
            public string Msg3 { get; set; }
        }
        public int ReadDataAsWords(string countersNumberGivenByUser)
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
                            alertFromConverter($"\r\nError. Can't parse \"{countersNumberGivenByUser}\" into integer number. Make sure to write number in proper english. Number can't exceed one hundred neither. Please try again, or type \"exit\" to exit program.\r\n>");
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
                alertFromConverter("\r\nError. Number of counters can't be 0. Try again or type \"exit\" to exit program.\r\n>");
            }

            if (result > 100)
            {
                alertFromConverter("\r\nError. Number of counters can't be higher than one hundred. Try again or type \"exit\" to exit program.\r\n>");
                return 0;
            }

            return result;
        }

        public int ReadDataAsNumbers(string countersNumberGivenByUser)
        {

            int result;
            try
            {
                result = Int32.Parse(countersNumberGivenByUser);
                if (result == 0)
                {
                    alertFromConverter("\r\nError. Number of counters can't be 0. Try again or type \"exit\" to exit program.\r\n>");
                }
                return result;
            }
            catch
            {
                alertFromConverter("\r\nError. Invalid integer number. Try again or type \"exit\" to exit program.\r\n>");
                return 0;
            }

        }

        private static readonly Dictionary<char, int> RomanMap = new Dictionary<char, int>()
        {
        {'i', 1},
        {'v', 5},
        {'x', 10},
        {'l', 50},
        {'c', 100},
        {'d', 500},
        {'m', 1000}
        };

        public int RomanToInteger(string countersNumberGivenByUser)
        {
            int number = 0;
            bool coversionSuccessed = false;

            do
            {
                try
                {
                    for (int i = 0; i < countersNumberGivenByUser.Length; i++)
                    {
                        if (i + 1 < countersNumberGivenByUser.Length && RomanMap[countersNumberGivenByUser[i]] < RomanMap[countersNumberGivenByUser[i + 1]])
                        {
                            number -= RomanMap[countersNumberGivenByUser[i]];
                        }
                        else
                        {
                            number += RomanMap[countersNumberGivenByUser[i]];
                        }
                    }
                    coversionSuccessed = true;
                }
                catch(Exception ex)
                {
                    myAlert?.Invoke(this, new OperationEventArgs()
                    {
                        Msg = "Err",
                        Msg3 = ex.ToString()
                    }) ;
                    alertFromConverter($"\r\nError. Can't parse \"{countersNumberGivenByUser}\" into integer number. Make sure to write number in proper roman number. Please try again, or type \"exit\" to exit program.\r\n>");
                    return 0;
                }

                if (number > 100)
                {
                    alertFromConverter("\r\nError. Number of counters can't be higher than one hundred. Try again or type \"exit\" to exit program.\r\n>");
                    return 0;
                }

            } while (coversionSuccessed == false);
            
            return number;
        }
    }
}