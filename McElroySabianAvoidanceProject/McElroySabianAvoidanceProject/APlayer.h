#pragma once
#include "GameObject.h"
class APlayer :
	public GameObject
{
public:
	APlayer();
	~APlayer();

	void Update();
private:
	float lifetime = 0;

};

