using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoApp
{
    class Organizer
    {

        public List<Task> Tasks { get; set; }

        public Organizer()
        {
            Tasks = new List<Task>();
        }

        public void AddTask(DateTime taskStart, DateTime taskEnd, string taskDescription, Status taskStatus = Status.toDo)
        {
            var task = new Task(taskStart, taskEnd, taskStatus, taskDescription);
            Tasks.Add(task);
            Console.WriteLine($"\nID номер задачи: {task.ID}\n");
        }


        public bool UpdateTask(int id, DateTime taskStart, DateTime taskEnd, string taskDescription, Status status)
        {

            Task task = Tasks.FirstOrDefault(t => t.ID == id);
            if (task == null)
            {
                return false;
            }

            task.Start = taskStart;
            task.End = taskEnd;
            task.Description = taskDescription;
            task.Status = status;
            return true;
        }

        public void CancelTask(int id)
        {

            Task task = Tasks.FirstOrDefault(t => t.ID == id);
            if (task == null)
            {
                return;
            }
            task.Status = Status.canceled;
        }

    }

}


