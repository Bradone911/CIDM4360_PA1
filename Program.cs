using System;
using System.Collections.Generic;


namespace CIDM4360_PA1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UndergradStudent> underGrads = new List<UndergradStudent>();
            List<GradStudent> gradStudents = new List<GradStudent>();
            bool running = true;
            while(running){
                MainMenu();
            }
        
            UndergradStudent s = UndergradStudent.addStudent();
            Console.WriteLine($"Name: {s.StudName}");
            Console.ReadLine();
        }

        static void MainMenu(){
            Dictionary<int,string> options = new Dictionary<int,string>()
            {
                {1,"Add Grad Student"},
                {2, "Add undergrad student"},
                {3, "List All grad students"}
            };
            foreach(var entry in options){
                Console.WriteLine($"{entry.Key}. {entry.Value}");
            }
            Console.ReadLine();
        }
    }
}
