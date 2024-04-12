
    string s = "erase*****";
    string sReturn = RemoveStars(s);
    static string RemoveStars(string s)
    {
        while (s.Contains('*'))
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                {
                    s = s.Remove((i - 1), 2);
                break;
                }
            }
        }     
            return s;
    }

Console.WriteLine(sReturn);