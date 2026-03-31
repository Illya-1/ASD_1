namespace ASD_1.datagen;

public class DatagenRnd : Datagen
{
    public override int[] Gen(int length)
    {
        int[] arr = new int[length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Random.Shared.Next();
        }
        return arr;
    }

    public override string GetName()
    {
        return "RND";
    }
}