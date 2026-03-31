namespace ASD_1.datagen;

public class DatagenSorted : Datagen
{
    public override int[] Gen(int length)
    {
        int[] arr = new int[length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }
        return arr;
    }

    public override string GetName()
    {
        return "SORTED";
    }
}