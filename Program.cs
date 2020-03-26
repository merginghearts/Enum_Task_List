using System;
using System.Collections;
using System.Collections.Generic;

namespace Enum_Task_List
{
    class Program
    {   
        public enum WeekDays
        {
            Monday,
            Tuesday, 
            Wednesday, 
            Thursday, 
            Friday, 
            Saturday, 
            Sunday
        }
        static void Main(string[] args)
        {
            List<string> tasklist = new List<string>();
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine("Enter a new task for " + day);
                string task = day + " : " + Console.ReadLine();
                tasklist.Add(task); 
            }
            foreach(string task in tasklist)
            {
                Console.WriteLine(task);
            }
        
        }

    }
}
