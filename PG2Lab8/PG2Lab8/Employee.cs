using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2Lab8
{
    class Employee
    {
        protected string Name;
        protected string LastName;
        protected int Age;
        protected int Salary;
        public Employee(string n = "John", string l = "doe", int a = 1, int s = 10)
        {
            Name = n;
            LastName = l;
            Age = a;
            Salary = s;
        }
        public virtual string Info()
        {
            string str = "";
            str += Name + " ";
            str += LastName + " ";
            str += Age + " ";
            str += Salary;

            return str;
        }
    }
}
