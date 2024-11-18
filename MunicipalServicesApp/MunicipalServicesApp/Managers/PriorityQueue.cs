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


    // Enqueue method to add a new service request to the queue.
    public void Enqueue(ServiceRequest request)
    {
        _heap.Add(request);
        HeapifyUp(_heap.Count - 1);
    }

    // Dequeue method to remove and return the service request with the highest priority.
    public ServiceRequest Dequeue()
    {
        if (_heap.Count == 0) return null;

        var top = _heap[0];
        _heap[0] = _heap[_heap.Count - 1];
        _heap.RemoveAt(_heap.Count - 1);
        HeapifyDown(0);

        return top;
    }

    // Peek method to return the service request with the highest priority without removing it from the queue.
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

    // Helper method to maintain the heap property by moving the element down the heap.
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


    // Helper method to swap two elements in the heap.
    private void Swap(int i, int j)
    {
        var temp = _heap[i];
        _heap[i] = _heap[j];
        _heap[j] = temp;
    }
}
