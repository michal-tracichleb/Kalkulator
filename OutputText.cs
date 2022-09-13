using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    internal class OutputText
    {
        public static void GreetingKalkulatorStart()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Witaj w kalkulatorze konsolowym!\nPamiętaj, aby każdą wprowadzoną liczbę i operator (+, -, *, /, =) zkończyć przyciskiem 'ENTER'.\n");
            Console.ResetColor();
        }
        public static void GreetingKalkulatorEnd()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Witaj w kalkulatorze konsolowym!\n");
            Console.ResetColor();
        }

        public static void TaskInputStart(List<double> numbers, List<string> mathOperations)
        {
            Console.Write("Wprowadź działanie: ");

            if (numbers.Count() == mathOperations.Count())
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write(numbers[i] + " ");
                    Console.Write(mathOperations[i] + " ");
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write(numbers[i] + " ");
                    if (i != numbers.Count - 1)
                        Console.Write(mathOperations[i] + " ");
                }
            }
        }

        public static void TaskInputEnd(List<double> numbers, List<string> mathOperations, double result)
        {
            Console.Write("Wprowadzone działanie: ");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
                Console.Write(mathOperations[i] + " ");
            }

            Console.WriteLine($"{result}\n");
        }

        public static void OneMoreTime()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Kolejne działanie?\nJeśli tak wbybierz T lub cokoliwek innego aby zakończyć.");
            Console.ResetColor();
        }

        public static bool ThisIsNotNumber(string inputString)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wprowadzona wartość: '{inputString}' nie jest liczbą lub zamiast przecinka jest kropka.\n");
            Console.ResetColor();
            Console.WriteLine("Wciśnij dowolny klawisz, aby powtórzyć.");
            Console.ReadKey();
            Console.Clear();
            return true;
        }

        public static bool WeCantDivisionByZero()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Nie można dzielić przez zero!");
            Console.ResetColor();
            Console.WriteLine("Wciśnij dowolny klawisz, aby powtórzyć.");
            Console.ReadKey();
            return true;
        }

        public static bool ThisIsNotOperator(string mathOperation)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wprowadzony znak: '{mathOperation}' nie jest poprawny.\n");
            Console.ResetColor();
            Console.WriteLine("Wciśnij dowolny klawisz, aby powtórzyć wybór.");
            Console.ReadKey();
            Console.Clear();

            return true;
        }

        public static void End()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Zamykamy konsolę, trzymaj się! :)\n");
            Console.ResetColor();
        }
    }
}
