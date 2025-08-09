namespace Project_251
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a = 3;
            int b = 2;*/

            // int / int = int
            // double average = (a + b) / 2.0;

            // Литералы
            /*
             * 42 // int
             * 2123214234234234 // long
             * 2.5 // double
             * 2.5f // float
             * 2.5m // decimal
             * 'a' // char
             * "Hello" // string
             * true, false // bool
            */

            /*int number = 1234;

            int secondDigit = (1234 / 100) % 10;

            Console.WriteLine(secondDigit);*/

            // Преобразование типов
            // Небезопасное преобразование
            /*int a = 300000;
            short b = (short)a;*/

            // Безопасное преобразование
            short a = 30000;
            int b = a; // неявное преобразование

            Console.WriteLine($"a: {a}\tb: {b}");
        }
    }
}
