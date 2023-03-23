namespace Utility
{
    public interface ILinkedListADT<T>
    {
        void Prepend(T data);
        void Append(T data);
        void InsertAt(T data, int index);
        void Set(T data, int index);
        T Get(int index);
        int IndexOf(T data);
        bool Contains(T data);
        void Clear();
        int Size();
        T RemoveAt(int index);
    }
}
