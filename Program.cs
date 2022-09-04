namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            string mathOperation;
            double c;
            string again = "T";
            Console.WriteLine("Witaj w kalkulatorze konsolowym!");

            do
            {
                Console.Write("Wprowadź pierwszą liczbę: ");
                a = Console.ReadLine();

                Console.WriteLine("Co chcesz zrobić?");
                Console.WriteLine("Dodawać, wybierz z klawiatury '+'");
                Console.WriteLine("Odejmować, wybierz z klawiatury '-'");
                Console.WriteLine("Mnożyć, wybierz z klawiatury '*'");
                Console.WriteLine("Dzielić, wybierz z klawiatury ':' lub '/''");
                Console.Write("Wprowadź znak: ");

                mathOperation = Console.ReadLine();

                Console.Clear();
                Console.WriteLine($"Aktualne działanie: {a} {mathOperation} ");

                Console.Write("Wprowadź drugą liczbę: ");
                b = Console.ReadLine();

                Console.Clear();
                Console.WriteLine($"Aktualne działanie: {a} {mathOperation} {b}");

                double aDouble = double.Parse(a);
                double bDouble = double.Parse(b);

                if (mathOperation == "+")
                {
                    c = aDouble + bDouble;
                }
                else if (mathOperation == "-")
                {
                    c = aDouble - bDouble;
                }
                else if (mathOperation == "*")
                {
                    c = aDouble * bDouble;
                }
                else
                {
                    c = aDouble / bDouble;
                }

                Console.WriteLine($"Wynik działania {a} {mathOperation} {b} to {c}");
                Console.WriteLine($"Jeszcze raz wbybierz T lub cokoliwek innego aby zakończyć");
                again = Console.ReadLine();
                Console.Clear();
            } while (again == "T" || again == "t");

            Console.WriteLine($"Zamykamy konsolę, trzymaj się! :)");
        }
    }
}