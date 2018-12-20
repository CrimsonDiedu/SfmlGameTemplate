#include "stdafx.h"


Game* Game::instance = 0;

void Game::Update()
{
	time_t timer;
	struct tm y2k = { 0 };

	y2k.tm_hour = 0;   y2k.tm_min = 0; y2k.tm_sec = 0;
	y2k.tm_year = 100; y2k.tm_mon = 0; y2k.tm_mday = 1;

	time(&timer);

	dT = difftime(timer, mktime(&y2k));
	//dT = time - timeUpdate;

	/*
	sf::CircleShape shape(100);
	shape.setRadius(64);
	shape.setFillColor(sf::Color::Cyan);
	*/
	BaseObject::PlayerEvent ev = BaseObject::PlayerEvent::None;
	sf::Event evente;
	while (window->pollEvent(evente)) {
		switch (evente.type) {
		case sf::Event::Closed:
			window->close();
			running = false;
			break;
		case sf::Event::KeyPressed:
			switch (evente.key.code) {
			case sf::Keyboard::Space:
				ev = BaseObject::PlayerEvent::Jump;
				break;
			case sf::Keyboard::A:
				ev = BaseObject::PlayerEvent::MoveLeft;
				break;
			case sf::Keyboard::D:
				ev = BaseObject::PlayerEvent::MoveRight;
				break;
			case sf::Keyboard::Q:
				ev = BaseObject::PlayerEvent::Grow;
				break;
			case sf::Keyboard::E:
				ev = BaseObject::PlayerEvent::Shrink;
				break;
			case sf::Keyboard::F:
				ev = BaseObject::PlayerEvent::Freeze;
				break;
			case sf::Keyboard::W:
				ev = BaseObject::PlayerEvent::MoveUp;
				break;
			case sf::Keyboard::S:
				ev = BaseObject::PlayerEvent::MoveDown;
				break;
			case sf::Keyboard::X:
				ev = BaseObject::PlayerEvent::X;
				break;

			case sf::Keyboard::Up:
				ev = BaseObject::PlayerEvent::MoveUp;
				break;
			case sf::Keyboard::Down:
				ev = BaseObject::PlayerEvent::MoveDown;
				break;
			case sf::Keyboard::Escape:

				window->close();
				running = false;
				break;
			}


			break;
		}
	}
	step++;
	BaseObject *oi,* oj;
	//add any objects that were created last frame and stored in the queue
	int queue_length = (int)queuedObjects.size();
	if (queue_length > 0) {
		printf("Adding Objects from creation queue: %d total\n", queue_length);

		while (queue_length > 0) {
			BaseObject * object = queuedObjects[queue_length - 1];
			Objects.push_back(object);
			object->setID((int)instance->Objects.size());
			queuedObjects.pop_back();
			queue_length--;
			printf("%d Remaining.\n", queue_length);
			if (queue_length == 0) {
				break;
			}
		}
	}
	//begin update loop
	for (int i = 0; i < Objects.size(); i++) {
		oi = Objects[i];
		//begin collision loop
		if (oi->canCollide && !oi->hasCollided) {
			for (int j = 0; j < Objects.size(); j++) {
				oj = Objects[j];
				if (i != j && oj->canCollide && !oi->hasCollided) {
					if (oi->shape.getGlobalBounds().intersects(oj->shape.getGlobalBounds())) {
						sf::Vector2f force = (oi->shape.getPosition()) - (oj->shape.getPosition());
						force *= 0.001f*oi->deflection_force;
						oi->velocity.x += force.x;
						oi->velocity.y += force.y;
						oi->hasCollided = true;
					}
				}
			}
		}
		if(ev == BaseObject::PlayerEvent::Jump)
			ev = ev;
		if (step == 30) {
			printf("\n");
		}
		if (Objects[i]->takesInput) {
			Objects[i]->Update(window, ev);
		}
		else {
			Objects[i]->Update(window, BaseObject::PlayerEvent::None);
		}
		if (i < 0) 
			i = (int)Objects.size() - 1;
		if (i > Objects.size()) 
			i = (int)Objects.size() - 2;
		if (i == Objects.size())
			break;
	}
}

void Game::Render()
{
	for (int i = 0; i < Objects.size(); i++) {
		Objects[i]->Render(window);
	}
}


void Game::Exit()
{
	for (int i = 0; i < Objects.size(); i++) {
		delete Objects[i]; 
	}
}

Game::Game()
{
	initialBalls = 5;
}


Game::~Game()
{
}

void Game::AddObject(BaseObject * object)
{
	Game::GetInstance();
	if (instance == NULL) {
		printf("Could not add Object. Game Instance was null. deleting.\n");
		delete object;
		return;
	}
	instance->queuedObjects.push_back(object);
}

void Game::RemoveObject(int id,BaseObject* b)
{
	//id = (int)Objects.size() - id;TODO
	if (id < Objects.size() && id >0) {
		BaseObject * deleted = Objects[id - 1];
		Objects.erase(Objects.begin() + id - 1);
		delete deleted;
	}

}

void Game::StartBallHouse(sf::RenderWindow * _window)
{
	window = _window;
	running = true;
	permaJump = false;
	step = 0;
	for (int i = 0; i < initialBalls; i++)
	{
		BaseObject* b = new Ball();
		Objects.push_back(b);
		if (i % 4 == 0)
			Objects[i]->velocity.x = 0;// 0.04f;

		switch (i % 4) {
		case 1:
			Objects[i]->SetColor(sf::Color::Color(255, 256, 128));
			break;
		case 2:
			Objects[i]->SetColor(sf::Color::Color(255, 128, 64));
			break;
		case 3:
			Objects[i]->SetColor(sf::Color::Color(255, 64, 32));
			break;
		case 4:
			Objects[i]->SetColor(sf::Color::Yellow);
			break;
		case 5:
			Objects[i]->SetColor(sf::Color::Color(255, 0, 0));
			break;
		default:
			//Objects[i]->SetColor(sf::Color::Black);
			break;
		}

		//1D offset = index * sizeof(Type)
		//2D offset = ((row*number of columns) + column) * sizeof(Type)

		float window_width = (float)window->getSize().x,
			window_height = (float)window->getSize().y,
			col = (float)((i + 1) % initialBalls);
		//b->setPosition((((float)(i + 1) *ww)/ww), 0.0f);
		sf::Vector2f pos(0.0f, 0.0f);
		pos.x = ((float)(i + 1) / initialBalls)*window_width;
		b->setPosition(pos);
		b->setGravity(true);
	}
}

void Game::StartPong(sf::RenderWindow * _window)
{
	window = _window;
	running = true;
	permaJump = false;
	step = 0;

	BaseObject* b;

		sf::RectangleShape rect();
		sf::Vector2u wsize = window->getSize();
	//for (int i = 0; i < 3; i++) {
		b = new Ball();

		b->hasGravity = false;
		b->shape.setFillColor(sf::Color::White);
		b->setPosition(wsize.x / 2, wsize.y / 2);
		b->velocity.x = 0.5;
		Objects.push_back(b);
	//}

		sf::Vector2f size(24.f, 100.f);
		b = new Slider();
		b->rect.setSize(size);
		b->shape.setOutlineColor(sf::Color::White);
		b->rect.setFillColor(sf::Color::White);
		b->rect.setOutlineColor(sf::Color::White);
		b->takesInput = true;
		//b->setPosition(((float)i / 3.f)*wsize.x, (float)wsize.y / 2.f);
		b->setPosition(64, 512);
		b->rect.setPosition(b->getPosition());
		Objects.push_back(b);

}

void Game::Play()
{
	void(Game::*Start)(sf::RenderWindow *);
	//start_function(window);
	switch (gameMode) {
		case GameType::ballhouse:
			Start = &Game::StartBallHouse;
		break;
		case GameType::pong:
			Start = &Game::StartPong;
			break;
	}
	//Start(window);
	StartPong(window);
	while (running) {
		while (window->isOpen()) {
			//update things that change per frame
			Update();
			//clear previous window
			window->clear();
			//render all things that will be displayed
			Render();
			//draw the final render
			window->display();
		}
	}

	Exit();
}

void Game::SetBallsToSpawn(int count)
{
	initialBalls = count;
}

Game * Game::GetInstance(sf::RenderWindow * _window)
{
	if (instance == nullptr) {
		instance = new Game();
	}
	instance->window = _window;
	return instance;
}

Game * Game::GetInstance()
{
	if (instance == 0) {
		instance = new Game();
	}
	return instance;
}
