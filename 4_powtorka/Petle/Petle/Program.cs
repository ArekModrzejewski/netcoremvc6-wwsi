namespace Petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie1();
            Zadanie2();
            Zadanie3();
            Zadanie4();
            Zadanie5();
        }

        static void Zadanie1()
        {
            int n1 = 10;
            int n2 = 20;
            if (n1 > n2) {
                Console.WriteLine("n1 jest większe od n2");
            } else if (n1 < n2)
            {
                Console.WriteLine("n1 jest mniejsze od n2");
            }
            else { Console.WriteLine("n1 jest rowne n2"); }
        }
        static void Zadanie2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("C#");
            }
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine("C#");
                j++;
            }
        }
        static void Zadanie3()
        {
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                switch (i % 2)
                {
                    case 0:
                        Console.WriteLine("Parzysta");
                        break;
                    case 1:
                        Console.WriteLine("Nieparzysta");
                        break;
                    default:
                        break;
                }
            }
        } 
        static void Zadanie4() 
        {
            int n = 5;
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += "* ";
                Console.WriteLine(result);
            }
        }
        static void Zadanie5()
        {
            int exam = 57;
            if (exam >= 0 && exam <= 39)
            {
                Console.WriteLine("Ocena Niedostateczna");
            }
            else if (exam > 39 && exam <= 54)
            {
                Console.WriteLine("Ocena Dopuszczająca");
            }
            else if (exam > 54 && exam <= 69)
            {
                Console.WriteLine("Ocena Dostateczna");
            }
            else if (exam > 69 && exam <= 84)
            {
                Console.WriteLine("Ocena Dobra");
            }
            else if (exam > 84 && exam <= 98)
            {
                Console.WriteLine("Ocena Bardzo Dobra");
            }
            else if (exam > 98 && exam <= 100)
            {
                Console.WriteLine("Ocena Celująca");
            }
            else
            {
                Console.WriteLine("Wartość poza zakresem");
            }
        }
    }
}