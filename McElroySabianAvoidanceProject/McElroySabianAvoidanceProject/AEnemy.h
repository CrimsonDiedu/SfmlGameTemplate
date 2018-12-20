#pragma once
#include "GameObject.h"
class AEnemy :
	public GameObject
{
public:
	AEnemy();
	~AEnemy();

	GameObject *O;

	void GetBaseSet();

	void Move(int px, int py);

	void IncreaseDifficulty();

	void Update();

private:
	int pause = 0, seq = 0, chance = 3;
};

