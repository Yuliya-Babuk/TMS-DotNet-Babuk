using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату и узнайте день недели!");

            var Date = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine(Date.DayOfWeek);

        }
    }
}
