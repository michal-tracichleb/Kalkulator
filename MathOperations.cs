using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    internal class MathOperations
    {
        public static double ResultOfTask(List<double> numbers, List<string> mathOperations)
        {
            double result = numbers[0];
            bool again = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i + 1 != numbers.Count)
                {
                    if (mathOperations[i + 1] == "*" || mathOperations[i + 1] == "/")
                    {
                        int j = 1;
                        double resultTemporary = numbers[i + j];
                        do
                        {
                            again = false;

                            if (mathOperations[i + j] == "*") resultTemporary = resultTemporary * numbers[i + j + 1];
                            if (mathOperations[i + j] == "/") resultTemporary = resultTemporary / numbers[i + j + 1];

                            if (i + 1 + j != numbers.Count)
                                if (mathOperations[i + 1 + j] == "*" || mathOperations[i + 1 + j] == "/") again = true;

                            j++;
                        } while (again);

                        if (mathOperations[i] == "+") result = result + resultTemporary;
                        if (mathOperations[i] == "-") result = result - resultTemporary;


                        i = i + j - 1;
                    }
                    else
                    {
                        if (mathOperations[i] == "+")
                            result = result + numbers[i + 1];

                        if (mathOperations[i] == "-")
                            result = result - numbers[i + 1];

                        if (mathOperations[i] == "*")
                            result = result * numbers[i + 1];

                        if (mathOperations[i] == "/")
                            result = result / numbers[i + 1];
                    }
                }
            }

            return result;
        }
    }
}
