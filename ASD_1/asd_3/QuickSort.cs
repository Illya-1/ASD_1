namespace ASD_1.asd_3;

public class QuickSort : SortingAlgorithm
{
    protected override void Algorithm(int[] array)
    {
        Algorithm(array, 0, array.Length - 1);
    }

    public override string GetName()
    {
        return "quick_sort";
    }

    protected virtual void Algorithm(int[] array, int left, int right)
    {
        if (left <= right)
        {
            int pivot = Partition(array, left, right);
            Algorithm(array, left, pivot - 1);
            Algorithm(array, pivot + 1, right);
        }
    }
    
    private int Partition(int[] array, int left, int right)
    {
        int pivot = GetPivot(array, left, right);
        int i = left - 1;
        for (int j = left; j < right; j++)
        {
            Comparisons++;
            if (array[j] < pivot)
            {
                i++;
                (array[i], array[j]) = (array[j], array[i]);
                Swaps++;
            }
        }

        i++;
        (array[i], array[right]) = (array[right], array[i]);
        Swaps++;
        return i;
    }

    protected virtual int GetPivot(int[] array, int left, int right)
    {
        return array[right];
    }
}