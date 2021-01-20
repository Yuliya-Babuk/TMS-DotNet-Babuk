using System;
using System.Collections.Generic;

namespace DayHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start;
            DateTime end;

            Console.WriteLine("<<Вывод дат определенного дня недели за период и подсчет количества этих дней>>");
            while (true)
            {
                Console.WriteLine("\nВведите начало периода:");

                while (!DateTime.TryParse(Console.ReadLine(), out start))
                    Console.WriteLine("Введите дату в корректном формате ДД.ММ.ГГГГ ");

                Console.WriteLine("\nВведите окончание периода:");


                end = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("\nВведите день недели:");

                if (start > end)
                {
                    DateTime temp;
                    temp = start;
                    start = end;
                    end = temp;
                }

                string dayOfWeek = Console.ReadLine();
                var list = GetListOfDays(start, end, dayOfWeek);
                Console.ReadKey();
            }
        }

        private static List<DateTime> GetListOfDays(DateTime start, DateTime end, string dayOfWeek)

        {
            var filteredDays = new List<DateTime>();
            while (end >= start)
            {
                if (start.DayOfWeek.ToString() == dayOfWeek)
                {
                    filteredDays.Add(start);
                }
                start = start.AddDays(1);
            }

            foreach (var day in filteredDays)
            Console.WriteLine(day.Date);
            Console.WriteLine("-------------------");
            Console.WriteLine(filteredDays.Count);
            return filteredDays;

        }
    }
}
