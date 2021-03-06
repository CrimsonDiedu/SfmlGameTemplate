// McElroy_Sabian_BitMani.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <Windows.h>
#include <bitset>
#include <algorithm>

using namespace std;






COORD position;
bool run = true;
int _myNum, _myBit;

#pragma region Bits

int TurnOn(int num, int bit) {
	int temp = 1 << bit;
	num |= temp;
	return num;
}

int TurnOff(int num, int bit) {
	int temp = (1 << bit);
	temp = ~temp;
	num &= temp;
	return num;
}
//val = value | i << bitnum;
int Toggle(int num,int bit) {
	num ^= (1 << bit);
	return num;
}
int ShiftRight(int n) {
	return TurnOff((n >> 1),31);
}
int ShiftLeft(int n) {
	return TurnOff((n << 1), 31);
}
int Negate(int n) {

	n = TurnOff(~n, 31);
	return (n);
}
void PrintBin(int n) {
	int i = 0;
	//position.X = i;
	position.Y = 0;
	
	

	while (i < 8) {
		position.X = 8-(i);
		SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), position);
		if (n > 0){
			cout << (n % 2);
		}
		else {
			cout << 0;
		}
		n = n >> 1;
		i++;
	}


	//Gav
	HANDLE out = GetStdHandle(STD_OUTPUT_HANDLE);
	CONSOLE_CURSOR_INFO     cursorInfo;

	GetConsoleCursorInfo(out, &cursorInfo);
	cursorInfo.bVisible = false; // set the cursor visibility
	SetConsoleCursorInfo(out, &cursorInfo);
	//saved by the Gavin
	position.X = 16;
	position.Y = 0;
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), position);
	cout << " Number is: " << _myNum << ".\t\t\t\n\t\t Bit is: " << _myBit << ".";

	//
	cout << "     \n";
	position.X = (7-_myBit);
	position.Y = 1;
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), position);
	cout << " ^ ";
	//position.Y++;
	cout << '\n';
	
	cout << "F1 - Turn Bit On.\nF2 - Turn Bit Off.\nF3 - Toggle Bit.\nF4 - Negate All Bits.\nF5 - Shift Bits Left\nF6 - Shift Bits Right.\n\nArrowKeys - Move Left/Right.";
	
}

#pragma endregion

void Update() {
	bool on, off, toggle, neg, lsh, rsh, lb, rb,end;

	on = GetAsyncKeyState(VK_F1);
	off = GetAsyncKeyState(VK_F2);
	toggle = GetAsyncKeyState(VK_F3);
	neg = GetAsyncKeyState(VK_F4);
	lsh = GetAsyncKeyState(VK_F5);
	rsh = GetAsyncKeyState(VK_F6);
	lb = (GetAsyncKeyState(VK_RIGHT));
	rb = (GetAsyncKeyState(VK_LEFT));
	end = (GetAsyncKeyState(VK_ESCAPE));

	if (rb && _myBit < 7) {
		_myBit++;
	}
	else if (lb && _myBit > 0) {
		_myBit--;
	}

	if (on) { _myNum = TurnOn(_myNum, _myBit);}
	else if (off) { _myNum = TurnOff(_myNum, _myBit); }
	else if (toggle) { _myNum = Toggle(_myNum, _myBit); }
	else if (neg) { _myNum = Negate(_myNum); }
	else if (lsh) {
		_myNum = ShiftLeft(_myNum);
	}
	else if(rsh){
		_myNum = ShiftRight(_myNum);
	}
	
	if (end) {
		run = false;
	}
}

int main()
{
	_myNum = 26;
	_myBit = 0;
	position.Y = 0;
	int Len = 9, slp = 20;
	
	//65
	//00000000
	//01000001
	while (run == true) {
		Update();
		PrintBin(_myNum);
		Sleep(100);
	}
	cout << '\n';
	system("pause");
    return 0;

}

/* |0x0|
int value = 0000 0000
loop ( ) {
int temp = value
temp >> i
*/

