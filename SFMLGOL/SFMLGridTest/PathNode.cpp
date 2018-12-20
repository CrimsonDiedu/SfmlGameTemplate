#include "stdafx.h"
#include "PathNode.h"


PathNode::PathNode()
{
	canCollide = false;
	shape.setScale(0.7f, 0.7f);
}


PathNode::~PathNode()
{
	delete &shape;
}

void PathNode::Update(sf::RenderWindow * _window, PlayerEvent e)
{
	sf::Vector2f scale(0.998f,0.998f);
	shape.scale(scale);
	if (shape.getScale().x < 0.01f) {
		//remove me;TODO
		RemoveFromGame();
		
		
	}
}
