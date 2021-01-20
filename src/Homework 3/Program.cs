using System;
using ToDoApp;

namespace ConsoleApp1
{
    class ToDoApp
    {
        static void Main(string[] args)
        {
            var organizer = new Organizer();
            bool stop = false;
            string action;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Press \n1 - to add a task, \n2 - to look throw my tasks, \n3 - to update a task, \n4 - to cancel a task, \n0 - to exit \n");
                Console.ResetColor();
                action = Console.ReadLine();
                Console.WriteLine();
                switch (action)
                {
                    case "1":
                        AddTaskToOrg(organizer);
                        break;
                    case "2":
                        ToLookThrow(organizer);
                        break;
                    case "3":
                        UpdateTask(organizer);
                        break;
                    case "4":
                        {
                            Console.WriteLine("Введите ID номер задачи:");
                            int id = Convert.ToInt32(Console.ReadLine());
                            organizer.CancelTask(id);

                        }
                        break;
                    case "0":
                        stop = true;
                        break;
                    default:
                        Console.WriteLine("Enter correct number:");
                        break;
                }


            } while (!stop);
        }

        private static void AddTaskToOrg(Organizer organizer)
        {
            Console.WriteLine("Введите описание задачи");
            var description = Console.ReadLine();
            Console.WriteLine("Введите дату начала задачи");

            DateTime start;
            do
            {
                try
                {
                    start = Convert.ToDateTime(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введите дату в формате ДД/ММ/ГГГГ");
                    continue;
                }

                break;
            } while (true);

            Console.WriteLine("Введите дату окончания задачи");
            DateTime end;
            do
            {
                try
                {
                    end = Convert.ToDateTime(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введите дату в формате ДД/ММ/ГГГГ");
                    continue;
                }

                break;
            } while (true);

            organizer.AddTask(start, end, description);
        }
        public static void ToLookThrow(Organizer organizer)
        {

            foreach (var task in organizer.Tasks)
            {
                task.Info();
            }
        }
        public static void UpdateTask(Organizer organizer)
        {
            Console.WriteLine("Введите ID номер задачи:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите описание задачи");
            var description = Console.ReadLine();
            Console.WriteLine("Введите дату начала задачи");
            DateTime start;
            do
            {
                try
                {
                    start = Convert.ToDateTime(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введите дату в формате ДД/ММ/ГГГГ");
                    continue;
                }

                break;
            } while (true);

            Console.WriteLine("Введите дату окончания задачи");
            DateTime end;
            do
            {
                try
                {
                    end = Convert.ToDateTime(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введите дату в формате ДД/ММ/ГГГГ");
                    continue;
                }

                break;
            } while (true);

            Console.WriteLine($"Введите код статуса задачи: \n1 - toDo \n2 - inProgress \n3 - done \n4 - canceled ");
            int num = Convert.ToInt16(Console.ReadLine());
            Status status = Status.toDo;
            switch (num)
            {
                case 1:
                    status = Status.toDo;
                    break;
                case 2:
                    status = Status.inProgress;
                    break;
                case 3:
                    status = Status.done;
                    break;
                case 4:
                    status = Status.canceled;
                    break;
                default:
                    Console.WriteLine("Введите корректный код статуса!");
                    break;

            }

            organizer.UpdateTask(id, start, end, description, status);
        }


    }



}
