using ASD_1.testing;

namespace ASD_1.algorithms;

public class OperationCounter
{
    private int _comparisonCounter = 0;
    private int _swapCounter = 0;

    public int GetSwapCounter()
    {
        return _swapCounter;
    }

    public int GetComparisonCounter()
    {
        return _comparisonCounter;
    }

    public RunResult GetTestResult()
    {
        return new RunResult(_comparisonCounter, _swapCounter);
    }

    public void IncrementComparisons()
    {
        _comparisonCounter++;
    }

    public void IncrementSwaps()
    {
        _swapCounter++;
    }
}