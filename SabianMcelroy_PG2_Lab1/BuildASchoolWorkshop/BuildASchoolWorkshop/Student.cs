using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildASchoolWorkshop
{
    class Student
    {
        string name;
        int age;
        public Student(string n = "noone", int a = 0)
        {
            name = n;
            age = a;
        }

        public int GetAge()
        {
            return age;
        }
        public string GetName()
        {
            return name;
        }

    }
}
