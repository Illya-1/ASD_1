namespace ASD_1.algorithms;

public class BubbleSortModified : SortingAlgorithm
{
    protected override void Algorithm(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                Comparisons++;
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    swapped = true;

                    Swaps++;
                }
            }

            Comparisons++;
            if (!swapped)
            {
                break;
            }
        }
    }

    public override string GetName()
    {
        return "bubble_sort_modified";
    }
}