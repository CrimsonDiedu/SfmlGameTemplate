// SFMLGridTest.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

#include "Game.h"
void Pause()
{
	printf("Press Enter to continue\n");
	getchar();
}
int main(int argc, char**argv)
{
	int ballstospawn = -1;
	sf::RenderWindow window(sf::VideoMode(1028, 1028), "SFML App");
	static Game *g = Game::GetInstance(&window);
	if (argc == 2)
		g->SetBallsToSpawn(atoi(argv[1]));
	g->Play();
	delete g;
	
    return 0;
}

