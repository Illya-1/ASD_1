namespace ASD_1.datagen;

public class DatagenRndUnique : Datagen
{
    public override int[] Gen(int length)
    {
        HashSet<int> set = new HashSet<int>();
        while (set.Count < length)
        {
            set.Add(Random.Shared.Next());
        }
        return set.ToArray();
    }

    public override string GetName()
    {
        return "RND_UNIQUE";
    }
}