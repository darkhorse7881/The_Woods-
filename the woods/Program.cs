using System;
using the_woods;
using static System.Console;
using System.Threading.Tasks;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Intrinsics.X86;

namespace TheWoods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(157,36);
            Console.Clear();
            string text = @" ,--.--------.  ,--.-,,-,--,    ,----.                 ,-.-.    _,.---._       _,.---._                  ,-,--.   .=-.-.       
/==/,  -   , -\/==/  /|=|  | ,-.--` , \       ,-..-.-./  \==\ ,-.' , -  `.   ,-.' , -  `.   _,..---._  ,-.'-  _\ /==/_ /       
\==\.-.  - ,-./|==|_ ||=|, ||==|-  _.-`       |, \=/\=|- |==|/==/_,  ,  - \ /==/_,  ,  - \/==/,   -  \/==/_ ,_.'|==|, |        
 `--`\==\- \   |==| ,|/=| _||==|   `.-.       |- |/ |/ , /==/==|   .=.     |==|   .=.     |==|   _   _\==\  \   |==|  |        
      \==\_ \  |==|- `-' _ /==/_ ,    /        \, ,     _|==|==|_ : ;=:  - |==|_ : ;=:  - |==|  .=.   |\==\ -\  /==/. /        
      |==|- |  |==|  _     |==|    .-'         | -  -  , |==|==| , '='     |==| , '='     |==|,|   | -|_\==\ ,\ `--`-`         
      |==|, |  |==|   .-. ,\==|_  ,`-._         \  ,  - /==/ \==\ -    ,_ / \==\ -    ,_ /|==|  '='   /==/\/ _ | .=.           
      /==/ -/  /==/, //=/  /==/ ,     /         |-  /\ /==/   '.='. -   .'   '.='. -   .' |==|-,   _`/\==\ - , /:=; :          
      `--`--`  `--`-' `-`--`--`-----``          `--`  `--`      `--`--''       `--`--''   `-.`.____.'  `--`---'  `=`           ";
            
                
                Console.WriteLine(text);
                Console.WriteLine("");
                Console.WriteLine();
                Print("                                                         (I)nfo on things you can do(Game Manual(W.I.P))", 20);
                Print("");
                Print("                                                         (P)lay", 15);
                Print("");
                Print("                                                         (Q)uit", 15);
            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "p" || input == "play")
                {
                    game.run();
                }
                else if (input == "")
                {
                    Print("Please Enter A Valid Option");
                    return 
                }
                else if (input == "q" || input == "quit")
                {
                    Quit();
                }
                break;
            }
                
        }
        
        public static void Print(string text, int speed = 40)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);

            }
            Console.WriteLine();
        }
        public static void Quit()
        {
            Environment.Exit(0);
        }
    }
}


