using Training.Core.Contracts;

namespace Training.Core.Sorting
{
    public class BubbleSort : ISorting
    {
        public int[] Sorting(List<int> numbers)
        {
            var n = numbers.Count;
            for (int i = 0; i < n -1; i++)
            {

                if (numbers[i + 1] > numbers[i])
                {
                    var temp = numbers[i];
                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = temp;
                }
            }

            return [.. numbers];
        }
    }
}
