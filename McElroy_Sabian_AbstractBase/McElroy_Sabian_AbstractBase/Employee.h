#pragma once
#include "Base.h"
class Employee :
	public Base
{
public:
	Employee(char * n, char * d, int s);
	~Employee();

	void DisplayRecord();

private:
	const char *name, *department;
	long salary;
};

