using System;

namespace Utility
{
    public class SLL<T> : ILinkedListADT<T>
    {
        private Node<T> head;
        private int count;

        public void Prepend(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = head;
            head = newNode;
            count++;
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
            count++;
        }

        public void InsertAt(T data, int index)
        {
            if (index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException("Invalid index.");
            }

            if (index == 0)
            {
                Prepend(data);
                return;
            }

            Node<T> newNode = new Node<T>(data);
            Node<T> current = head;

            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
            count++;
        }

        public void Set(T data, int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("Invalid index.");
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
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("Invalid index.");
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
            count = 0;
        }

        public int Size()
        {
            return count;
        }

        public T RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException("Invalid index.");
            }

            if (index == 0)
            {
                T removedData = head.Data;
                head = head.Next;
                count--;
                return removedData;
            }

            Node<T> current = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }

            T removedData = current.Next.Data;
            current.Next = current.Next.Next;
            count--;
            return removedData;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }
    }
}
