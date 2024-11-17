using MunicipalServicesApp.Models;
using System.Collections.Generic;

public class PriorityQueue
{
    private List<ServiceRequest> _heap;

    public PriorityQueue()
    {
        _heap = new List<ServiceRequest>();
    }

    public int Count => _heap.Count; // Count property to get the number of elements in the queue.

    public void Enqueue(ServiceRequest request)
    {
        _heap.Add(request);
        HeapifyUp(_heap.Count - 1);
    }

    public ServiceRequest Dequeue()
    {
        if (_heap.Count == 0) return null;

        var top = _heap[0];
        _heap[0] = _heap[_heap.Count - 1];
        _heap.RemoveAt(_heap.Count - 1);
        HeapifyDown(0);

        return top;
    }

    private void HeapifyUp(int index)
    {
        while (index > 0)
        {
            int parentIndex = (index - 1) / 2;
            if (_heap[index].Priority >= _heap[parentIndex].Priority) break;

            Swap(index, parentIndex);
            index = parentIndex;
        }
    }

    private void HeapifyDown(int index)
    {
        int lastIndex = _heap.Count - 1;

        while (index < lastIndex)
        {
            int leftChildIndex = 2 * index + 1;
            int rightChildIndex = 2 * index + 2;
            int smallestIndex = index;

            if (leftChildIndex <= lastIndex && _heap[leftChildIndex].Priority < _heap[smallestIndex].Priority)
                smallestIndex = leftChildIndex;

            if (rightChildIndex <= lastIndex && _heap[rightChildIndex].Priority < _heap[smallestIndex].Priority)
                smallestIndex = rightChildIndex;

            if (smallestIndex == index) break;

            Swap(index, smallestIndex);
            index = smallestIndex;
        }
    }

    private void Swap(int i, int j)
    {
        var temp = _heap[i];
        _heap[i] = _heap[j];
        _heap[j] = temp;
    }
}
