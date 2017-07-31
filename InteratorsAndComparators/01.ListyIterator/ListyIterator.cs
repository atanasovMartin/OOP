using System;
using System.Collections;
using System.Collections.Generic;

public class ListyIterator<T> : IEnumerable<T>
{
    private int currentIndex;
    private IList<T> dataList;

    public ListyIterator(IEnumerable<T> items)
    {
        this.currentIndex = 0;

        this.dataList = new List<T>(items);
    }

    public bool Move()
    {
        if (this.currentIndex < this.dataList.Count - 1)
        {
            this.currentIndex++;

            return true;
        }
        return false;
    }
    public bool HasNext()
    {
        if (this.currentIndex < this.dataList.Count - 1)
        {
            return true;
        }

        return false;

    }
    public T Print()
    {
        if (this.dataList.Count == 0)
        {
            throw new ArgumentException("Invalid operation");
        }

        return this.dataList[currentIndex];


    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (T item in this.dataList)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

