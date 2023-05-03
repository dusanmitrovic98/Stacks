namespace DataStructures.Collections.Stacks;

public class Stack<T>
{
    private T[] _items;
    private int _size;

    public Stack()
    {
        const int defaultCapacity = 4;
        _items = new T[defaultCapacity];
    }

    public Stack(int capacity)
    {

    }
}