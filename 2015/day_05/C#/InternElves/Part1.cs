public class Part1
{
    public bool IsStringNice(string bell)
    {
        if (isBadGuy(bell))
        {
            return false;
        }

        if (!containsThreeVowels(bell))
        {
            return false;
        }

        if (!containsDoubleLetter(bell))
        {
            return false;
        }

        return true;
    }

    private bool containsDoubleLetter(string str)
    {
        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] == str[i + 1]) return true;
        }

        return false;
    }

    private bool containsThreeVowels(string str)
    {
        int vowelCount = 0;
        HashSet<char> vowels = new HashSet<char> {'a', 'e', 'u', 'i', 'o'};

        foreach (char s in str)
        {
            if (vowels.Contains(s)) vowelCount++;
            if (vowelCount == 3) return true;
        }

        return false;
    }

    private bool isBadGuy(string str)
    {
        HashSet<string> badGuys = new HashSet<string> {"ab", "cd", "pq", "xy"};
        
        foreach (string badGuy in badGuys)
        {
            if (str.Contains(badGuy)) return true;
        }

        return false;
    }
}