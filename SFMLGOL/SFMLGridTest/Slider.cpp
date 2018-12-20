#include "stdafx.h"
#include "Slider.h"


Slider::Slider()
{/////////////////////
	vspeed = 0.25f;
	hasGravity = false;
	rect.setFillColor(sf::Color::White);
	shape.setOutlineColor(sf::Color::White);
}

Slider::Slider(sf::RectangleShape _rect)
{
	rect = _rect; 
	rect.setFillColor(sf::Color::White);
	shape.setOutlineColor(sf::Color::White);
}


Slider::~Slider()
{
}

void Slider::Update(sf::RenderWindow * _window, PlayerEvent e)
{
	switch (e) {
	case PlayerEvent::MoveUp:
		velocity.y = -vspeed;
		break;
	case PlayerEvent::S:
		velocity.y = 0;
		break;
	case PlayerEvent::MoveDown:
		velocity.y = vspeed;
		break;
	}
	
	rect.move(0,velocity.y);
	shape.move(0, velocity.y);
}

void Slider::Render(sf::RenderWindow* window)
{
	window->draw(shape);
	window->draw(rect);
}
