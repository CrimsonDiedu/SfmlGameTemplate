// Program2.2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int pacTime, EasTime;
	bool done;
	cout << "Please enter an hour to convert from Pacific to Eastern:  ";

	cin >> pacTime;
	while (!cin.good()) {
		
		BADINPUT:
		cin.clear();
		cin.ignore(numeric_limits<streamsize>::max(), '\n');
		cout << "That's not an answer I'll accept. Try again. ";
		cin >> pacTime;
	}
	if (!(pacTime < 13 && pacTime > 0) ){
		goto BADINPUT;
	}
	EasTime = pacTime + 3;
	if (EasTime > 12) {
		EasTime -= 12;
	}

	cout << pacTime << " Pacific Time is the same as " << EasTime << " Eastern Time.\n";
	system("pause");
    return 0;
}

