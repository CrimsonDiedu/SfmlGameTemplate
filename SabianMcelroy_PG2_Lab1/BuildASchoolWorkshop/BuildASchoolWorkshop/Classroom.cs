using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildASchoolWorkshop
{
    class Classroom
    {
        int seats;
        Student[] students;
        


        public Classroom(int s = 10)
        {
            seats = s;
            students = new Student[seats];
            for(int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
            }
        }
        public void AddStudent(string name, int age)
        {
            if (seats > 0)
            {
                Student s = new Student(name, age);
                students[seats - 1] = s;
                seats--;
            }
            
        }

        public void PrintClassroom() {
            Student student;
            string myClass = "";

            for(int i = 0; i < students.Length; i++)
            {
                student = students[i];
                myClass += i + ".)     ";
                myClass += student.GetAge() + " year old ";
                myClass += student.GetName() + ".";
                Console.WriteLine(myClass);
                myClass = "";
            }
        }

        public int GetSeatsAvailable()
        {
            return seats;
        }
    }
}
