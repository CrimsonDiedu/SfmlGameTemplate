// CppProgram2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int age;
	cout << "How old are you?  ";
	cin >> age;
	while (!cin.good()) {
		cin.clear();
		cin.ignore(numeric_limits<streamsize>::max(), '\n');
		cout << "That's not an answer I'll accept. Try again. ";
		cin >> age;
	}
	if (age < 16)
	{
		cout << "You must be older to play.";
		//goto END;
	}
	else if (age < 25)
	{
		cout << "No matter where you go, you have to be asked for \nID because of your babyface.";
		//goto END;
	}
	else if (age < 50)
	{
		cout << "You are one semicolon away from a mid-life crisis";
		//
	}
	else
	{
		cout << "You've past the half century mark,\nI'm proud of you.";//\nand your 9th suicide attempt failed. \nIt must suck to suck. . .";
		//goto END;
	}

	END:
	cout << '\n';
	system("pause");
    return 0;
}

