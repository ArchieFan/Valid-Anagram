
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        Dictionary<char, int> Dic = new Dictionary<char, int>();
        foreach (var (ch, index) in s.Select((v, i) => (v, i)))
        {
            if (!t.Contains(ch)) return false;
            if (Dic.ContainsKey(ch))
            {
                Dic[ch]++; 
            }
            else
            {
                Dic.Add(ch, 1);
            }
        }
        foreach (var (ch, index) in t.Select((v, i) => (v, i)))
        {
            if (Dic.ContainsKey(ch))
            {
                Dic[ch]--;
                if (Dic[ch] == 0) Dic.Remove(ch);  
            } else
            {
                return false;
            }
        }
        if (Dic.Count != 0) return false;
        //Console.WriteLine(value + " is at index " + index);
        return true;
    }

    static void Main()
    {
        string s = "anagram";
        string t = "nagaram";
        Solution sol = new Solution();
        bool res = sol.IsAnagram(s, t);
        Console.Write(res);
    }
}
