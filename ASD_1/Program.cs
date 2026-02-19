using ASD_1.algorithms;
using ASD_1.testing;
using ASD_1.testing.result_exporters;
using ScottPlot;

namespace ASD_1;

static class Program
{
    static void Main(string[] args)
    {
        int runFrom = 1;
        int runTo = 1500;
        
        new PlotResults(runFrom, runTo, Algorithms.BUBBLE_SORT.Name)
            .Add3SetsScatter(Algorithms.BUBBLE_SORT)
            .AddScatter(Colors.Yellow, (x) => x)
            .AddScatter(Colors.Purple, (x) => x*x)
            .Save();
        
        new PlotResults(runFrom, runTo, Algorithms.BUBBLE_SORT_MODIFIED.Name)
            .Add3SetsScatter(Algorithms.BUBBLE_SORT_MODIFIED)
            .AddScatter(Colors.Yellow, (x) => x)
            .AddScatter(Colors.Purple, (x) => x*x)
            .Save();
        
        new PlotResults(runFrom, runTo, Algorithms.COMB_SORT.Name)
            .Add3SetsScatter(Algorithms.COMB_SORT)
            .AddScatter(Colors.Yellow, (x) => x)
            .AddScatter(Colors.Purple, (x) => x*x)
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