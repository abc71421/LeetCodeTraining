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

    public static void ShowBinaryTree(TreeNode? root)
    {
        if (root == null)
            return;

        var queue = new Queue<TreeNode?>();
        var list = new List<string>();
        queue.Enqueue(root);
        while (true)
        {
            var nodeCount = queue.Count;
            if (nodeCount == 0)
                break;
            while (nodeCount > 0)
            {
                var node = queue.Peek();
                queue.Dequeue();
                if (node == null)
                {
                    list.Add("null");
                }
                else
                {
                    list.Add(node.val.ToString());
                    if (node.left != null || node.right != null)
                    {
                        queue.Enqueue(node.left);
                        queue.Enqueue(node.right);
                    }
                }
                nodeCount--;
            }
        }

        foreach (var variable in list.Select((value, i) => new { i, value }))
        {
            Console.Write(variable.i == 0 ? variable.value : $", {variable.value}");
        }

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