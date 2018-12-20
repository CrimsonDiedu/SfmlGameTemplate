#include "stdafx.h"
#include "Ball.h"


Ball::Ball()
{
	canCollide = true;
	hasGravity = false;
	step = 0;
	bounce_factor = 0.5f;
	trail_amount = 20;
	trail_rarity = 12;
}


Ball::~Ball()
{
}


void Ball::Update(sf::RenderWindow * _window, PlayerEvent e)
{
	if (hasGravity)
		velocity.y += 9.8f*0.0001f;
#pragma region Input
if (takesInput) {
	if (e != PlayerEvent::None) {
		switch (e) {
		case PlayerEvent::Jump:
			velocity.y = -0.4f;
			break;
		case PlayerEvent::MoveRight:
			velocity.x += hspeed;
			break;
		case PlayerEvent::MoveLeft:
			velocity.x -= hspeed;
			break;
		case PlayerEvent::Grow:
			//shape.scale(scaleup, scaleup);
			shape.setRadius(shape.getRadius()*scaleup);
			break;
		case PlayerEvent::Shrink:
			//shape.scale(scaledown, scaledown);
			shape.setRadius(shape.getRadius()*scaledown);
			break;
		case PlayerEvent::Freeze:
			velocity.x = 0.f;
			velocity.y = 0.f;
			break;
		}

	}
}
#pragma endregion
	//////////////////////////////////////////////////////////////////////lock within the window
	if (step % trail_rarity == 0 && trail_amount>0){
		/*
		BaseObject *p = new PathNode();
		p->setPosition(shape.getPosition());
		Game::GetInstance()->AddObject(p);
		printf("Created PathNode\n");
		
		*/
		//^^^created pathnodes on heap that slowed down program
		sf::Vector2f size(2.f, 20.f),spawnpos;
		sf::CircleShape line = sf::CircleShape(shape.getRadius());
		spawnpos = shape.getPosition();/*
		spawnpos.x += shape.getRadius();
		spawnpos.y += shape.getRadius();
*/
		line.setPosition(spawnpos);
		float x1, x2, y1, y2;
		x1 = getPosition().x;
		y1 = getPosition().y;
		x2 = velocity.x;
		y2 = velocity.y;
		float angle;
		float dot = x1 * x2 + y1 * y2;		
		float det = x1 * y2 - y1 * x2;		
		angle = atan2(det, dot);			

		//line.setRotation((angle*3.14f) * 180);
		line.setFillColor(sf::Color::White);
		line.setOutlineColor(sf::Color::Green);
		shapes.push_back(line);
		if (shapes.size() > trail_amount) {
			shapes.erase(shapes.begin());
		}
	}
	step++;

	if (shape.getPosition().x < 0) {
		shape.setPosition(0, shape.getPosition().y);
		velocity.x = -velocity.x;
	}
	if (shape.getPosition().x > 1028 - shape.getRadius() * 2) {
		shape.setPosition(1028 - shape.getRadius() * 2, shape.getPosition().y);
		velocity.x = -velocity.x;
	}
	if (shape.getPosition().y < 0) {
		shape.setPosition(shape.getPosition().x, 0);
		velocity.y = -(velocity.y*0.4f);
	}
	if (shape.getPosition().y > 1028 - shape.getRadius() * 2) {
		shape.setPosition(shape.getPosition().x, 1028 - shape.getRadius() * 2);
		velocity.y = -(velocity.y*bounce_factor);
	}

	shape.move(velocity);
	hasCollided = false;
}

void Ball::Render(sf::RenderWindow * window)
{
	if (shapes.size() != 0) {
		for (int i = 0; i < shapes.size() - 1; i++) {
			float scl = (float)i / (float)shapes.size();
			shapes[i].setScale(scl,scl);
			window->draw(shapes[i]);
		}
	}
	BaseObject::Render(window);
}
