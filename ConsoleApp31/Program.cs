using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        private const int CHAR_STATE_TOTAL = 3;
        private const int CHAR_STATE1 = 0;
        private const int CHAR_STATE2 = 1;
        private const int CHAR_STATE3 = 2;
        private const int ROW = 5;
        private const int COL_START = 1;
        private const int COL_END = 50;
        private const int WAIT_TIME = 1000;

        static void Main(string[] args)
        {
            int x = 1;
            while(x< COL_END)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                switch(x % CHAR_STATE_TOTAL)
                {
                    case CHAR_STATE1:
                        Console.WriteLine("__@");
                        break;
                    case CHAR_STATE2:
                        Console.WriteLine("_^@");
                        break;
                    case CHAR_STATE3:
                        Console.WriteLine("^_@");
                        break;
                }
                Thread.Sleep(WAIT_TIME);
                x++;
            }
        }
    }
}
