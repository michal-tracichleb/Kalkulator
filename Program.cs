using System;

namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string inputString;
            string mathOperation;
            short idMathOperation;
            double outputDouble;
            string again;
            double result;
            double resultTemporary = 0;

            do
            {
                var numbers = new List<double> { };
                var mathOperations = new List<string> { };
                short j = -1;
                do
                {
                    do
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Witaj w kalkulatorze konsolowym!\nPamiętaj, aby każdą wprowadzoną liczbę i operator (+, -, *, /, =) zkończyć przyciskiem 'ENTER'.\n");
                        Console.ResetColor();

                        Console.Write("Wprowadź działanie: ");
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.Write(numbers[i] + " ");
                            Console.Write(mathOperations[i] + " ");
                        }

                        inputString = Console.ReadLine();
                        
                        if (mathOperations.Count!= 0)
                        {
                            if ((mathOperations[j] == "/" || mathOperations[j] == ":") && inputString == "0")
                            {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Nie można dzielić przez zero!");
                            Console.ResetColor();
                            Console.WriteLine("Wciśnij dowolny klawisz, aby powtórzyć.");
                            Console.ReadKey();
                            again = "T";
                            }
                            else if (double.TryParse(inputString, out outputDouble))
                            {
                                numbers.Add(outputDouble);
                                again = "F";
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Wprowadzona wartość: '{inputString}' nie jest liczbą lub zamiast przecinka jest kropka.\n");
                                Console.ResetColor();
                                Console.WriteLine("Wciśnij dowolny klawisz, aby powtórzyć.");
                                Console.ReadKey();
                                Console.Clear();
                                again = "T";
                            }
                        }
                        else if (double.TryParse(inputString, out outputDouble))
                        {
                            numbers.Add(outputDouble);
                            again = "F";
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Wprowadzona wartość: '{inputString}' nie jest liczbą lub zamiast przecinka jest kropka.\n");
                            Console.ResetColor();
                            Console.WriteLine("Wciśnij dowolny klawisz, aby powtórzyć.");
                            Console.ReadKey();
                            Console.Clear();
                            again = "T";
                        }
                    } while (again == "T");

                    again = "T";
                    do
                    {

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Witaj w kalkulatorze konsolowym!\nPamiętaj, aby każdą wprowadzoną liczbę i operator (+, -, *, /, =) zkończyć przyciskiem 'ENTER'.\n");
                        Console.ResetColor();

                        Console.Write("Wprowadź działanie: ");

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.Write(numbers[i] + " ");
                            if (i != numbers.Count - 1)
                            Console.Write(mathOperations[i] + " ");
                        }

                        mathOperation = Console.ReadLine();
                        if (mathOperation == "+")
                        {
                            mathOperations.Add("+");
                            idMathOperation = 1;
                        }
                        else if (mathOperation == "-")
                        {
                            mathOperations.Add("-");
                            idMathOperation = 1;
                        }
                        else if (mathOperation == "*")
                        {
                            mathOperations.Add("*");
                            idMathOperation = 1;
                        }
                        else if (mathOperation == "/" || mathOperation == ":")
                        {
                            mathOperations.Add(":");
                            idMathOperation = 1;
                        }
                        else if (mathOperation == "=")
                        {
                            mathOperations.Add("=");
                            idMathOperation = 1;
                            again = "F";
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

                    j++;

                } while (again == "T");

                result = numbers[0];

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i + 1 != numbers.Count)
                    {
                        if (mathOperations[i + 1] == "*" || mathOperations[i + 1] == ":")
                        {
                            j = 1;
                            resultTemporary = numbers[i + j];
                            do
                            {
                                again = "F";
                                if (mathOperations[i + j] == "*")
                                {
                                    resultTemporary = resultTemporary * numbers[i + j + 1];
                                }
                                if (mathOperations[i + j] == ":")
                                {
                                    resultTemporary = resultTemporary / numbers[i + j + 1];
                                }
                                if (i + 1 + j != numbers.Count)
                                {
                                    if (mathOperations[i + 1 + j] == "*" || mathOperations[i + 1 + j] == ":")
                                    {
                                        again = "T";
                                    }
                                }
                                j++;
                            } while (again == "T");

                            if (mathOperations[i] == "+")
                            {
                                result = result + resultTemporary;
                            }
                            if (mathOperations[i] == "-")
                            {
                                result = result - resultTemporary;
                            }

                            i = i + j - 1;
                        }
                        else
                        {
                            if (mathOperations[i] == "+")
                            {
                                result = result + numbers[i + 1];
                            }
                            if (mathOperations[i] == "-")
                            {
                                result = result - numbers[i + 1];
                            }
                            if (mathOperations[i] == "*")
                            {
                                result = result * numbers[i + 1];
                            }
                            if (mathOperations[i] == ":")
                            {
                                result = result / numbers[i + 1];
                            }
                        }
                    }
                }

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Witaj w kalkulatorze konsolowym!\n");
                Console.ResetColor();

                Console.Write("Wprowadzone działanie: ");
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write(numbers[i] + " ");
                    Console.Write(mathOperations[i] + " ");
                }
                Console.WriteLine($"{result}\n");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Kolejne działanie?\nJeśli tak wbybierz T lub cokoliwek innego aby zakończyć.");
                again = Console.ReadLine();
                Console.Clear();
                Console.ResetColor();

            } while (again == "T" || again == "t");
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Zamykamy konsolę, trzymaj się! :)\n");
            Console.ResetColor();
        }
    }
}