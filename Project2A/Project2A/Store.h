#pragma once

#include <fstream>

#pragma region DynArray
template<typename Type>
class DynArray
{
	Type * array;
	unsigned int Size, Capacity;

public:
	/////////////////////////////////////////////////////////////////////////////
	// Function :	Constructor
	// Notes : Constructs an empty array (Size 0 Capacity 0)
	/////////////////////////////////////////////////////////////////////////////
	DynArray()
	{
		array = nullptr;
		Size = Capacity = 0;
	}

	/////////////////////////////////////////////////////////////////////////////
	// Function :	Destructor
	// Notes : cleans up any dynamic memory
	/////////////////////////////////////////////////////////////////////////////
	~DynArray()
	{
		delete[] array;
	}

	/////////////////////////////////////////////////////////////////////////////
	// Function :	Copy Constructor
	/////////////////////////////////////////////////////////////////////////////
	DynArray(const DynArray<Type>& that)
	{
		array = nullptr;
		*this = that;
	}

	/////////////////////////////////////////////////////////////////////////////
	// Function :	Assignment Operator
	/////////////////////////////////////////////////////////////////////////////
	DynArray<Type>& operator=(const DynArray<Type>& that)
	{
		if (this != &that)
		{
			delete[] array;
			Size = that.Size;
			Capacity = that.Capacity;

			array = new Type[Capacity];

			for (unsigned int i = 0; i < Size; ++i)
				array[i] = that.array[i];

		}

		return *this;
	}

	/////////////////////////////////////////////////////////////////////////////
	// Function : operator[]
	// Parameters : index - the index to access
	// Return : Type & - returns the array element at [index]
	// Notes : performs no error checking. user should ensure index is 
	//		valid with the size() method
	/////////////////////////////////////////////////////////////////////////////
	Type& operator[](const unsigned int index)
	{
		return array[index];
	}

	/////////////////////////////////////////////////////////////////////////////
	// Function : operator[]
	// Parameters : index - the index to access
	// Return : const Type & - returns the array element at [index]
	// Notes : performs no error checking. user should ensure index is 
	//		valid with the size() method
	/////////////////////////////////////////////////////////////////////////////
	const Type& operator[](const unsigned int index) const
	{
		return array[index];
	}

	/////////////////////////////////////////////////////////////////////////////
	// Function :	size
	// Returns : int - returns the number of items being stored
	// Notes : this function returns the number of items being stored, 
	/////////////////////////////////////////////////////////////////////////////
	unsigned int size() const
	{
		return Size;
	}

	/////////////////////////////////////////////////////////////////////////////
	// Function : capacity
	// Returns : int - returns the number of items the array can store before 
	//		the next resize
	// Notes : this function returns the number of items the array can store, 
	//		not the number of bytes
	/////////////////////////////////////////////////////////////////////////////
	unsigned int capacity() const
	{
		return Capacity;
	}

	/////////////////////////////////////////////////////////////////////////////
	// Function :	clear
	// Notes : cleans up any dynamic memory and resets size and capacity to 0
	/////////////////////////////////////////////////////////////////////////////
	void clear()
	{
		delete[] array;
		array = nullptr;
		Size = Capacity = 0;
	}

	/////////////////////////////////////////////////////////////////////////////
	// Function : append
	// Parameters : item - the item to be appended to the next open spot
	// Notes : this function will append the item to the next open spot. if 
	//		no room exists, the array's capacity will be doubled and then 
	//		the item will be added
	/////////////////////////////////////////////////////////////////////////////
	void append(const Type& item)
	{
		if (Size == Capacity)
		{
			reserve();
		}

		array[Size++] = item;

	}

	/////////////////////////////////////////////////////////////////////////////
	// Function : reserve
	// Parameters : newCap - the new capacity
	// Notes : 	- default parameter - reserve more space in the array, based on //		the expansion rate (100%, 1 minimum).
	//		- non-default parameter, expand to the specified capacity
	//		- if newCap is LESS than the current capacity, do nothing. 
	//		This function should NOT make the array smaller.
	/////////////////////////////////////////////////////////////////////////////
	void reserve(const unsigned int & newCap = 0)
	{
		if (newCap <= Capacity && newCap > 0)
		{
			return;
		}

		else if (0 == newCap)
		{
			if (0 == Capacity)
			{
				Capacity = 1;
			}
			else
			{
				//Capacity <<= 1;
				Capacity *= 2;
			}
		}

		else
			Capacity = newCap;


		Type* temp = new Type[Capacity];
		for (unsigned int i = 0; i < Size; ++i)
		{
			temp[i] = array[i];
		}

		delete[] array;
		array = temp;
	}

};


#pragma endregion


struct Item
{
	char type[16];
	char name[16];
	unsigned int cost;
	unsigned int weight;
};


class Store
{
	DynArray<Item> contents;
public:
	void Load(const char * path);
	void SortByType();
	void SortByName();
	void SortByPrice();
	void SortByWeight();
	void Display();
	bool Search(const char * name);
};

