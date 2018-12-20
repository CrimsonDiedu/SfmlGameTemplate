#include "stdafx.h"
#include "Item.h"


Item::Item()
{
}


Item::~Item()
{
}

void Item::Update()
{
	active = true;
	SetType(3);
	GameObject::Update();
	seq++;
	switch (seq % 8) {
	case 0:
		SetSym('O');
		break;
	case 1:
		SetSym(')');
		break;
	case 2:
		SetSym('O');
		break;
	case 3:
		SetSym('(');
		break;
	default:
		break;
	}
}
