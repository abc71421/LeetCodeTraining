using CSharp.Utils;

namespace CSharp.No814;

public class No814Inputs
{
    private static readonly TreeNode Example1 = new(1, right: new TreeNode(0, new TreeNode(0), new TreeNode(1)));

    internal static List<TreeNode> Arg1 = new() { Example1 };
}