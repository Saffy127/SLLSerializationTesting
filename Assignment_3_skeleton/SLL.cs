using System;
//Date Finalized 2023-04-7
/*
The SLL class, implemented by Isaac Saffran, Jesse Taylor, and Seth Djikstra,
is a linked list data structure that follows the specifications of the LinkedListADT interface. 
This class provides functionality for adding, inserting, replacing, and removing items in a linked list.
It also allows users to retrieve items at a specific index or check if an item exists in the list.
The Node class is used to represent the individual nodes of the linked list.
Throughout the implementation, the team ensured that no pre-existing classes, methods, or libraries were used.
 */

namespace Assignment_3_skeleton
{
    public class SLL : LinkedListADT
    {
        private Node head; // The First node in the list.
        private int count; // The number of nodes in the list.
        
        // Initializes a new instance of the SLL class.
        public SLL()
        {
            head = null;
            count = 0;
        }

        // Appends the specified data to the end of the list.
        public void Append(object data)
        {
            // If the list is empty, add the datat as the first node.
            if (IsEmpty())
            {
                head = new Node(data);
            }
            // Otherwise, find the last node and add the data after it.
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node(data);
            }
            count++;
        }

        public void Clear()
        {
            head = null;
            count = 0;
        }

        public bool Contains(object data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Delete(int index)
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("List is empty.");
            }
            Remove(index);
        }

        private void Remove(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index was outside the bounds of the array.");
            }

            if (index == 0)
            {
                head = head.Next;
            }
            else
            {
                Node current = head;
                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;
            }
            count--;
        }

        public int IndexOf(object data)
        {
            Node current = head;
            for (int i = 0; i < count; i++)
            {
                if (current.Data.Equals(data))
                {
                    return i;
                }
                current = current.Next;
            }
            return -1;
        }

        public void Insert(object data, int index)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
            {
                Prepend(data);
            }
            else
            {
                Node current = head;
                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }
                Node newNode = new Node(data);
                newNode.Next = current.Next;
                current.Next = newNode;
                count++;
            }
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Prepend(object data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
            count++;
        }
        
        // Replaces an item at the specified index
        public void Replace(object data, int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Data = data;
        }
        //Retrieves an item at the specified index
        public object Retrieve(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Data;
        }

        public int Size()
        {
            return count;
        }

        private class Node
        {
            public object Data { get; set; }
            public Node Next { get; set; }

            public Node(object data)
            {
                Data = data;
                Next = null;
            }
        }
    }
}

