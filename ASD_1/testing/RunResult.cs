namespace ASD_1.testing;

public record RunResult(int Comparisons, int Swaps)
{
    public int Operations => Comparisons + Swaps;
};