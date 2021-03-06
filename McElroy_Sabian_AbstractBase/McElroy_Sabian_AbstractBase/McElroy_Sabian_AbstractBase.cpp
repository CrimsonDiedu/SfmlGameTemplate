// McElroy_Sabian_AbstractBase.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <Windows.h>
/*
Rule of Three
____+__+_____
Destructor - delete any newed mem

= Operator - handle any newing/deleting

Copy Constructor

//add record

//manage records

Employee * e = dynamic_cast<Employee*> v[i]//vector index i;

Student * s = dynamic_cast<Student*> v[i]//vector index i;

*/
using std::system;


int main()
{
	// vector of Base pointers
	vector<Base*> records;
	enum state {
		main,
		add,
		a_student,
		a_employee,
		manage,
		end
	};
	state st = state::main;
	bool enabled = true, pressed = false;
	char * tName, *tDepartment;
	char  *tDegree, tn[32], td[32];
	unsigned short gpa, likeability;

	tName = tn;
	tDegree = td;
	tDepartment = td;
	unsigned short salary;
	while (enabled) {
		////display menu
		system("cls");
		if (GetAsyncKeyState(VK_ESCAPE)) {
			st = state::end;
		}
		if (!pressed) {
			switch (st) {
			case end:
				enabled = false;
				break;
			case main:
				cout << "F1 - Add Record.\nF2 - Show Records\nEsc - close.";
				if (GetAsyncKeyState(VK_F1)) {
					st = state::add;
					pressed = true;
				}
				break;
			case add:
				cout << "What type of record to add?\nF1 - Student\nF2 - Employee";
				if (GetAsyncKeyState(VK_F1)) {
					st = state::a_student;
					pressed = true;
				}
				if (GetAsyncKeyState(VK_F2)) {
					st = state::a_employee;
					pressed = true;
				}
				
				break;
			case a_student:

				
				cout << "enter the student's name\n";
				cin.getline(tName,32,'\n');
				if (!cin.good()) {
					cin.clear();
					cin.ignore(1000, '\n');
					break;
				}
				cout << "enter the student's degree program\n";
				cin.getline(tDegree, 32, '\n');
				if (!cin.good()) {
					cin.clear();
					cin.ignore(1000, '\n');
					break;
				}
				cout << "enter the student's current GPA\n";
				cin >> gpa;
				if (!cin.good()) {
					cin.clear();
					cin.ignore(1000, '\n');
					break;
				}
				if (gpa > 4 || gpa < 0) {
					cout << "gpa must be between 0 and 4";
					break;
				}
				cout << "enter the student's likeability rating\n";
				cin >> likeability;
				if (!cin.good()) {
					cin.clear();
					cin.ignore(1000, '\n');
					break;
				}
				records.push_back(new Student(tName, tDegree, gpa, likeability));
				st = state::main;
				break;
			case a_employee:
				
				cout << "enter the employee's name\n";
				cin.getline(tName, 32, '\n');
				if (!cin.good()) {
					cin.clear();
					cin.ignore(1000, '\n');
					break;
				}
				cout << "enter the employee's department\n";
				cin.getline(tDepartment, 32, '\n');
				if (!cin.good()) {
					cin.clear();
					cin.ignore(1000, '\n');
					break;
				}
				cout << "enter the employee's salary\n";
				cin >> salary;
				if (!cin.good()) {
					cin.clear();
					cin.ignore(1000, '\n');
					break;
				}

				records.push_back(new Employee(tName, tDepartment, salary));
				st = state::main;
				break;

				system("pause");
				system("cls");
			}
		}
		else {
			cout << "button pressed\n______________________________";
			if (!(GetAsyncKeyState(VK_F1) || GetAsyncKeyState(VK_F2) || GetAsyncKeyState(VK_F3) || GetAsyncKeyState(VK_ESCAPE))) {
				pressed = false;
			}
		}
	}
    return 0;
}

