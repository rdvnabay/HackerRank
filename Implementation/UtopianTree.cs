namespace Implementation;

public class UtopianTree
{
    /// <param name="n"> int n: the number of growth cycles to simulate </param>
    /// <returns> int: the height of the tree after the given number of cycles </returns>
    public static int Run(int n)
    {
        int treeLength = 0;

        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0)
                treeLength += 1;

            if (i % 2 == 1)
                treeLength *= 2;
        }

        return treeLength;
    }
}
