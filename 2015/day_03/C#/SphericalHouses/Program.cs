class SphericalHouses
{
    private static Dictionary<char, int> santaCoordinates = new Dictionary<char, int>
    {
        {'x', 0},
        {'y', 0},
    };

    private static Dictionary<char, int> roboSantaCoordinates = new Dictionary<char, int>
    {
        {'x', 0},
        {'y', 0},
    };

    static HashSet<string> coordinates = new HashSet<string> {$"0,0"};
    static string directions = File.ReadAllText("/home/jaleelvs/Desktop/AOC/2015/day_03/input.txt");

    static string GetCoordinates(char symbol, Dictionary<char, int> coordinate)
    {
        switch (symbol)
        {
            case '^':
                ++coordinate['y'];
                break;
            case '>':
                ++coordinate['x'];
                break;
            case '<':
                --coordinate['x'];
                break;
            case 'v':
                --coordinate['y'];
                break;
        }

        return $"{coordinate['x']},{coordinate['y']}";
    }

    static void SantaSolo()
    {
        foreach (var direction in directions)
        {
            coordinates.Add(GetCoordinates(direction, santaCoordinates));
        }

        Console.WriteLine(coordinates.Count);
    }

    static void SantaAndRobo()
    {
        foreach (var direction in directions.Select((value, index) => new {value, index}))
        {
            if (direction.index % 2 == 0)
            {
                coordinates.Add(GetCoordinates(direction.value, roboSantaCoordinates));
            }

            else
            {
                coordinates.Add(GetCoordinates(direction.value, santaCoordinates));
            }
            
        }
        Console.WriteLine(coordinates.Count);


    }
    
    static void Main()
    {
       SantaAndRobo();
    }
}

