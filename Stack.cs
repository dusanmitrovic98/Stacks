namespace DataStructures.Collections.Stacks;

public class Stack<T>
{
    private T[] _items;
    private int _size;
    private const int DEFAULT_CAPACITY = 4;

    public int Count => _size;

    public Stack()
    {
        _items = new T[DEFAULT_CAPACITY];
    }

    public Stack(int capacity)
    {
        _items = new T[capacity];
    }
}