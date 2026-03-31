namespace ASD_1.algorithms;

public class CombSort : SortingAlgorithm
{
    protected override void Algorithm(int[] array)
    {
        bool swaped = true;
        int gap = array.Length;
        while (gap != 1 || swaped)
        {
            swaped = false;
            
            gap = (gap * 10) / 13;
            Comparisons++;
            if (gap < 1)
            {
                gap = 1;
            }
            
            for (int i = 0; i < array.Length - gap; i++)
            {
                Comparisons++;
                if (array[i] > array[i + gap])
                {
                    (array[i], array[i + gap]) = (array[i + gap], array[i]);
                    swaped = true;
                    Swaps++;
                }
            }
        }
    }

    public override string GetName()
    {
        return "comb_sort";
    }
}