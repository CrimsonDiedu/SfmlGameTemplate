#pragma once
#include "BaseObject.h"
class Ball :
	public BaseObject
{
	float bounce_factor;
	int trail_amount, trail_rarity;
public:
	Ball();
	~Ball();
	std::vector<sf::CircleShape> shapes;
	
	void Update(sf::RenderWindow * _window, PlayerEvent e);
	void Render(sf::RenderWindow* window);
};

