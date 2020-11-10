using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInlämningPontus
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcylator MyCalc = new Calcylator();
            
            MyCalc.UserInput();
            
            MyCalc.Calculation();

            MyCalc.PrintResult();

        }
    }
}
