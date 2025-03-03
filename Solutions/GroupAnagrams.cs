namespace Solutions;

// Time Complexity: O(n * m)
// Space Complexity: O(n * m)
// n: Number of words in input array
// m: Average length words
public class Solution49
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        // Create a hashmap to store grouped anagrams
        // Key: A character frequency based identifier for each anagram group
        // Value: A list of words that match this identifier
        var result = new Dictionary<string, List<string>>();
        
        // Iterate through each word in the input array
        foreach (var s in strs)
        {
            // Create an array to count the frequency of each letter
            int[] count = new int[26];
            foreach (var c in s)
            {
                count[c - 'a']++; // Increment the count for each corresponding letter
            }
    
            // Convert the character frequency array into an identifier
            string key = string.Join(",", count);
            
            // If the key doesn't exist in the dictionary, create a new entry
            if (!result.ContainsKey(key))
            {
                result[key] = new List<string>();
            }

            // Add the current word to the corresponding list
            result[key].Add(s);
        }
        
        return result.Values.ToList<IList<string>>();
    }
}