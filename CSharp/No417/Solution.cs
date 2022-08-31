namespace CSharp.No417;

public class No417
{
    public IList<IList<int>> PacificAtlantic(int[][] heights)
    {
        var wid = heights.Length;
        var hei = heights[0].Length;
        var pOcean = new bool[wid, hei];
        var aOcean = new bool[wid, hei];

        for (var i = 0; i < wid; i++)
        {
            dfs(pOcean, heights, i, 0, wid, hei);
            dfs(aOcean, heights, wid - 1 - i, hei - 1, wid, hei);
        }

        for (var i = 0; i < hei; i++)
        {
            dfs(pOcean, heights, 0, i, wid, hei);
            dfs(aOcean, heights, wid - 1, hei - 1 - i, wid, hei);
        }

        IList<IList<int>> outList = new List<IList<int>>();

        for (var i = 0; i < wid; i++)
        {
            for (var j = 0; j < hei; j++)
            {
                if (pOcean[i, j] && aOcean[i, j])
                    outList.Add(new List<int>{i,j});
            }
        }
        return outList;
    }

    public Array dfs(bool[,] visited, int[][] matrix, int x, int y, int width, int height)
    {
        visited[x, y] = true;

        int[][] direction = { new[] { -1, 0 }, new[] { 0, -1 }, new[] { 1, 0 }, new[] { 0, 1 } };

        foreach (var dir in direction)
        {
            var x1 = x + dir[0];
            var y1 = y + dir[1];
            if (x1 >= 0 && y1 >= 0 && x1 < width && y1 < height && !visited[x1, y1] && matrix[x1][y1] >= matrix[x][y]) //合法點位
                dfs(visited, matrix, x1, y1, width, height);
        }
        return visited;
    }


}