class InternElves
{
    public static string[] theStrings = File.ReadAllLines("/home/jaleelvs/Desktop/AOC/2015/day_05/input.txt");
    

    static void Main()
    {
        // Part1 part1 = new Part1();
        Part2 part2 = new Part2();
        // var nNiceStrings = theStrings.Count(x => part1.IsStringNice(x));
        var newNiceStrings = theStrings.Count(x => part2.IsStringNice(x));
        Console.WriteLine(newNiceStrings);

    }
}
