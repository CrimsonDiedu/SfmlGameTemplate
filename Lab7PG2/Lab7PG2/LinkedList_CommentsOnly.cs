using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG2_Day_7
{
	class LinkedList<Type>
	{
		// Nested Node class
		// Nodes need data (the same type as the generic type our class stores, and a next node variable.
			
			// The data itself
			// Whoever comes after... the NEXT entry in the list.


		// Need a head of the list, and a counter for how many nodes we've got.

		public LinkedList()
		{
			// Head should be initalized to null
			// Any count should be zero.
		}

		public void AddHead(Type _data)
		{
			// Create a new node, initialize it with the data
			
			// The new node points to the head as its next node

			// The head becomes the new node

		}

		bool RemoveAt(int _index)
		{
			// Check for out of bounds of our list (less than zero, or more than we have nodes)
				// return false if out of bounds

			// Start at the beginning...
			// Need a current node, and a previous node
			// Proceed through a number of nodes equal to the index - 1 (we need to stop BEFORE the index to remove)
				// updating previous node along the way

			// To "remove" a node, just bypass it; set the previous node's next reference to the current node's next reference
				// return true if successfully removed
		}

		public int Remove(Type _value)
		{
			// Begin at the beginning.
			//Node node = m_Head;	
			//Node previous = null;
			
			// As long as we have a valid node
			
			// Create a next and previous node, to help loop through all the items in our list
			// As long as the current node isn't null...
			
			// Check if the data in the current node is equal to what is being passed in.
					// If so, check for a previous node value of null... If that's the case, we're at the head of the list.
					// Remove nodes the same way as RemoveHead() -- update head to head's next

					// Else, set the previous node's next to the current node's next (to skip over the current node in future iterations)
					

				// If the data is not equal (i.e. this is not the node we're looking for)
					// Set the previous node previous to the current node...
					// The next node visited will use this one as the previous
				
				// Go to the next node to repeat the process
		}

		public bool InsertAt(int index, Type _data)
		{
			// Check for out of bounds of our list (less than zero, or more than we have nodes)

			// Create a new node, initialize with incoming data

			// If the head is null, add the new node as the head and that's it

			// Start at the beginning...
			// Node node = m_Head;
			// Proceed through a number of nodes equal to the index - 1 (we need to stop BEFORE the index to add)
			
			// Our new node's next should be the current node's next
			
			// The current node's next should be our new node.
		}

		// Print all values to the screen.
		public void Print()
		{
			// Begin at the beginning.

			// As long as we have a valid node

				// Do something with it.

				// Update our reference... move on to the next guy

		}
	}
}
