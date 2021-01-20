using System;

namespace ToDoApp
{
    public class Task
    {
        private static int _idCounter = 0;
        private static DateTime _start;

        public DateTime Start
        { get; set; }

        public DateTime End { get; set; }

        public int ID { get; set; }
        public Status Status { get; set; }
        public string Description { get; set; }

        public Task(DateTime start, DateTime end, Status status, string description)
        {
            Start = start;
            End = end;
            Status = status;
            Description = description;

            ID = _idCounter;
            _idCounter++;
        }

        public Task()
        {
        }

        public void Info()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine("---------------");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Dates: {Start.ToString("d")} - {End.ToString("d")}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine();
        }
    }

    public enum Status
    {
        toDo = 0,
        inProgress = 1,
        done = 2,
        canceled = 3
    }



}
