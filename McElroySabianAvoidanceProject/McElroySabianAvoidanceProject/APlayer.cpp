#include "stdafx.h"
#include "APlayer.h"


APlayer::APlayer()
{
}


APlayer::~APlayer()
{
}

void APlayer::Update()
{
	active = true;
	SetType(1);
	GameObject::Update();
	bool rkey, lkey, ukey, dkey;
	rkey = GetAsyncKeyState(VK_RIGHT);
	lkey = GetAsyncKeyState(VK_LEFT);
	ukey = GetAsyncKeyState(VK_UP);
	dkey = GetAsyncKeyState(VK_DOWN);
	if (delay % speed == 0) {
		if (rkey) {
			x++;
		}
		else if (lkey) {
			x--;
		}
		if (dkey) {
			y++;
		}
		else if (ukey) {
			y--;
		}
	}

	if (GetCol() != ConsoleColor::Cyan) {
		if (seq > 20) {
			seq = 0;
		}elseif(seq == 10) {
			SetCol(ConsoleColor::Blue);
		}elseif(seq == 20) {
			SetCol(ConsoleColor::Cyan);
		}
	}
}
