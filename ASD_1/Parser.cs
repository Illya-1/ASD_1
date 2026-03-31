namespace ASD_1;

public static class Parser
{
    public static int[] FromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);
        int arrLen = int.Parse(lines[0]);

        int[] array = new int[arrLen];
        for (int i = 1; i < lines.Length; i++)
        {
            array[i - 1] = int.Parse(lines[i]);
        }
        return array;
    }

    public static void ToFile(string file, int[] array)
    {
        throw new NotImplementedException();
    }
}