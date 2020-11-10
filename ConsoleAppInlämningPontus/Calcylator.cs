using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInlämningPontus
{

    class Calcylator
    {
        // Här deklareras Instansvariabler För klassen Calcylator
        // som jag använder mig av i Klassen och klassens metoder.
        public string FirstOperator;
        public string SecondOperator;
        
        public double FirstTerm;
        public double SecondTerm;
        public double ThirdTerm;

        public double TempResult;
        public double SecondTempResult;

        public void UserInput()
        {
            // Ber användare skriva in operatorer och termer och läser in dessa.
            Console.Write("> Enter first operator: ");
            FirstOperator = Console.ReadLine();

            Console.Write("> Enter second operator: ");
            SecondOperator = Console.ReadLine();

            Console.Write("> Enter First term: ");
            FirstTerm = Convert.ToDouble(Console.ReadLine());

            Console.Write("> Enter Second term: ");
            SecondTerm = Convert.ToDouble(Console.ReadLine());

            Console.Write("> Enter Third term: ");
            ThirdTerm = Convert.ToDouble(Console.ReadLine());    
        }

        public void Calculation() 
        {
            // Kontrollerar användarens första operator samt användarens
            // första och andra term och ger dem resultatet TempResult.
            switch (FirstOperator)
            {
                case "+":
                    TempResult = FirstTerm + SecondTerm;
                    break;
                case "-":
                    TempResult = FirstTerm - SecondTerm;
                    break;
                case "*":
                    TempResult = FirstTerm * SecondTerm;
                    break;
                case "/":
                    TempResult = FirstTerm / SecondTerm;
                    break;
            }
            
            // I denna switch-satsen kontrollerars användarens andra operator och sista term
            // samt beräknar hela användarens input.
            switch (SecondOperator)
            {
                case "+":
                    SecondTempResult = TempResult + ThirdTerm;
                    break;
                case "-":
                    SecondTempResult = TempResult - ThirdTerm;
                    break;
                case "*":
                    SecondTempResult = TempResult * ThirdTerm;
                    break;
                case "/":
                    SecondTempResult = TempResult / ThirdTerm;
                    break;
            }
        }
        public void PrintResult() 
        {
            // Metoden skriver ut inmatning och resultat.
            Console.WriteLine($"> {FirstTerm} {FirstOperator} {SecondTerm} {SecondOperator} {ThirdTerm} = {SecondTempResult}");
        }

    }

  

}

