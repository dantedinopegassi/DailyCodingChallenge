public class Node
{
    string value;
    Node? left;
    Node? right;

    public Node(string value, Node? left, Node? right)
    {
        this.value = value;
        this.left = left;
        this.right = right;
    }
    public Node(string value)
    {
        this.value = value;
        this.left = null;
        this.right = null;
    }


    public string toString()
    {
        return $"Node('{value}'" + ", " +
        ((this.left != null) ? $"{this.left.toString()}" : "null") + ", " +
        ((this.right != null) ? $"{this.right.toString()}" : "null") + ")";
    }
}
