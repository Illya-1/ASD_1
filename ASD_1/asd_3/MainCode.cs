using ASD_1.datagen;
using ASD_1.testing;
using ScottPlot;

namespace ASD_1.asd_3;

public static class MainCode
{
    private const string DATA_EXAMPLES_PATH = "C:\\Users\\IlyaP\\My\\programming\\C#\\ASD_1\\task_03_data_examples";
    private const string FILE = "/input_11_1000.txt";
    public static void Run()
    {
        QuickSort quickSort = new QuickSort();
        QuickSort3M quickSort3M = new QuickSort3M();
        QuickSort3P quickSort3P = new QuickSort3P();

        // quickSort.Sort(GetArr());
        // quickSort3M.Sort(GetArr());
        // quickSort3P.Sort(GetArr());
        //
        // Console.WriteLine($"File: {FILE}");
        // Console.WriteLine($"{quickSort.Comparisons} {quickSort3M.Comparisons} {quickSort3P.Comparisons}");

        // new PlotResults(1, 500, quickSort.GetName())
        //     .Add3SetsScatter(quickSort)
        //     //.AddScatter(Colors.Purple, x => x*x)
        //     .AddScatter(Colors.Yellow, x => x * (int)Math.Log2(x))
        //     .Save();
        //
        // new PlotResults(1, 500, quickSort3M.GetName())
        //     .Add3SetsScatter(quickSort3M)
        //     //.AddScatter(Colors.Purple, x => x*x)
        //     .AddScatter(Colors.Yellow, x => x * (int)Math.Log2(x))
        //     .Save();
        //
        // new PlotResults(1, 500, quickSort3P.GetName())
        //     .Add3SetsScatter(quickSort3P)
        //     //.AddScatter(Colors.Purple, x => x*x)
        //     .AddScatter(Colors.Yellow, x => x * (int)Math.Log(x, 4))
        //     .Save();
        //
        // new PlotResults(1, 5000, quickSort.GetName())
        //     .AddTestRunScatter(Colors.Blue, quickSort, new DatagenRndUnique())
        //     .AddScatter(Colors.Yellow, x => x * (int)Math.Log2(x))
        //     .Save();
        //
        // new PlotResults(1, 5000, quickSort3M.GetName())
        //     .Add3SetsScatter(quickSort3M)
        //     .AddScatter(Colors.Yellow, x => x * (int)Math.Log2(x))
        //     .Save();
        //
        // new PlotResults(1, 5000, quickSort3P.GetName())
        //     .AddTestRunScatter(Colors.Blue, quickSort3P, new DatagenRndUnique())
        //     .AddScatter(Colors.Yellow, x => x * (int)Math.Log2(x))
        //     .Save();
        
        new FileResult(quickSort.GetName())
            .Add3SetsTestRun(10, quickSort)
            .Add3SetsTestRun(100, quickSort)
            .Add3SetsTestRun(1000, quickSort)
            .Add3SetsTestRun(5000, quickSort)
            .Add3SetsTestRun(10000, quickSort)
            //.Add3SetsTestRun(20000, quickSort)
            //.Add3SetsTestRun(50000, quickSort)
            .Save();
        
        new FileResult(quickSort3M.GetName())
            .Add3SetsTestRun(10, quickSort3M)
            .Add3SetsTestRun(100, quickSort3M)
            .Add3SetsTestRun(1000, quickSort3M)
            .Add3SetsTestRun(5000, quickSort3M)
            .Add3SetsTestRun(10000, quickSort3M)
            .Add3SetsTestRun(20000, quickSort3M)
            .Add3SetsTestRun(50000, quickSort3M)
            .Save();
        
        new FileResult(quickSort3P.GetName())
            .Add3SetsTestRun(10, quickSort3P)
            .Add3SetsTestRun(100, quickSort3P)
            .Add3SetsTestRun(1000, quickSort3P)
            .Add3SetsTestRun(5000, quickSort3P)
            .Add3SetsTestRun(10000, quickSort3P)
            .Add3SetsTestRun(20000, quickSort3P)
            //.Add3SetsTestRun(50000, quickSort3P)
            .Save();
    }

    private static int[] GetArr()
    {
        return Parser.FromFile(DATA_EXAMPLES_PATH + FILE);
    }
}