namespace Tries;

public class Trie
{
    public Node Root;

    public Trie()
    {
        Root = new Node();
    }

    public void Insert(string word)
    {
        var curNode = Root;

        foreach (var c in word)
        {
            if (!curNode.Children.ContainsKey(c)) curNode.Children.Add(c, new Node());

            curNode = curNode.Children[c];
        }

        curNode.isWord = true;
    }


    public bool Search(string word)
    {
        var curNode = Root;

        foreach (var c in word)
        {
            if (!curNode.Children.ContainsKey(c)) return false;

            curNode = curNode.Children[c];
        }

        return curNode.isWord;
    }

    public bool StartsWith(string prefix)
    {
        var curNode = Root;

        foreach (var c in prefix)
        {
            if (!curNode.Children.ContainsKey(c)) return false;

            curNode = curNode.Children[c];
        }

        return true;
    }
}

//Your Trie object will be instantiated and called as such:
//Trie obj = new Trie();
//obj.Insert(word);
//bool param_2 = obj.Search(word);b
//bool param_3 = obj.StartsWith(prefix);