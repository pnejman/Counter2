using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter2
{
    class ConsoleUI
    {
        enum inputType { numeric, words}
        bool useNumbers;


        private void ReadData(bool useNumbers)
        {

        }

        private void ConsoleUIMain()
        {
            Console.Write("Select input type:\r\n" +
                          "1. Numeric\r\n" +
                          "2. Words\r\n" +
                          ">");
            ConsoleKeyInfo choice = Console.ReadKey();

            switch (choice.KeyChar)
            {
                case '1':
                    this.useNumbers = false;
                    break;

                case '2':
                    this.useNumbers = true;
                    break;

                default:
                    Console.WriteLine("\r\nError. There is no such option. Program will exit now.");
                    Console.ReadKey(true);
                    return;
            }

        }

        public ConsoleUI()
        {
            ConsoleUIMain();
        }
    }
}
