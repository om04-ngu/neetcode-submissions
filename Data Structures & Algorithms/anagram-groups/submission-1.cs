public class Solution 
{
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        Dictionary<string, List<string>> dict =
            new Dictionary<string, List<string>>();

        foreach (string s in strs)
        {
            // Sort characters of the word
            char[] chars = s.ToCharArray();
            Array.Sort(chars);

            // Convert sorted characters into string
            string key = new string(chars);

            // Check if key already exists
            if (!dict.ContainsKey(key))
            {
                dict[key] = new List<string>();
            }

            // Add original word to its group
            dict[key].Add(s);
        }

        return dict.Values.ToList();
    }
}
