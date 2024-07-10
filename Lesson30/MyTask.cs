using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson30
{
    internal class MyTask
    {
        private string? task;
        private DateTime date;
        private string? priority;

        public MyTask(string? task, DateTime date, string? priority)
        {
            this.task = task;
            this.date = date;
            this.priority = priority;
        }
        public string getTask() => task!;
        public DateTime getDate() => date;
        public string getPriority() => priority!;
        public void setTask(string ? task) => this.task = task;
        public void setDate(DateTime date) => this.date = date; 
        public void setPriority(string? priority) => this.priority = priority;

    }
}
