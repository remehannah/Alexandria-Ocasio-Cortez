﻿namespace NotQuiteLisp
{
    class NotQuiteLisp
    {
        private readonly Dictionary<char, int> _instructions = new Dictionary<char, int>
        {
            {')', -1},
            {'(', 1}
        }; // each character corresponds to the direction Santa has to move

        private int _currentFloor = 0; // current floor Santa is located on
        private int _characterPosition = 0; // index of the current character

        void TraverseThroughFloors(string path)
        {
            bool basementFound = false;

            var lines = File.ReadLines(path);

            foreach (var line in lines)
            {
                foreach (var symbol in line.ToCharArray())
                {
                    _currentFloor += _instructions[symbol];

                    if (basementFound != false) continue;
                    _characterPosition += 1;
                    if (_currentFloor != -1) continue;
                    Console.WriteLine($"The basement is located at position: {_characterPosition}");
                    basementFound = true;
                }
            }

            Console.WriteLine($"Santa is on floor: {_currentFloor}");
        }


        void Traverse2(string path)
        {
            var symbols = File.ReadAllText(path);

            // var santaFloor = symbols.Select(x => x.Equals(')') ? -1 : 1).Sum();
            var santaFloor = symbols.Sum(x => x.Equals(')') ? -1 : 1);
            Console.WriteLine($"Santa is on floor: {santaFloor}");
            var floor = 0;
            var santoBasement = Array.IndexOf(symbols
                                                        .Select(x => x == '(' ? ++floor : --floor)
                                                        .ToArray(), -1) + 1;
            Console.WriteLine($"The basement is located at position: {santoBasement}");

        }


        static void Main()
        {
            NotQuiteLisp notQuiteLisp = new NotQuiteLisp();
            const string filePath = "/home/jaleelvs/Desktop/AOC/2015/day_1/input.txt";
            notQuiteLisp.Traverse2(filePath);
            notQuiteLisp.TraverseThroughFloors(filePath);
        }
    }
}