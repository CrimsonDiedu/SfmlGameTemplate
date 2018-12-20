#pragma once
#include "BaseObject.h"
class PathNode :
	public BaseObject
{
public:
	PathNode();
	~PathNode(); 
	void Update(sf::RenderWindow * _window, PlayerEvent e);
};

