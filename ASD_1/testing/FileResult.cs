using ASD_1.datagen;

namespace ASD_1.testing;

public class FileResult(string algorithmName)
{
    private const string SAVE_DIR_PATH = @"C:\Users\IlyaP\My\programming\C#\ASD_1\results";
    private readonly List<string> _data = new();

    public FileResult Add3SetsTestRun(int amountOfElements, SortingAlgorithm sortingAlgorithm)
    {
        AddTestRun(amountOfElements, Datagen.RND_UNIQUE, sortingAlgorithm);
        AddTestRun(amountOfElements, Datagen.SORTED, sortingAlgorithm);
        AddTestRun(amountOfElements, Datagen.REVERSED, sortingAlgorithm);
        return this;
    }

    public FileResult AddTestRun(int amountOfElements, Datagen generator, SortingAlgorithm sortingAlgorithm)
    {
        Console.WriteLine($"Runs test {amountOfElements} {sortingAlgorithm.GetName()}");
        int[] arr = generator.Gen(amountOfElements);
        sortingAlgorithm.Sort(arr);
        _data.Add(
            $"{generator.GetName()}.{amountOfElements}: [{sortingAlgorithm.Operations}, {sortingAlgorithm.Comparisons}, {sortingAlgorithm.Swaps}]"
        );
        return this;
    }

    public void Save()
    {
        _data.Insert(0, $"gen_type. amount_of_elements: [operations, comparisons, swaps]");
        string path = Path.Combine(SAVE_DIR_PATH, algorithmName);
        Directory.CreateDirectory(path);
        string filename = $"exported_data.txt";
        File.WriteAllLines(Path.Combine(path, filename), _data);
    }
}