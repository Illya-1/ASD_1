using ASD_1.algorithms;
using ScottPlot;

namespace ASD_1.testing.result_exporters;

public class PlotResults(int from, int to, string algorithmName)
{
    private const string SAVE_DIR_PATH = @"C:\Users\IlyaP\My\programming\C#\ASD_1\results";

    private readonly int _length = to - from + 1;
    private readonly Plot _plot = new();

    public PlotResults AddScatter(Color color, Func<int, int> mathFunction)
    {
        int[] scatterDots = new int[_length];
        int[] elementAmounts = new int[_length];
        for (int i = from; i <= to; i++)
        {
            scatterDots[i-1] = mathFunction.Invoke(i);
            elementAmounts[i-1] = i;
        }

        var scatter = _plot.Add.Scatter(elementAmounts, scatterDots);
        scatter.Color = color;

        return this;
    }

    public PlotResults Add3SetsScatter(SortingAlgorithm sortingAlgorithm)
    {
        AddTestRunScatter(Colors.Blue, sortingAlgorithm, GenType.AVG);
        AddTestRunScatter(Colors.Green, sortingAlgorithm, GenType.SORTED);
        AddTestRunScatter(Colors.Red, sortingAlgorithm, GenType.REVERSED);
        return this;
    }

    public PlotResults AddTestRunScatter(Color color, SortingAlgorithm sortingAlgorithm, GenType genType)
    {
        Console.WriteLine($"Runs test {genType} {sortingAlgorithm.Name}");
        AddScatter(color, (arrLen) =>
        {
            var operationCounter = new OperationCounter();
            sortingAlgorithm.Implementation.Invoke(Datagen.Gen(genType, arrLen), operationCounter);
            return operationCounter.GetTestResult().Operations;
        });
        return this;
    }

    public void Save()
    {
        _plot.Axes.Margins(0, 0, 0, 0);
        string path = Path.Combine(SAVE_DIR_PATH, algorithmName);
        Directory.CreateDirectory(path);
        string filename = $"{algorithmName}_from_{from}_to_{to}_plot.png";
        _plot.SavePng(Path.Combine(path, filename), 1200, 900);
    }
}