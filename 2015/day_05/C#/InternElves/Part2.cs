public class Part2
{
    public bool IsStringNice(string bell)
    {
        if (!hasNonOverlappingPair(bell)) return false;
        if (!hasRepeatingLetter(bell)) return false;


        return true;
    }

    public bool hasRepeatingLetter(string str)
    {
        for (int i = 0; i < str.Length - 2; i++)
        {
            if (str[i] == str[i + 2]) return true;
        }

        return false;
    }

    public bool hasNonOverlappingPair(string str)
    {
        HashSet<string> hasher = new HashSet<string>();

        for (int i = 0; i < str.Length - 2; i++)
        {
            string pair = $"{str[i]}{str[i + 1]}";
            if (str.LastIndexOf(pair) > i + 1)
            {
                return true;
            }
        }

        return false;
    }
}