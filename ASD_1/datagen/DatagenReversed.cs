namespace ASD_1.datagen;

public class DatagenReversed : DatagenSorted
{
    public override int[] Gen(int length)
    {
        return base.Gen(length).Reverse().ToArray();
    }

    public override string GetName()
    {
        return "REVERSED";
    }
}