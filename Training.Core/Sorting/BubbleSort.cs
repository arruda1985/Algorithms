using Training.Core.Contracts;

namespace Training.Core.Sorting
{
    public class BubbleSort : ISorting
    {
        public int[] Sorting(List<int> numbers)
        {
            var n = numbers.Count;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        var temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            return [.. numbers];
        }
    }
}
