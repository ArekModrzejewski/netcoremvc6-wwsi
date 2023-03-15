namespace Operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            zadanie1();
            zadanie2();
            zadanie3();
            zadanie4();
            zadanie5();
        }
        static void zadanie1()
        {
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
        }

        static void zadanie2()
        {
            string myAge = "Age: ";
            int wifeAge = 18;
            string result = myAge + wifeAge;
            Console.WriteLine(result);
            //Wniosek: C# automatycznie "castuje" int na string
        }

        static void zadanie3() {
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
        static void zadanie4() {
            int a = 5;
            int b = 12;
            int add = a + b;
            int sub = a - b;
            double div = Convert.ToDouble(a) / Convert.ToDouble(b);
            int mul = a * b;
            int mod = a % b;
            Console.WriteLine($"add = {add}");
            Console.WriteLine($"sub = {sub}");
            Console.WriteLine($"div = {div}");
            Console.WriteLine($"mul = {mul}");
            Console.WriteLine($"mod = {mod}");
        }
        static void zadanie5() {
            string a = "Ala ";
            string b = "ma ";
            string c = "kota.";
            string result = a + b + c;
            Console.WriteLine($"result = {result}");
        }
    }
}