namespace ASD_1;

public abstract class SortingAlgorithm
{
    public int Comparisons
    {
        get;
        protected set;
    }

    public int Swaps
    {
        get;
        protected set;
    }

    public int Operations => Comparisons + Swaps;

    protected abstract void Algorithm(int[] array);

    public abstract string GetName();

    public void Sort(int[] array)
    {
        Comparisons = 0;
        Swaps = 0;
        Algorithm(array);
        if (!IsSorted(array))
        {
            Console.WriteLine("Array is not sorted. Algorithm failed to complete it's task. Your PC will explode in 60 seconds...");
            Console.WriteLine(GetName());
            Array.ForEach(array, el => Console.Write($" {el} "));
            Console.WriteLine();
        }
    }

    private static bool IsSorted(int[] array)
    {
        return IsSorted(array, 0, array.Length - 1);
    }

    public static bool IsSorted(int[] array, int left, int right)
    {
        for (int i = left; i < right; i++)
        {
            if (array[i] > array[i+1])
            {
                Console.WriteLine($"{i}");
                return false;
            }
        }
        return true;
    }
}