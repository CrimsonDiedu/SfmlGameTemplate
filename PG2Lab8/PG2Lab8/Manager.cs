using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2Lab8
{
    class Manager : Employee
    {
        private int Bonus;
        public Manager(string n = "Jack", string l = "Aboi", int a = 2, int s = 100, int b = 10)
        {
            Name = n;
            LastName = l;
            Age = a;
            Salary = s;
            Bonus = b;
        }

        public override string Info()
        {
            string str = base.Info();
            str += " " + Bonus;
            return str;
        }
    }
}
