namespace Project_251
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int leftNumber, rightNumber;

            Console.Write("Введите целое левое число: ");
            leftNumber = int.Parse(Console.ReadLine());

            Console.Write("Введите целое правое число: ");
            rightNumber = int.Parse(Console.ReadLine());

            // Арифметические операции
            // Сумма, разность, произведение, частное и остаток от деления
            // +, -, *, /, %
            // + - сложение
            // - - вычитание
            // * - умножение
            // / - деление
            // % - остаток от деления
            // = - присваивание
            // Операторы бывают унарными и бинарными

            double result = (double)leftNumber / rightNumber;
            // int / int = int
            // int / double = double
            // double / int = double
            // double / double = double

            // Вывод результата деления
            Console.WriteLine($"Результат деления {leftNumber} на {rightNumber} равен: {result}");

            int sum = leftNumber + rightNumber; // Сумма
            int difference = leftNumber - rightNumber; // Разность
            int product = leftNumber * rightNumber; // Произведение
            double quotient = (double)leftNumber / rightNumber; // Частное
            int remainder = leftNumber % rightNumber; // Остаток от деления

            // Вывод результатов
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Разность: {difference}");
            Console.WriteLine($"Произведение: {product}");
            Console.WriteLine($"Частное: {quotient}");
            Console.WriteLine($"Остаток от деления: {remainder}");

            // Дополнительные операции
            // Увеличение на 1 (Инкремент)
            leftNumber++; // Постфиксный инкремент
            ++leftNumber; // Префиксный инкремент
            // leftNumber = leftNumber + 1; // Альтернативный способ увеличения на 1

            // Уменьшение на 1 (Декремент)
            leftNumber--; // Постфиксный декремент
            --leftNumber; // Префиксный декремент
            // leftNumber = leftNumber - 1; // Альтернативный способ уменьшения на 1

            leftNumber += 5; // Увеличение на 5
            leftNumber = leftNumber + 5; // Альтернативный способ увеличения на 5

            leftNumber -= 3; // Уменьшение на 3
            leftNumber = leftNumber - 3; // Альтернативный способ уменьшения на 3

            leftNumber *= 2; // Умножение на 2
            leftNumber = leftNumber * 2; // Альтернативный способ умножения на 2

            leftNumber /= 4; // Деление на 4
            leftNumber = leftNumber / 4; // Альтернативный способ деления на 4

            leftNumber %= 5; // Остаток на 5
            leftNumber = leftNumber % 5; // Альтернативный способ получения остатка от деления на 5
        }
    }
}
