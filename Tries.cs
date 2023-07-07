namespace Tries;

public class Trie
{
    private readonly Node _root;

    public Trie()
    {
        _root = new Node(false, '*');
    }

    public void Insert(string word)
    {
        var p = _root;

        if (word.Length == 0) return;

        if (p.Get(word[0]) == null)
        {
            foreach (var i in word)
            {
                var node = new Node(false, i);
                p.SetChar(i, node);
                p = node;
            }

            p.End = true;
        }
        else
        {
            foreach (var i in word)
                if (p.Get(i) == null)
                {
                    var node = new Node(false, i);
                    p.SetChar(i, node);
                    p = node;
                }
                else
                {
                    p = p.Get(i);
                }

            p!.End = true;
        }
    }


    public bool Search(string word)
    {
        var p = _root;
        if (word.Length == 0) return false;
        if (p.Get(word[0]) == null) return false;

        foreach (var i in word)
            if (p!.Get(i) == null)
                return false;
            else
                p = p.Get(i);
        return p!.End;
    }

    public bool StartsWith(string prefix)
    {
        var p = _root;
        if (prefix.Length == 0) return false;
        if (p.Get(prefix[0]) == null) return false;

        foreach (var i in prefix)
            if (p!.Get(i) == null)
                return false;
            else
                p = p.Get(i);
        return true;
    }
}

//Your Trie object will be instantiated and called as such:
//Trie obj = new Trie();
//obj.Insert(word);
//bool param_2 = obj.Search(word);b
//bool param_3 = obj.StartsWith(prefix);