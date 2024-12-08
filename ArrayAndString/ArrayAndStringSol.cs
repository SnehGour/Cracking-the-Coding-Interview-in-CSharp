namespace ArrayAndString;

public static class ArrayAndStringSol
{
    public static bool FirstSol1(string s)
    {
        // Brute Force O(n2)
        for (int i = 0; i < s.Length - 1; i++)
        {
            for (int j = i + 1; j < s.Length; j++)
            {
                if (s[i] == s[j])
                    return false;
            }
        }
        return true;
    }
    public static bool FirstSol2(string s)
    {
        // Sort and check
        s = new string([.. s.OrderBy(x => x)]);
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == s[i + 1]) return false;
        }
        return true;
    }

    public static bool SecondSol1(string s1, string s2)
    {
        // Sort & Check T=O(nlogn) + O(nlogn) + O(n), S = ?
        s1 = new string([.. s1.OrderBy(x => x)]);
        s2 = new string([.. s2.OrderBy(x => x)]);


        // return s1.SequenceEqual(s2);  use either s1.SequenceEqual(s2) or a loop as show below
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i]) return false;
        }
        return true;
    }

    public static bool SecondSol2(string s1, string s2)
    {

        /*
            1. Creating a frequency count array count of size 256 (assuming ASCII characters).
            2. Iterating through the first string s1 and incrementing the count for each character in the count array.
            3. Iterating through the second string s2 and decrementing the count for each character in the count array.
            4. If the count for any character becomes negative, it means that the character appears more times in s2 than in s1, so the function returns false.
            5. If the function completes without returning false, it means that the two strings are permutations of each other, so the function returns true.
        
         Other problems:
         Anagram Detection,String Permutation,Duplicate Characters,
         First Non-Repeating Character,Most Frequent Character,String Matching,
         Palindrome Detection,Word Frequency,Character Frequency 
        
        */

        
        if (s1.Length != s2.Length) return false;

        int[] count = new int[256]; // assuming ASCII characters

        foreach (char c in s1)
        {
            count[c]++;
        }

        foreach (char c in s2)
        {
            count[c]--;
            if (count[c] < 0) return false;
        }

        return true;
    }

}

