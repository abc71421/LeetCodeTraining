namespace CSharp.No417;

public static class No417Inputs
{
    private static readonly int[][] Example1 = {
        new[] { 1, 2, 2, 3, 5 },
        new[] { 3, 2, 3, 4, 4 },
        new[] { 2, 4, 5, 3, 1 },
        new[] { 6, 7, 1, 4, 5 },
        new[] { 5, 1, 1, 2, 4 },
    };

    private static readonly int[][] Data1 = {
        new[] {10,10,10 },
        new[] { 10,1,10 },
        new[] { 10,10,10 },
    };

    internal static List<int[][]> Args1 = new() {Example1,Data1 };

}