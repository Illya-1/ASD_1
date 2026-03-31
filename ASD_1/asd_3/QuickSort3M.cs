namespace ASD_1.asd_3;

public class QuickSort3M : QuickSort
{
    private readonly InsertionSort _insertionSort = new InsertionSort();
    public override string GetName()
    {
         return "quick_sort_3m";
    }

    protected override void Algorithm(int[] array, int left, int right)
    {
        if (right - left + 1 <= 3)
        {
            _insertionSort.Sort(array, left, right);
            Comparisons += _insertionSort.Comparisons;
            Swaps += _insertionSort.Swaps;
        }
        else
        {
            base.Algorithm(array, left, right);
        }
    }

    protected override int GetPivot(int[] array, int left, int right)
    {
        int middle = (left + right) / 2;
        
        if ((array[middle] > array[left]) ^ (array[middle] > array[right]))
        {
            (array[middle], array[right]) = (array[right], array[middle]);
        }
        else if ((array[left] > array[middle]) ^ (array[left] > array[right]))
        {
            (array[left], array[right]) = (array[right], array[left]);
        }
        
        return array[right];
    }
}