#pragma once

class BaseObject;
class Game;

class Game
{
	enum GameType {
		ballhouse,
		pong,
		grid
	};
	GameType gameMode;
	double time_set, timeUpdate, dT;
	void Update();
	void Render();
	//void Start(sf::RenderWindow * _window);
	void StartBallHouse(sf::RenderWindow * _window);
	void StartPong(sf::RenderWindow * _window);
	void Exit();
	bool running; 
	bool permaJump;
	int step,initialBalls;
	sf::RenderWindow *window;
	
	std::vector<BaseObject*> Objects;
	std::vector<BaseObject*> queuedObjects;
	Game();

	static Game * instance;
public:
	~Game();

	static void AddObject(BaseObject* object);
	void RemoveObject(int id,BaseObject* b);
	void Play();

	void SetBallsToSpawn(int count);
	// Provides access to this singleton
	static Game * GetInstance(sf::RenderWindow * _window);
	static Game * GetInstance();


};


/*
class Singleton
{
private:
-- Here will be the instance stored. 
static Singleton* instance;

-- Private constructor to prevent instancing. --
Singleton();

	public:
		-- Static access method. --
		static Singleton* getInstance();
}; 
*/


/*
Singleton* Singleton::instance = 0;

Singleton* Singleton::getInstance()
{
if (instance == 0)
{
instance = new Singleton();
}

return instance;
}
*/