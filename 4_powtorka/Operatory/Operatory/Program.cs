namespace Operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie1
            int number = 7;
            float money = 2.5f;
            string text = "Default text";
            bool isLogged = true;
            char myChar = '$';
            decimal price = 2.45M;
            Console.WriteLine($"number = {number}");
            Console.WriteLine($"money = {money}");
            Console.WriteLine($"text = {text}");
            Console.WriteLine($"isLogged = {isLogged}");
            Console.WriteLine($"myChar = {myChar}");
            Console.WriteLine($"price = {price}");

            //Zadanie2
            string myAge = "Age: ";
            int wifeAge = 18;
            string result = myAge + wifeAge;
            Console.WriteLine(result);
            //Wniosek: C# automatycznie "castuje" int na string

            //Zadanie3
            bool isTrue = true;
            bool isFalse = false;
            bool isReallyTrue = true;
            bool and = isTrue && isFalse;
            bool or = isTrue || isReallyTrue;
            bool negative = !isFalse;
            Console.WriteLine($"and = {and}");
            Console.WriteLine($"or = {or}");
            Console.WriteLine($"negative = {negative}");
        }
    }
}