namespace Project_251
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Константы
            // Константы - это неизменяемые значения, которые задаются один раз и не могут быть изменены в дальнейшем.
            const int speed = 100;

            speed = 200; // Ошибка компиляции, так как константа не может быть изменена

            // bool booleanValue = true;
            // Булев тип данных
            // Булев тип данных может принимать только два значения: true (истина) или false (ложь).

            // Операторы сравнения
            // Операторы сравнения используются для сравнения значений и возвращают булев тип данных.
            // Примеры операторов сравнения:
            /*
             * < - меньше
             * > - больше
             * <= - меньше или равно
             * >= - больше или равно
             * == - равно
             * != - не равно
             */

            /*bool isGreater = 5 < 42;
            Console.WriteLine(isGreater);*/

            // Условные операторы
            /*if (5 < 42)
            {
                Console.WriteLine("5 greater 42");
            }*/

            // Задача вывести название дня недели по порядковому номеру
            Console.Write("Введите порядковый номер дня недели: ");
            int dayNumber = int.Parse(Console.ReadLine());

            if (dayNumber > 0)
            {
                Console.WriteLine($"{dayNumber} greater 0");
            }
            else
            {
                Console.WriteLine($"{dayNumber} less or equal 0");
            }

            if (dayNumber == 1)
            {
                Console.WriteLine("Номер дня недели введен корректно.");
            }
            else if (dayNumber == 2)
            {
                Console.WriteLine("Номер дня недели введен корректно.");
            }
            else if (dayNumber == 3)
            {
                Console.WriteLine("Номер дня недели введен корректно.");
            }
            else if (dayNumber == 4)
            {
                Console.WriteLine("Номер дня недели введен корректно.");
            }
            else if (dayNumber == 5)
            {
                Console.WriteLine("Номер дня недели введен корректно.");
            }
            else if (dayNumber == 6)
            {
                Console.WriteLine("Номер дня недели введен корректно.");
            }
            else if (dayNumber == 7)
            {
                Console.WriteLine("Номер дня недели введен корректно.");
            }
            else
            {
                Console.WriteLine("Некорректный номер дня недели. Пожалуйста, введите число от 1 до 7.");
            }

            // Логические операторы
            /*
             * && - логическое И (AND)
             * || - логическое ИЛИ (OR)
             * ! - логическое НЕ (NOT) !true = false, !false = true
             */

            // Пример использования логических операторов
            /*if (dayNumber >= 1 && (dayNumber <= 7 || dayNumber == 42))
            {
                Console.WriteLine("Номер дня недели введен корректно.");
            }
            else
            {
                Console.WriteLine("Некорректный номер дня недели. Пожалуйста, введите число от 1 до 7.");
            }*/

            // Тернарный оператор
            string dayParity = dayNumber % 2 == 0 ? "четным" : "нечетным";
            Console.WriteLine($"Порядковый номер дня недели {dayNumber} является {dayParity}.");

            // Сгенерировать случайное число от 1 до 100
            int randomNumber = Random.Shared.Next(1, 101);
            Console.WriteLine(randomNumber);

            // Сгенерировать случайное число до 100
            randomNumber = Random.Shared.Next(100);
            Console.WriteLine(randomNumber);
        }
    }
}
