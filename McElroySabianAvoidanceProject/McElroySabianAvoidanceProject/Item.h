#pragma once
#include "GameObject.h"
class Item :
	public GameObject
{
public:
	Item();
	~Item();

	void Update();

private:
	int seq = 0;
};

