using System;

namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string inputStringA;
            string inputStringB;
            string mathOperation;
            short idMathOperation = 0;
            double aDouble = 0;
            double bDouble = 0;
            double c = 0;
            string again = "T";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Witaj w kalkulatorze konsolowym!");
            Console.ResetColor();

            do
            {
                do
                {
                    Console.Write("Wprowadź pierwszą liczbę: ");
                    inputStringA = Console.ReadLine();

                    if (double.TryParse(inputStringA, out aDouble))
                    {
                        again = "F";
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Wprowadzona wartość: '{inputStringA}' nie jest liczbą.\n");
                        Console.ResetColor();
                        Console.WriteLine("Wciśnij dowolny klawisz, aby powtórzyć.");
                        Console.ReadKey();
                        Console.Clear();
                        again = "T";
                    }
                } while (again == "T");


                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Wprowadź pierwszą liczbę: {inputStringA}");
                    Console.ResetColor();

                    Console.Write("\nCo chcesz zrobić?\n" +
                        "Dodawać, wybierz z klawiatury '+'\n" +
                        "Odejmować, wybierz z klawiatury '-'\n" +
                        "Mnożyć, wybierz z klawiatury '*'\n" +
                        "Dzielić, wybierz z klawiatury ':' lub '/''\n" +
                        "Wprowadź znak: ");

                    mathOperation = Console.ReadLine();
                    if (mathOperation == "+")
                    {
                        idMathOperation = 1;
                    }
                    else if (mathOperation == "-")
                    {
                        idMathOperation = 2;
                    }
                    else if (mathOperation == "*")
                    {
                        idMathOperation = 3;
                    }
                    else if (mathOperation == "/" || mathOperation == ":")
                    {
                        idMathOperation = 4;
                    }
                    else
                    {
                        idMathOperation = 0;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Wprowadzony znak: '{mathOperation}' nie jest poprawny.\n");
                        Console.ResetColor();
                        Console.WriteLine("Wciśnij dowolny klawisz, aby powtórzyć wybór.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (idMathOperation == 0);


                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Aktualne działanie: {inputStringA} {mathOperation} ");
                    Console.ResetColor();

                    Console.Write("Wprowadź drugą liczbę: ");
                    inputStringB = Console.ReadLine();

                    if ((mathOperation == "/" || mathOperation == ":") && inputStringB == "0")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Nie można dzielić przez zero!");
                        Console.ResetColor();
                        Console.WriteLine("Wciśnij dowolny klawisz, aby powtórzyć.");
                        Console.ReadKey();
                        again = "T";
                    }
                    else if (double.TryParse(inputStringB, out bDouble))
                    {
                        again = "F";
                    }   
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Wprowadzona wartość: '{inputStringB}' nie jest liczbą.\n");
                        Console.ResetColor();
                        Console.WriteLine("Wciśnij dowolny klawisz, aby powtórzyć.");
                        Console.ReadKey();
                        again = "T";
                    }
                } while (again == "T");


                Console.Clear();

                if (idMathOperation == 1)
                {
                    c = aDouble + bDouble;
                }
                else if (idMathOperation == 2)
                {
                    c = aDouble - bDouble;
                }
                else if (idMathOperation == 3)
                {
                    c = aDouble * bDouble;
                }
                else if (idMathOperation == 4)
                {
                    c = aDouble / bDouble;
                }

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Wynik działania {aDouble} {mathOperation} {inputStringB} = {c}\n");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Kolejne działanie?\nJeśli tak wbybierz T lub cokoliwek innego aby zakończyć.");
                again = Console.ReadLine();
                Console.Clear();
                Console.ResetColor();
            } while (again == "T" || again == "t");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Zamykamy konsolę, trzymaj się! :)");
        }
    }
}