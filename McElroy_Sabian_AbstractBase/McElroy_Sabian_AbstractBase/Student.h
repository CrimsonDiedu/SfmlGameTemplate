#pragma once
#include "Base.h"
class Student :
	public Base
{
public:
	Student(char * n, char * d, unsigned short g, unsigned short l);
	~Student();
	void DisplayRecord();
private:
	const char*name, *degree;
	unsigned short GPA, likeability;

};

