using System.Security.Cryptography;

class StockingStuffer
{
    private static MD5 md5 = MD5.Create();
    
    static void Main()
    {
        string samoke = "iwrupvqb";
        Console.WriteLine(getAnswer(samoke, 6)); ;
    }

    private static string CreateMD5Hash(string input)
    {
        byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
        byte[] hashBytes = md5.ComputeHash(inputBytes);
        
        string md5Hash = string.Join("", hashBytes.Select(b => b.ToString("x2")));
        
        return md5Hash;

    }

    private static int getAnswer(string key, int n)
    {
        string leadingZeroes = new string('0', n);
        int answer;
        int range = 0;
        while (true)
        {
            string secretKey = $"{key}{range}";
            string newMd5Hash = CreateMD5Hash(secretKey);
            if (newMd5Hash.Substring(0, n).Equals(leadingZeroes))
            {
                answer = range;
                break;
            }

            range++;
        }
        return answer;
    }
}
