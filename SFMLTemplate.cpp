// SFMLGridTest.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <thread>
#include <stdio.h>
#include <stdlib.h> 
#include <string>

#include<SFML\Graphics.hpp>
void Pause()
{
	printf("Press Enter to continue\n");
	getchar();
}
float xforce = 0.1f, yforce = 0.3f/10;
int main(int argv, char ** argc)
{
	sf::RenderWindow window(sf::VideoMode(1028,1028), "SFML App");
	sf::CircleShape shape(100);
	shape.setRadius(64);
	shape.setFillColor(sf::Color::Cyan);
	while (window.isOpen()) {
		sf::Event evente;
		while (window.pollEvent(evente)) {
			if (evente.type == sf::Event::Closed) {
				//
				window.close();
			}
		}
		//update things that change per frame
		//Circle Bounds Floating//////////////////////////////
		sf::Vector2f pos;
		if (shape.getPosition().x < 0 || shape.getPosition().x > 1028-128) {
			xforce = -xforce;
		}
		pos.y = yforce;
		if (shape.getPosition().y < 0 || shape.getPosition().y > 1028-128) {
			yforce = -yforce;
		}
		pos.x = xforce;
		
		shape.move(pos);
		//END///////////////////////////////////////////
		//clear previous window
		window.clear();
		//render all things that will be displayed
		window.draw(shape);
		//draw the final render
		window.display();
	}
    return 0;
}

