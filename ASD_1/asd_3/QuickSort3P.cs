namespace ASD_1.asd_3;

public class QuickSort3P : SortingAlgorithm
{
    private readonly InsertionSort _insertionSort = new InsertionSort();
    protected override void Algorithm(int[] array)
    {
        Algorithm(array, 0, array.Length - 1);
    }

    public override string GetName()
    {
        return "quick_sort_3p";
    }

    private void Algorithm(int[] array, int left, int right)
    {
        if (right - left + 1 <= 3)
        {
            _insertionSort.Sort(array, left, right);
            Swaps += _insertionSort.Swaps;
            Comparisons += _insertionSort.Comparisons;
        }
        else
        {
            var (pivotLeft, pivotMid, pivotRight) = Partition(array, left, right);
            Algorithm(array, left, pivotLeft - 1);//1
            Algorithm(array, pivotLeft + 1, pivotMid - 1);
            Algorithm(array, pivotMid + 1, pivotRight - 1);//2
            Algorithm(array, pivotRight + 1, right);
        }
    }

    private (int, int, int) Partition(int[] array, int left, int right)
    {
        // Require: A[left] < A[left+1] < A[right]
        if (array[left] > array[left + 1]) (array[left], array[left + 1]) = (array[left + 1], array[left]);
        if (array[left + 1] > array[right]) (array[left + 1], array[right]) = (array[right], array[left + 1]);
        if (array[left] > array[left + 1]) (array[left], array[left + 1]) = (array[left + 1], array[left]);
        

        // 2: a <- left + 2, b <- left + 2
        int leftPtr = left + 2;
        int leftScan = left + 2;

        // 3: c <- right - 1, d <- right - 1
        int rightScan = right - 1;
        int rightPtr = right - 1;

        // 4: p <- A[left], q <- A[left + 1], r <- A[right]
        int pivotLeft = array[left];
        int pivotMid = array[left + 1];
        int pivotRight = array[right];

        // 5: while b <= c do
        while (leftScan <= rightScan)
        {
            // 6: while A[b] < q and b <= c do
            while (leftScan <= rightScan && array[leftScan] < pivotMid)
            {
                Comparisons++;
                // 7: if A[b] < p then
                Comparisons++;
                if (array[leftScan] < pivotLeft)
                {
                    // 8: SWAP(A[a], A[b]), 9: a <- a + 1
                    Swaps++;
                    (array[leftPtr], array[leftScan]) = (array[leftScan], array[leftPtr]);
                    leftPtr++;
                }
                // 11: b <- b + 1
                leftScan++;
            }
            Comparisons++;

            // 13: while A[c] > q and b <= c do
            while (leftScan <= rightScan && array[rightScan] > pivotMid)
            {
                Comparisons++;
                // 14: if A[c] > r then
                Comparisons++;
                if (array[rightScan] > pivotRight)
                {
                    // 15: SWAP(A[c], A[d]), 16: d <- d - 1
                    Swaps++;
                    (array[rightScan], array[rightPtr]) = (array[rightPtr], array[rightScan]);
                    rightPtr--;
                }
                // 18: c <- c - 1
                rightScan--;
            }
            Comparisons++;

            // 20: if b <= c then
            if (leftScan <= rightScan)
            {
                // 21: if A[b] > r then
                Comparisons++;
                if (array[leftScan] > pivotRight)
                {
                    // 22: if A[c] < p then
                    Comparisons++;
                    if (array[rightScan] < pivotLeft)
                    {
                        // 23: SWAP(A[b], A[a]), SWAP(A[a], A[c]), 24: a <- a + 1
                        Swaps += 2;
                        (array[leftScan], array[leftPtr]) = (array[leftPtr], array[leftScan]);
                        (array[leftPtr], array[rightScan]) = (array[rightScan], array[leftPtr]);
                        leftPtr++;
                    }
                    else
                    {
                        // 26: SWAP(A[b], A[c])
                        Swaps++;
                        (array[leftScan], array[rightScan]) = (array[rightScan], array[leftScan]);
                    }
                    // 28: SWAP(A[c], A[d])
                    Swaps++;
                    (array[rightScan], array[rightPtr]) = (array[rightPtr], array[rightScan]);
                    // 29: b <- b + 1, c <- c - 1, d <- d - 1
                    leftScan++; rightScan--; rightPtr--;
                }
                else
                {
                    // 31: if A[c] < p then
                    Comparisons++;
                    if (array[rightScan] < pivotLeft)
                    {
                        // 32: SWAP(A[b], A[a]), SWAP(A[a], A[c]), 33: a <- a + 1
                        Swaps += 2;
                        (array[leftScan], array[leftPtr]) = (array[leftPtr], array[leftScan]);
                        (array[leftPtr], array[rightScan]) = (array[rightScan], array[leftPtr]);
                        leftPtr++;
                    }
                    else
                    {
                        // 35: SWAP(A[b], A[c])
                        Swaps++;
                        (array[leftScan], array[rightScan]) = (array[rightScan], array[leftScan]);
                    }
                    // 37: b <- b + 1, c <- c - 1
                    leftScan++; rightScan--;
                }
            }
        }

        // 41: a <- a - 1, b <- b - 1, c <- c + 1, d <- d + 1
        leftPtr--; leftScan--; rightScan++; rightPtr++;

        // 42: SWAP(A[left + 1], A[a]), SWAP(A[a], A[b])
        Swaps += 2;
        (array[left + 1], array[leftPtr]) = (array[leftPtr], array[left + 1]);
        (array[leftPtr], array[leftScan]) = (array[leftScan], array[leftPtr]);

        // 43: a <- a - 1
        leftPtr--;

        // 44: SWAP(A[left], A[a]), SWAP(A[right], A[d])
        Swaps += 2;
        (array[left], array[leftPtr]) = (array[leftPtr], array[left]);
        (array[right], array[rightPtr]) = (array[rightPtr], array[right]);
        
        // [left...a-1], [a+1...b-1], [b+1...d-1], [d+1...right]
        return (leftPtr, leftScan, rightPtr);
    }
}