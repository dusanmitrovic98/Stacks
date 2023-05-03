namespace DataStructures.Collections.Stacks;

public class Stack<T>
{
    private T[] _items;
    private int _size;
    private const int DEFAULT_CAPACITY = 4;

    public int Count
    {
        get { return this._size; }
    }

    public Stack()
    {
        _items = new T[DEFAULT_CAPACITY];
    }

    public Stack(int capacity)
    {
        _items = new T[capacity];
    }

    public void Push(T item)
    {
        if (_size == _items.Length)
            // EnsureCapacity(_size + 1);
    }

    public T Pop()
    {
        if (_size == 0)
            throw new InvalidOperationException("Stack is empty");

        T item = _items[--_size];
        _items[_size] = default(T);

        return item;
    }

    public T Peek()
    {
        if (_size == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return _items[_size - 1];
    }
}