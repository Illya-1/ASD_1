using ASD_1.algorithms;

namespace ASD_1.asd_3;

public class InsertionSort : SortingAlgorithm
{
    protected override void Algorithm(int[] array)
    {
        Algorithm(array, 0, array.Length-1);
    }

    public override string GetName()
    {
        return "insertion_sort";
    }
    
    private void Algorithm(int[] array, int left, int right)
    {
        for (int i = left + 1; i <= right; i++)
        {
            int key = array[i];
            int j = i - 1;
            
            while (j >= left && array[j] > key)
            {
                Comparisons++;
                Swaps++;
                array[j + 1] = array[j];
                j--;
            }
            
            if (j >= left)
            {
                Comparisons++;
            }
            
            array[j + 1] = key;
        }
    }

    public void Sort(int[] array, int left, int right)
    {
        Comparisons = 0;
        Swaps = 0;
        Algorithm(array, left, right);
    }
}