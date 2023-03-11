namespace Kolekcje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie1();
            Zadanie2();
        }

        static void Zadanie1()
        {
            string[] colors = { "green", "blue", "red", "pink" };
            Console.WriteLine($"First color: {colors[0]}");
            Console.WriteLine($"Last color: {colors[colors.Length - 1]}");
        }

        static void Zadanie2()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Liczba: {numbers[i]}");
            }

            foreach (int number in numbers)
            {
                Console.WriteLine($"Liczba: {number}");
            }
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine($"Liczba: {numbers[j]}");
                j++;
            }
        }
        static void Zadanie3()
        {
            List<string> fruits = new List<string>(4);
            fruits.Add("apple");
            fruits.Add("peach");
            fruits.Add("strawberry");
            fruits.Add("blueberry");

        }
    }
}