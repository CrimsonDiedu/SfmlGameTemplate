#include "stdafx.h"
#include "BaseObject.h"

void BaseObject::Create(float rad,float _x,float _y)
{
	shape.setRadius(rad);
	
	shape.setPosition(sf::Vector2f(_x, _y));

	
	shape.setFillColor(sf::Color::Transparent);
	hspeed = 0.025f;
	scaleup = 1.2f;
	scaledown = 0.8f;
	hasCollided = false;
	hasGravity = false;
	takesInput = false;
	deflection_force = 1;
}

BaseObject::BaseObject()
{
	Create(10.f, 0, 0);
}

BaseObject::BaseObject(float _x, float _y)
{
	Create(10.f, _x, _y);
}


BaseObject::~BaseObject()
{
}

void BaseObject::Update(sf::RenderWindow * _window, PlayerEvent e) 
{

}

void BaseObject::Render(sf::RenderWindow* window)
{
	window->draw(shape);
	
}

void BaseObject::RemoveFromGame()
{
	Game::GetInstance()->RemoveObject(id, this);
}

void BaseObject::SetColor(sf::Color col)
{
	shape.setFillColor(col);
}

void BaseObject::setPosition(sf::Vector2f pos)
{
	shape.setPosition(pos);
}

void BaseObject::setPosition(float X, float Y)
{
	shape.setPosition(X, Y);
	rect.setPosition(X, Y);
}

void BaseObject::setGravity(bool gravity)
{
	hasGravity = gravity;
}

void BaseObject::setID(int _id)
{
	id = _id;
}

sf::Vector2f BaseObject::getPosition()
{
	return shape.getPosition();
}

