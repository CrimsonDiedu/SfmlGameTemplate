#include "stdafx.h"
#include "TGame.h"


TGame::TGame()
{
	sym = new char;
	
}


TGame::~TGame()
{
	delete sym;
}

void TGame::Update()
{
	while (run) {

	}
}

void TGame::Render()
{
}

void TGame::IncreaseDifficulty()
{
}

void TGame::Start()
{
	
	set.push_back(new GameObject());
	
}

void TGame::Play()
{
}

void TGame::End()
{
	for (int i = 0; i < set.size(); i++) {

	}
}
