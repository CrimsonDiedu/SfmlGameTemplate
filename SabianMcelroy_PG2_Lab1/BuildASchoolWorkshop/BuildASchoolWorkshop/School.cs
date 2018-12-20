using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildASchoolWorkshop
{
    class School
    {
        int size;
        int classindex;
        Classroom[] classrooms;

        public School(int s = 3) {
            classrooms = new Classroom[s];
            size = s;
            classindex = 0;
            for(int i = 0; i < classrooms.Length; i++)
            {
                classrooms[i] = new Classroom();
            }

        }

        public void PrintSchool() {
            //Console.WriteLine("_____________________________");
            for (int i = 0; i < classrooms.Length; i++)
            {
                Console.WriteLine("Class 1-" + i);
                classrooms[i].PrintClassroom();
            }
            Console.ReadKey();
        }

        public Classroom NextClass()
        {
            classindex++;
            if (classindex == 3)
            {
                classindex = 0;
            }
            return GetClassroom();
        }
        public Classroom GetClassroom()
        {
            return classrooms[classindex];
        }
        public int GetClassIndex()
        {
            return classindex;
        }


    }
}
