namespace ASD_1.algorithms;

public delegate void Algorithm(int[] array, OperationCounter operationCounter);

public record SortingAlgorithm(string Name, Algorithm Implementation);