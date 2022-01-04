class NoMath
{
    static string[] dimensions = File.ReadAllLines("/home/jaleelvs/Desktop/AOC/2015/day_2/input.txt");

    static double CalculateSurfaceArea(int l, int w, int h)
    {
        int[] dimensionsArray = new int[] {(2 * l * w), (2 * w * h), (2 * h * l)};
        return dimensionsArray.Min() / 2 + dimensionsArray.Sum();
    }

    static double TotalSurfaceArea1()
    {
        double totalSurfaceArea = 0;
        foreach (var dimension in dimensions)
        {
            int[] dims = Array.ConvertAll(dimension.Split('x'), int.Parse);
            Tuple<int, int, int> points = Tuple.Create(dims[0], dims[1], dims[2]);
            var (x, y, z) = points;
            totalSurfaceArea += CalculateSurfaceArea(x, y, z);
        }

        return totalSurfaceArea;
    }

    static double TotalSurfaceArea2()
    {
        return dimensions
            .Select(x => x.Split('x')) //created nested arrays eg. [[2, 4, 5], [5, 6, 7]...]
            .Select(x => x.Select(int.Parse)) // convert strings to ints 
            .Select(x => x.OrderBy(y => y).ToArray()) // sort from smallest largest
            .Select(x => 3 * x[0] * x[1] + 2 * x[0] * x[2] + 2 * x[1] * x[2])
            .Sum();
    }


    static void Main()
    {
        Console.WriteLine($"Total Surface Area is: {TotalSurfaceArea1()}");
        Console.WriteLine($"Total Surface Area is: {TotalSurfaceArea2()}");
    }
}