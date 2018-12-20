#pragma once
#include "stdafx.h"

class GameObject
{
public:
	GameObject();
	~GameObject();

	int delay, speed, type;
	bool interacted, active;

	void SetObj(int px, int py, int s);
	void SetCol(ConsoleColor col);
	ConsoleColor GetCol();


	virtual void Move(int px, int py);
	void Hurt();
	void Heal(int h);
	void Rpos();
	int GetX();
	int GetY();
	int GetHP();
	int GetScore();
	virtual void Update();
	void Render();
	bool Alive();
	void SetSym(char c);
	void AddPoints(int p);
	void SetType(int t);
protected:
	int x, y, xp, yp, hp, seq;
	float score;
private:
	char sym = 'm';
	ConsoleColor c;
};

