using System;

namespace DateHandler
{
    class Program
    {
        static void Main(string[] args)

        {
            while (true)

            {
                Console.WriteLine("Введите дату и узнайте день недели!");

                try

                {
                    var Date = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("День недели: " + Date.DayOfWeek);
                    Console.WriteLine("****************************************");
                }
                catch (Exception)

                {
                    Console.WriteLine("Введите дату в корректном формате: ДД/ММ/ГГГГ или ДД.ММ.ГГГГ");
                    Console.WriteLine("****************************************");
                }
        
            }      
        }
    }
}
