using ASD_1.algorithms;

namespace ASD_1.testing.result_exporters;

public class FileResult(string algorithmName)
{
    private const string SAVE_DIR_PATH = @"C:\Users\IlyaP\My\programming\C#\ASD_1\results";
    private readonly List<string> _data = new();

    public FileResult Add3SetsTestRun(int amountOfElements, SortingAlgorithm sortingAlgorithm)
    {
        AddTestRun(amountOfElements, GenType.AVG, sortingAlgorithm);
        AddTestRun(amountOfElements, GenType.SORTED, sortingAlgorithm);
        AddTestRun(amountOfElements, GenType.REVERSED, sortingAlgorithm);
        return this;
    }

    public FileResult AddTestRun(int amountOfElements, GenType genType, SortingAlgorithm sortingAlgorithm)
    {
        Console.WriteLine($"Runs test {amountOfElements} {genType} {sortingAlgorithm.Name}");
        var opCounter = new OperationCounter();
        int[] arr = Datagen.Gen(genType, amountOfElements);
        sortingAlgorithm.Implementation.Invoke(arr, opCounter);
        _data.Add(
            $"{genType.ToString()}.{amountOfElements}: [{opCounter.GetTestResult().Operations}, {opCounter.GetTestResult().Comparisons}, {opCounter.GetTestResult().Swaps}]"
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