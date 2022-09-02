namespace CSharp.No001;

public static class No001Inputs
{

    private static readonly int[] Example1Arg1 = { 2, 7, 11, 15 };
    private const int Example1Arg2 = 9;

    private static readonly int[] Example2Arg1 = { 3, 2, 4 };
    private const int Example2Arg2 = 6;

    private static readonly int[] Example3Arg1 = { -3, 4, 3, 90 };
    private const int Example3Arg2 = 0;

    private static readonly int[] Example4Arg1 = { 3, 3 };
    private const int Example4Arg2 = 6;

    internal static List<int[]> Args1 = new() { Example1Arg1, Example2Arg1, Example3Arg1, Example4Arg1 };
    internal static List<int> Args2 = new() { Example1Arg2, Example2Arg2, Example3Arg2, Example4Arg2 };

}