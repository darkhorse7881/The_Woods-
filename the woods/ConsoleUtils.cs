using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace the_woods
{
    static class ConsoleUtils
    {
        public static void WaitForKeyPress()
        {
            WriteLine();
            ReadKey(true);
            Environment.Exit(0);
        }
    }
}
