public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        List<int> result = [];
        foreach (int n in select)
        {
            List<int> list1Copy = new(list1);
            List<int> list2Copy = new(list2);
            if (n == 1)
            {
                result.Add(list1Copy[0]);
                list1Copy.RemoveAt(0);
            }
            else if (n == 2)
            {
                result.Add(0);
                list2Copy.RemoveAt(0);
            }
        }
        return [.. result];
    }

}