// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;



int main()
{
//2.3
#if 0
int i,score = 0,response;
	
//Question 1.
cout << "Question 1: 'elseif' is a keyword in C++: ";
response = GetResponse();
if (response == 1) {
	score += AddScore();
}
else {
	Lose();
}

//Question 2.
cout << "Question 2: Algorithms are usually written in any one specific language: ";
response = GetResponse();
if (response == 0) {
	score += AddScore();
}
else {
	Lose();
}

//Question 3.
cout << "Question 3: A switch's 'default' handles any unmatched values: ";
response = GetResponse();
if (response == 1) {
	score += AddScore();
}
else {
	Lose();
}

cout << "Final Score: " << score << " of 3.\n";

return 0;
#endif

//2.4
#if 1
cout << "Please enter an even Number: ";


#endif



		
cin.get();
}



//2.4