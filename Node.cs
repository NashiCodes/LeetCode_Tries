namespace Tries;

internal class Node
{
    private readonly Node?[] _childrens = new Node?[256];

    public Node(bool end, char key)
    {
        End = end;
        Key = key;
        for (var i = 0; i < 256; i++) _childrens[i] = null;
    }

    public bool End { get; set; }

    public char Key { get; set; }

    public Node? Get(char key)
    {
        return _childrens[key - 'a'];
    }

    public bool IsSet(char key)
    {
        return _childrens[key - 'a'] != null;
    }

    public void SetChar(char key, Node node)
    {
        _childrens[key - 'a'] = node;
    }

    public bool IsEmpty()
    {
        foreach (var i in _childrens)
            if (i != null)
                return false;

        return true;
    }
}