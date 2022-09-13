using System;

namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string inputString;
            string mathOperation;
            double outputDouble;
            bool again;
            //ConsoleKeyInfo mathOperation;

            do
            {
                var numbers = new List<double> { };
                var mathOperations = new List<string> { };
                short j = -1;
                do
                {
                    do
                    {

                        OutputText.GreetingKalkulatorStart();
                        OutputText.TaskInputStart(numbers, mathOperations);

                        inputString = Console.ReadLine();
                        
                        if (mathOperations.Count!= 0)
                        {
                            if ((mathOperations[j] == "/" || mathOperations[j] == ":") && inputString == "0")
                                again = OutputText.WeCantDivisionByZero(); //true

                            else if (double.TryParse(inputString, out outputDouble))
                            {
                                numbers.Add(outputDouble);
                                again = false;
                            }

                            else again = OutputText.ThisIsNotNumber(inputString); //true
                        }

                        else if (double.TryParse(inputString, out outputDouble))
                        {
                            numbers.Add(outputDouble);
                            again = false;
                        }

                        else again = OutputText.ThisIsNotNumber(inputString); //true

                    } while (again);

                    again = true;
                    bool againMathOperation;

                    do
                    {
                        OutputText.GreetingKalkulatorStart();
                        OutputText.TaskInputStart(numbers, mathOperations);

                        /*
                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.Add:
                                mathOperations.Add("+");
                                againMathOperation = false;
                                break;

                            case ConsoleKey.Subtract:
                                mathOperations.Add("-");
                                againMathOperation = false;
                                break;

                            case ConsoleKey.Divide:
                                mathOperations.Add("/");
                                againMathOperation = false;
                                break;

                            case ConsoleKey.Multiply:
                                mathOperations.Add("+");
                                againMathOperation = false;
                                break;

                            case ConsoleKey.:
                                mathOperations.Add("=");
                                againMathOperation = false;
                                again = false;
                                break;

                            default:
                                againMathOperation = OutputText.ThisIsNotOperator(mathOperation);
                                break;
                        }
                        */


                        mathOperation = Console.ReadLine();
                        if (mathOperation == "+")
                        {
                            mathOperations.Add("+");
                            againMathOperation = false;
                        }
                        else if (mathOperation == "-")
                        {
                            mathOperations.Add("-");
                            againMathOperation = false;
                        }
                        else if (mathOperation == "*")
                        {
                            mathOperations.Add("*");
                            againMathOperation = false;
                        }
                        else if (mathOperation == "/" || mathOperation == ":")
                        {
                            mathOperations.Add("/");
                            againMathOperation = false;
                        }
                        else if (mathOperation == "=")
                        {
                            mathOperations.Add("=");
                            againMathOperation = false;
                            again = false;
                        }
                        else againMathOperation = OutputText.ThisIsNotOperator(mathOperation); //true

                        

                    } while (againMathOperation);

                    j++;
                } while (again);

                double result = MathOperations.ResultOfTask(numbers, mathOperations);

                OutputText.GreetingKalkulatorEnd();
                OutputText.TaskInputEnd(numbers, mathOperations, result);
                OutputText.OneMoreTime();

            } while (Console.ReadKey().Key == ConsoleKey.T);

            OutputText.End();
        }
    }
}