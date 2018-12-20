#pragma once

class BaseObject
{
protected:
	enum PlayerEvent {
		None,
		Jump,
		MoveRight,
		MoveLeft,
		Grow,
		Shrink, 
		Freeze,
		MoveUp,
		MoveDown,
		W,
		S,
		X,


	};

	friend class Game;
	sf::CircleShape shape;
	sf::RectangleShape rect;
	sf::Vector2f velocity;
	void Create(float rad, float _x, float _y);
	float hspeed, vspeed, scaleup,scaledown, deflection_force;
	bool hasGravity,canCollide, hasCollided, takesInput;
	int step,id;
public:
	BaseObject();
	BaseObject(float _x, float _y);
	~BaseObject();

	virtual void Update(sf::RenderWindow * _window, PlayerEvent e);
	virtual void Render(sf::RenderWindow* window);
	void RemoveFromGame();

	void SetColor(sf::Color col);
	void setPosition(sf::Vector2f pos);
	void setPosition(float X, float Y);
	void setGravity(bool gravity);
	void setID(int _id);


	sf::Vector2f getPosition();

};

