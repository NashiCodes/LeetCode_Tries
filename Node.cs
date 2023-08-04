namespace Tries;

public class Node
{
    public Dictionary<char, Node> Children;
    public bool isWord;

    public Node()
    {
        Children = new Dictionary<char, Node>();
        isWord = false;
    }
}