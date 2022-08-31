using System.Collections;
namespace CSharp.Utils;

public static class Utils
{
    public static void ShowArray(IEnumerable array)
    {
        foreach (var a1 in array)
        {
            if (a1 is IEnumerable a2)
            {
                ShowArray(a2);
            }
            else
            {
                Console.Write($"{a1} ");
            }
        }
        Console.WriteLine();
    }
}