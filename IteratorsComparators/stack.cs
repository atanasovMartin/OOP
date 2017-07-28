using System;
using System.Collections;
using System.Collections.Generic;

public class Stack<T> : IEnumerable<T>
{
    private T[] elements;

    private const int capacity = 15;

    public Stack()
    {
        this.elements = new T[capacity];
    }

    public int Count { get; set; }

    public int Capacity { get => this.elements.Length; }

    public void Push(T element)
    {
        if (this.Count == Capacity)
        {
            this.Resize();
        }
        this.elements[this.Count] = element;
        this.Count++;
    }

    public T Pop()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("No elements");
        }

        T temp = this.elements[this.Count - 1];
        this.Count--;
        return temp;
    }
    private void Resize()
    {
        Array.Resize(ref this.elements, 2 * this.Count);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.Count - 1; i >= 0; i--)
        {
            yield return this.elements[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

