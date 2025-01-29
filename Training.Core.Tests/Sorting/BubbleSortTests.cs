using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Training.Core.Sorting;
using Xunit;

public class BubbleSortTests
{
    private readonly BubbleSort _sortingClass = new();

    [Fact]
    public void Sorting_ShouldSortCorrectly_SmallList()
    {
        var numbers = GenerateRandomList(100);
        var result = _sortingClass.Sorting(numbers);

        Assert.True(IsSorted(result), "The list is not sorted correctly.");
    }

    [Fact]
    public void Sorting_ShouldSortCorrectly_LargeList()
    {
        var numbers = GenerateRandomList(10000);
        var result = _sortingClass.Sorting(numbers);

        Assert.True(IsSorted(result), "The list is not sorted correctly.");
    }

    [Fact]
    public void Sorting_PerformanceTest_SmallList()
    {
        var numbers = GenerateRandomList(100);
        var stopwatch = new Stopwatch();

        stopwatch.Start();
        var result = _sortingClass.Sorting(numbers);
        stopwatch.Stop();

        Assert.True(stopwatch.ElapsedMilliseconds < 50, $"Sorting took {stopwatch.ElapsedMilliseconds}ms for a small list.");
        Assert.True(IsSorted(result), "The list is not sorted correctly.");
    }

    [Fact]
    public void Sorting_PerformanceTest_LargeList()
    {
        var numbers = GenerateRandomList(10000);
        var stopwatch = new Stopwatch();

        stopwatch.Start();
        var result = _sortingClass.Sorting(numbers);
        stopwatch.Stop();

        Assert.True(stopwatch.ElapsedMilliseconds < 500, $"Sorting took {stopwatch.ElapsedMilliseconds}ms for a large list.");
        Assert.True(IsSorted(result), "The list is not sorted correctly.");
    }


    private List<int> GenerateRandomList(int size)
    {
        var random = new Random();
        var list = new List<int>(size);
        for (int i = 0; i < size; i++)
        {
            list.Add(random.Next(-1000000, 1000000));
        }
        return list;
    }

    private bool IsSorted(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                return false;
            }
        }
        return true;
    }
}
