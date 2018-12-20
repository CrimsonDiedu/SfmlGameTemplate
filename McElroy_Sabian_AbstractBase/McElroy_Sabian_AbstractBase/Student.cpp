#include "stdafx.h"
#include "Student.h"


Student::Student(char * n, char * d, unsigned short g, unsigned short l)
{
	name = n;
	degree = d;
	GPA = g;
	likeability = l;
}


Student::~Student()
{
}

void Student::DisplayRecord() 
{
	cout << "Name: " << name << "\nDegree: " << degree << "\nGPA: " << GPA << "\nlikeability: " << likeability;
}