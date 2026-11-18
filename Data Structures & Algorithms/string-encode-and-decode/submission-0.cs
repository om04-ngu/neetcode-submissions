public class Solution {

    public string Encode(IList<string> strs) 
    {
        string dummy = "";
        //int intDummy=0;
        foreach(string i in strs)
        {
            dummy += i.Length + "#" + i;
        }
        
        return dummy;
    }

    public List<string> Decode(string s) 
    {
        List<string> result = new List<string>();
        int i =0;
        while(i<s.Length)
        {
            int delimiter = s.IndexOf('#', i);

            int length = int.Parse(
                s.Substring(i, delimiter - i)
            );

            int wordStart = delimiter + 1;

            string word = s.Substring(wordStart, length);

            result.Add(word);

            i = wordStart + length;
        }
        return result;
    }
}
