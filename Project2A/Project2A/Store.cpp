#include "stdafx.h"
#include "Store.h"
#include <iostream>

using std::ifstream;

void Store::Load(const char * path)
{
	ifstream file(path);
	char line[70];
	
	unsigned int numItems, cue = 0;
	numItems = (unsigned int)file.get();
	contents.reserve(numItems);//reserve the number of items.

	while (!file.eof()) {//loop through rest of file.
		Item item;
		file.getline(line, 70, '\n');

		for (int i = 0; i < 70; i++) {
			if (line[i] == '\n') {
				break;
			}
			else {
				///read each value from the line
				//type
				while (line[i] != ' ') {
					item.type[i] = line[i];
					++i;
				}
				while (line[i] != ' ') ++i;
				//name
				while (line[i] != ' ') {
					item.type[i] = line[i];
					++i;
				}
				while (line[i] != ' ') ++i;
				//cost


				//weight
			}
		}
	}
	file.close();
}
