using System;

namespace Assignment_3_skeleton
{
    public class SLL : LinkedListADT
    {
        private Node head;
        private int count;

        public SLL()
        {
            head = null;
            count = 0;
        }

        public void Append(object data)
        {
            Append((User)data);
        }

        public void Append(User data)
        {
            if (IsEmpty())
            {
                head = new Node(data);
            }
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
            return Contains((User)data);
        }

        public bool Contains(User data)
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
            Remove(index);
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
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
            return IndexOf((User)data);
        }

        public int IndexOf(User data)
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
            Insert((User)data, index);
        }

        public void Insert(User data, int index)
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
            Prepend((User)data);
        }

        public void Prepend(User data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
            count++;
        }

        public void Replace(object data, int index)
        {
            Replace((User)data, index);
        }

        public void Replace(User data, int index)
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



        public User RetrieveUser(int index)
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
            return current.Data;
        }

        public int Size()
        {
            return count;
        }

        private class Node
        {
            public User Data { get; set; }
            public Node Next { get; set; }

            public Node(User data)
            {
                Data = data;
                Next = null;
            }
        }
    }
}

