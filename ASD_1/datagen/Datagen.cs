namespace ASD_1.datagen;

public abstract class Datagen
{
    public abstract int[] Gen(int length);

    public abstract string GetName();

    public static readonly Datagen RND = new DatagenRnd();
    public static readonly Datagen RND_UNIQUE = new DatagenRndUnique();
    public static readonly Datagen SORTED = new DatagenSorted();
    public static readonly Datagen REVERSED = new DatagenReversed();
}