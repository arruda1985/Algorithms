using Training.Core.Contracts;

namespace Training.Core.Sorting
{
    public class BubbleSort : ISorting
    {
        public int[] Sorting(List<int> numbers)
        {
            var sortedList = new List<int>();
            var n = numbers.Count;
            var swapped = false;
            for (int i = 0; i < n -1; i++)
            {

                if (numbers[i + 1] > numbers[i])
                {
                    var temp = numbers[i];
                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = temp;
                    swapped = true;
                }

            }

            return [.. sortedList];
        }
    }
}
