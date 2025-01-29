using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Sorting;

namespace Training.Core.Tests.Sorting
{
    public class QuickSortTests
    {

        private readonly QuickSort _sortingClass = new();

        [Fact]
        public void Sorting_PerformanceTest_SmallList()
        {
            var numbers = GenerateRandomList(100); // 100 elementos
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            _sortingClass.Sorting(numbers);
            stopwatch.Stop();

            Assert.True(stopwatch.ElapsedMilliseconds < 50, $"Sorting demorou {stopwatch.ElapsedMilliseconds}ms para uma lista pequena.");
        }

        [Fact]
        public void Sorting_PerformanceTest_LargeList()
        {
            var numbers = GenerateRandomList(100000); 
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            _sortingClass.Sorting(numbers);
            stopwatch.Stop();

            Assert.True(stopwatch.ElapsedMilliseconds < 500, $"Sorting demorou {stopwatch.ElapsedMilliseconds}ms para uma lista grande.");
        }

        [Fact]
        public void Sorting_PerformanceTest_VeryLargeList()
        {
            var numbers = GenerateRandomList(1000000); 
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            _sortingClass.Sorting(numbers);
            stopwatch.Stop();

            Assert.True(stopwatch.ElapsedMilliseconds < 5000, $"Sorting demorou {stopwatch.ElapsedMilliseconds}ms para uma lista muito grande.");
        }

        [Fact]
        public void Sorting_PerformanceTest_VeryVeryLargeList()
        {
            var numbers = GenerateRandomList(100000000);
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            _sortingClass.Sorting(numbers);
            stopwatch.Stop();

            Assert.True(stopwatch.ElapsedMilliseconds < 5000, $"Sorting demorou {stopwatch.ElapsedMilliseconds}ms para uma lista muito grande.");
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
    }
}
