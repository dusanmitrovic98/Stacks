﻿namespace DataStructures.Collections.Stacks;

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

    public T Peek()
    {
        if (_size == 0)
            throw new InvalidOperationException("Stack is empty");

        return _items[_size - 1];
    }
}