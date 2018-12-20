#include "stdafx.h"
#include "AEnemy.h"


AEnemy::AEnemy()
{
}


AEnemy::~AEnemy()
{
}

void AEnemy::GetBaseSet()
{

}

void AEnemy::Move(int px, int py)
{
	if (active)
	{
		xp = x;
		yp = y;

		delay++;
		Update();
		int dis = sqrt((x - px) *(x - px) + (y - py)*(y - py)), spd = 1;
		/**/

		if (dis > Console::WindowWidth() *.52) {
			spd = -spd;
		}

		if (delay % speed == 0)
		{
			if (x < px || ODDS chance == 0) {

				x += spd;
			}
			else if (x > px || ODDS chance == 0) {
				x -= spd;
			}

			if (y < py || ODDS chance == 0) {
				y += spd;
			}
			else if (y > py || ODDS chance == 0) {
				y -= spd;
			}
		}
	}
}

void AEnemy::IncreaseDifficulty()
{
	if (active) {
		chance++;
	}
}

void AEnemy::Update()
{
	SetType(2);

	if (GetCol() == ConsoleColor::DarkGreen) {
		if (seq > 10) {
			seq = 0;
		}elseif(seq == 10) {
			SetCol(ConsoleColor::Green);
		}
	}
}
