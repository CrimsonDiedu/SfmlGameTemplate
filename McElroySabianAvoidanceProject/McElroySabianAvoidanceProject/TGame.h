#pragma once
#include "stdafx.h"
#include "GameObject.h"
class TGame
{
public:
	TGame();
	~TGame();
	bool run;
	char * sym;
	//object vector
	vector<GameObject*> set;

	void Update();
	void Render();
	void IncreaseDifficulty();

	void Start();
	void Play();
	void End();

};

