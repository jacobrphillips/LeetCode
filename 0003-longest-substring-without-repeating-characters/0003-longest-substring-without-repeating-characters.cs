public class Solution 
{
    public int LengthOfLongestSubstring(string s)
    {
        //Optimized Approach

        //create two pointers 
        int start = 0;
        int end = 0;

        //create maximum substring length counter
        int maxLength = 0;

        //keep track of current chars
        HashSet<char> charSet = new HashSet<char>();

        //iterate (loop) over input string
        while(end < s.Length)
        {
            //if char doesn't exist
            if(!charSet.Contains(s[end]))
            {
                //add it
                charSet.Add(s[end]);

                //increment end pointer
                end++;

                //update maximum substring length
                maxLength = Math.Max(maxLength, (end - start));
            }
            else 
            {
                //if char does exist
                //remove it from HashSet
                //at the index of start, so we do not return subsequence
                charSet.Remove(s[start]);
                
                //increment start pointer (trim input string)
                start++;
            }
        }
        //return maximum substring length
        return maxLength;
    }
}