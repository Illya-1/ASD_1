namespace ASD_1.algorithms;

public class BubbleSort : SortingAlgorithm
{
    protected override void Algorithm(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                Comparisons++;
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    Swaps++;
                }
            }
        }
    }

    public override string GetName()
    {
        return "bubble_sort";
    }
}