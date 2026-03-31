using ASD_1.datagen;
using ScottPlot;

namespace ASD_1.testing;

public class PlotResults(int from, int to, string algorithmName)
{
    private const string SAVE_DIR_PATH = @"C:\Users\IlyaP\My\programming\C#\ASD_1\results";

    private readonly int _length = to - from + 1;
    private readonly Plot _plot = new();

    public PlotResults AddScatter(Color color, Func<int, int> mathFunction)
    {
        int[] yDots = new int[_length]; //y
        int[] xDots = new int[_length]; //x
        for (int i = from; i <= to; i++)
        {
            yDots[i-1] = mathFunction.Invoke(i);
            xDots[i-1] = i;
        }
        var scatter = _plot.Add.Scatter(xDots, yDots);
        scatter.Color = color;

        return this;
    }

    public PlotResults Add3SetsScatter(SortingAlgorithm sortingAlgorithm)
    {
        AddTestRunScatter(Colors.Blue, sortingAlgorithm, Datagen.RND_UNIQUE);
        AddTestRunScatter(Colors.Green, sortingAlgorithm, Datagen.SORTED);
        AddTestRunScatter(Colors.Red, sortingAlgorithm, Datagen.REVERSED);
        return this;
    }

    public PlotResults AddTestRunScatter(Color color, SortingAlgorithm sortingAlgorithm, Datagen generator)
    {
        Console.WriteLine($"Runs test {sortingAlgorithm.GetName()}");
        AddScatter(color, (arrLen) =>
        {
            sortingAlgorithm.Sort(generator.Gen(arrLen));
            return sortingAlgorithm.Operations;
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