using ASD_1.algorithms;
using ASD_1.testing;
using ScottPlot;

namespace ASD_1.asd_1;

public static class MainCode
{
    public static void Run()
    {
        int runFrom = 1;
        int runTo = 1000;
        
        new PlotResults(runFrom, runTo, "bubble_sort")
            .Add3SetsScatter(new BubbleSort())
            .AddScatter(Colors.Yellow, (x) => x)
            //.AddScatter(Colors.Purple, (x) => x*x)
            .Save();
        
        new PlotResults(runFrom, runTo, "bubble_sort_modified")
            .Add3SetsScatter(new BubbleSortModified())
            //.AddScatter(Colors.Yellow, (x) => x)
            //.AddScatter(Colors.Purple, (x) => x*x)
            .Save();
        
        new PlotResults(runFrom, runTo, "comb_sort")
            .Add3SetsScatter(new CombSort())
            //.AddScatter(Colors.Yellow, (x) => x)
            //.AddScatter(Colors.Purple, (x) => x*x)
            .Save();

        // new FileResult(Algorithms.BUBBLE_SORT.Name)
        //     .Add3SetsTestRun(10, Algorithms.BUBBLE_SORT)
        //     .Add3SetsTestRun(100, Algorithms.BUBBLE_SORT)
        //     .Add3SetsTestRun(1000, Algorithms.BUBBLE_SORT)
        //     .Add3SetsTestRun(5000, Algorithms.BUBBLE_SORT)
        //     .Add3SetsTestRun(10000, Algorithms.BUBBLE_SORT)
        //     .Add3SetsTestRun(20000, Algorithms.BUBBLE_SORT)
        //     .Add3SetsTestRun(50000, Algorithms.BUBBLE_SORT)
        //     .Save();
        //
        // new FileResult(Algorithms.BUBBLE_SORT_MODIFIED.Name)
        //     .Add3SetsTestRun(10, Algorithms.BUBBLE_SORT_MODIFIED)
        //     .Add3SetsTestRun(100, Algorithms.BUBBLE_SORT_MODIFIED)
        //     .Add3SetsTestRun(1000, Algorithms.BUBBLE_SORT_MODIFIED)
        //     .Add3SetsTestRun(5000, Algorithms.BUBBLE_SORT_MODIFIED)
        //     .Add3SetsTestRun(10000, Algorithms.BUBBLE_SORT_MODIFIED)
        //     .Add3SetsTestRun(20000, Algorithms.BUBBLE_SORT_MODIFIED)
        //     .Add3SetsTestRun(50000, Algorithms.BUBBLE_SORT_MODIFIED)
        //     .Save();
        //
        // new FileResult(Algorithms.COMB_SORT.Name)
        //     .Add3SetsTestRun(10, Algorithms.COMB_SORT)
        //     .Add3SetsTestRun(100, Algorithms.COMB_SORT)
        //     .Add3SetsTestRun(1000, Algorithms.COMB_SORT)
        //     .Add3SetsTestRun(5000, Algorithms.COMB_SORT)
        //     .Add3SetsTestRun(10000, Algorithms.COMB_SORT)
        //     .Add3SetsTestRun(20000, Algorithms.COMB_SORT)
        //     .Add3SetsTestRun(50000, Algorithms.COMB_SORT)
        //     .Save();
    }
}