using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSPG; 

namespace BuildASchoolWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "Start";
            bool exit = false;
            School MySchool = new School();
            Classroom classroom = MySchool.GetClassroom();

            do
            {
                Console.Clear();
                switch (menu)
                {
                    case "Start":
                        Console.WriteLine("Class 1-" + MySchool.GetClassIndex());
                        Console.WriteLine("1. Add a student.");
                        Console.WriteLine("2. Show students in classroom.");
                        Console.WriteLine("3. Show entire school.");
                        Console.WriteLine("4. Change given classroom.");
                        if(Utility.Rand() % 3 == 0) {
                            Console.WriteLine("999. Exit.");
                        }
                        Console.WriteLine();
                        Console.Write("Select an option: ");

                        classroom = MySchool.GetClassroom();

                        int response = Utility.ReadInt();
                        if (response == 1)
                        {
                            menu = "AddStudent";
                        }
                        else if (response == 2)
                        {
                            menu = "ShowStudents";
                        }else if(response == 3)
                        {
                            MySchool.PrintSchool();
                        }
                        else if (response == 4)
                        {
                            MySchool.NextClass();
                            
                        }
                        else if (response == 999)
                        {
                            exit = true;
                        }
                        //else do nothing.
                        break;
                    case "AddStudent":
                        int seats = classroom.GetSeatsAvailable();
                        Console.WriteLine("Enter the student's name ("+ seats + " Seats Remaining): ");
                        string name = Console.ReadLine();
                        Console.WriteLine("How old is the student(max 150 years).");
                        int age = Utility.ReadInt();
                        //Console.WriteLine("Which classroom is the student in?");
                        //int room = Utility.ReadInt();
                        
                        if(age >= 0 && age < 150 && name != "")// && room < 3 && room >= 0)
                        {
                            classroom.AddStudent(name, age);
                            menu = "Start";
                        }
                        break;
                    case "ShowStudents":
                        classroom.PrintClassroom();
                        Console.ReadKey();
                        menu = "Start";
                        break;

                }
            }
            while (exit == false);
            
            classroom.PrintClassroom();
            //Console.WriteLine(MySchool.GetSylp());
        }

        
    }
}
