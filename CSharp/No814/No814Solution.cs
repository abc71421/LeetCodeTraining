using CSharp.Utils;

namespace CSharp.No814;

public class No814
{
    public static TreeNode PruneTree(TreeNode root)
    {
        if (root == null)
            return null;

        if (root.val == 0 && root.left == null && root.right == null) return null;

        root.left = PruneTree(root.left);
        root.right = PruneTree(root.right);


        return root;
    }

}