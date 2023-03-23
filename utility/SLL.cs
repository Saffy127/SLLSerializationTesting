using System;

namespace Utility
{
    public class SLL<T> : ILinkedListADT<T>
    {
        private Node<T> head;
        private int size;

        public SLL()
        {
            head = null;
            size = 0;
        }

        public void Prepend(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = head;
            head = newNode;
            size++;
        }

        public void Append(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (IsEmpty())
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            size++;
        }

        public void InsertAt(T data, int index)
        {
            if (index < 0 || index > size)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }

            if (index == 0)
            {
                Prepend(data);
            }
            else
            {
                Node<T> newNode = new Node<T>(data);
                Node<T> current = head;

                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                newNode.Next = current.Next;
                current.Next = newNode;
                size++;
            }
        }

        public void Set(T data, int index)
        {
            if (index < 0 || index >= size)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }

            Node<T> current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Data = data;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }

            Node<T> current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Data;
        }

        public int IndexOf(T data)
        {
            int index = 0;
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return index;
                }
                index++;
                current = current.Next;
            }
            return -1;
        }

        public bool Contains(T data)
        {
            return IndexOf(data) != -1;
        }

        public void Clear()
        {
            head = null;
            size = 0;
        }

        public int Size()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public T RemoveAt(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }

            if (index == 0)
            {
                T removedData = head.Data;
                head = head.Next;
                size--;
                return removedData;
            }

            Node<T> current = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }

            T removedData = current.Next.Data;
            current.Next = current.Next.Next;
            size--;
            return removedData;
        }
    }
}
