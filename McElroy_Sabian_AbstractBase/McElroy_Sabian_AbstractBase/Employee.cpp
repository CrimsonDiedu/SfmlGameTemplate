#include "stdafx.h"
#include "Employee.h"


Employee::Employee(char * n, char * d, int s)
{
	name = n;
	department = d;
	salary = s;
}


Employee::~Employee()
{

}

void Employee::DisplayRecord() {
	cout << "Name: " << name << "\nDepartment: " << department << "Salary: " << salary;
}