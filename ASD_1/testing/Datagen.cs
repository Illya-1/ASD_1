namespace ASD_1.testing;

public static class Datagen
{
    private static int[] GenAvgArray(int length)
    {
        Random random = new Random();
        int[] arr = new int[length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next();
        }
        return arr;
    }

    private static int[] GenSortedArray(int length)
    {
        int[] arr = new int[length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }
        return arr;
    }

    private static int[] GenReversedArray(int length)
    {
        return GenSortedArray(length).Reverse().ToArray();
    }

    public static int[] Gen(GenType genType, int arrLen) => genType switch
    {
        GenType.AVG => GenAvgArray(arrLen),
        GenType.SORTED => GenSortedArray(arrLen),
        GenType.REVERSED => GenReversedArray(arrLen),
        _ => [0]
    };
}