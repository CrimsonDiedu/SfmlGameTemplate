#include "stdafx.h"
#include "GameObject.h"


GameObject::GameObject()
{
	x = 1;
	y = 1;
	xp = 1;
	yp = 1;
	hp = 3;
	seq = 0;
	score = 0;

}


GameObject::~GameObject()
{
}

void GameObject::SetObj(int px, int py, int s)
{
	x = px;
	y = py;
	speed = s;
}

void GameObject::SetCol(ConsoleColor col)
{
	c = col;
}

ConsoleColor GameObject::GetCol()
{
	return c;
}

void GameObject::Move(int px, int py)
{

}

void GameObject::Hurt()
{
	hp--;
}

void GameObject::Heal(int h)
{
	hp += h;
}

void GameObject::Rpos()
{
	x = rand() % Console::WindowWidth();
	y = rand() % Console::WindowHeight();
	if (GetCol() == ConsoleColor::Green)
	{
		SetCol(ConsoleColor::DarkGreen);
	}
}

int GameObject::GetX()
{
	return x;
}

int GameObject::GetY()
{
	return y;
}

int GameObject::GetHP()
{
	return hp;
}

int GameObject::GetScore()
{
	return score;
}

void GameObject::Update()
{
	xp = x;
	yp = y;
	delay++;
	seq++;
	interacted = false;
}

void GameObject::Render()
{
	if (active)
	{
		Console::Lock(true);
		if (x < 1) { x = Console::WindowWidth() - 1; }
		if (x > Console::WindowWidth() - 1) { x = 1; }
		if (y < 4) { y = Console::WindowHeight() - 1; }
		if (y > Console::WindowHeight() - 1) { y = 4; }

		if (x > 0 && x < Console::WindowWidth() &&
			y > 0 && y < Console::WindowHeight())
		{
			int xx = Console::CursorLeft(), yy = Console::CursorTop();
			Console::SetCursorPosition(x, y);
			Console::ForegroundColor(c);
			cout << sym;

			if (xp != x || yp != y) {
				Console::SetCursorPosition(xp, yp);
				cout << ' ';
			}
			Console::Lock(false);
			//Console::SetCursorPosition(xx, yy);
			Console::ResetColor;
		}
	}
	else {
		Console::SetCursorPosition(xp, yp);
		cout << ' ';
	}
}

bool GameObject::Alive()
{
	return (hp > 0);
}

void GameObject::SetSym(char c)
{
	sym = c;
}

void GameObject::AddPoints(int p)
{
	score += p;
}

void GameObject::SetType(int t)
{
	type = t;
}
