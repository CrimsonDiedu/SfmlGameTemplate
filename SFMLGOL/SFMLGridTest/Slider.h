#pragma once
#include "BaseObject.h"
class Slider :
	public BaseObject
{
public:
	Slider();
	Slider(sf::RectangleShape _rect);
	~Slider();

	void Update(sf::RenderWindow * _window, PlayerEvent e);
	void Render(sf::RenderWindow* window);

};

