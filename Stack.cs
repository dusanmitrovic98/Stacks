namespace DataStructures.Collections.Stacks;

public class Stack<T>
{
    private T[] _items;
    private int _size;
    private const int defaultCapacity = 4;

    public Stack()
    {
        _items = new T[defaultCapacity];
    }

    public Stack(int capacity)
    {

    }
}