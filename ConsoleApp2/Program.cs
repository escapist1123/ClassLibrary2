using System;
using MyLibrary;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов класса Person
            Person person1 = new Person("Alice", 30);
            Person person2 = new Person("Bob", 25);

            // Связывание объектов (например, в массиве)
            Person[] people = { person1, person2 };

            // Вывод содержания объектов
            Console.WriteLine("Содержимое объектов:");
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            // Задержка перед закрытием консоли
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

    }

}
