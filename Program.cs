namespace Tries;

public class MainClass
{
    public static void Main()
    {
        //Input:    ["Trie", "insert", "search", "search", "startsWith", "insert", "search"]
        //          [[], ["apple"], ["apple"], ["app"], ["app"], ["app"], ["app"]]
        //Output    [null, null, true, false, true, null, true]

        //Explanation
        Trie trie = new();
        trie.Insert("apple");
        trie.Insert("apple"); // return True
        trie.Search("app"); // return False
        trie.StartsWith("app"); // return True
        trie.Insert("app");
        trie.Search("app"); // return True
    }
}

//Contraints:
//1 <= word.length, prefix.length <= 2000
//word and prefix consist only of lowercase English letters.
//At most 3 * 10^4 calls in total will be made to insert, search, and startsWith.