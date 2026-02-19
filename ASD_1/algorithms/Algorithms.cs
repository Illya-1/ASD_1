namespace ASD_1.algorithms;

public static class Algorithms
{
    public static readonly SortingAlgorithm BUBBLE_SORT = new SortingAlgorithm("bubble_sort",
        (arr, counter) =>
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    counter.IncrementComparisons();
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        counter.IncrementSwaps();
                    }
                }
            }
        });

    public static readonly SortingAlgorithm BUBBLE_SORT_MODIFIED = new SortingAlgorithm("bubble_sort_modified", 
        (arr, counter) =>
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    counter.IncrementComparisons();
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        swapped = true;
                        
                        counter.IncrementSwaps();
                    }
                }

                counter.IncrementComparisons();
                if (!swapped)
                {
                    break;
                }
            }
        });

    public static readonly SortingAlgorithm COMB_SORT = new SortingAlgorithm("comb_sort", (arr, counter) =>
    {
        bool swaped = true;
        int gap = arr.Length;
        while (gap != 1 || swaped)
        {
            swaped = false;
            
            gap = (gap * 10) / 13;
            counter.IncrementComparisons();
            if (gap < 1)
            {
                gap = 1;
            }
            
            for (int i = 0; i < arr.Length - gap; i++)
            {
                counter.IncrementComparisons();
                if (arr[i] > arr[i + gap])
                {
                    (arr[i], arr[i + gap]) = (arr[i + gap], arr[i]);
                    swaped = true;
                    counter.IncrementSwaps();
                }
            }
        }
    });
}