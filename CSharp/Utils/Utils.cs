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

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}