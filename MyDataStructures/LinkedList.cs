namespace MyDataStructures;

public class LinkedList<T>
{

    private Node _head;
    public Node First => _head;

    public class Node
    {
        public T Value { get; set; }
        public Node Previous { get; set; }
        public Node Next { get; set; }

        public Node(T t)
        {
            Value = t;
            Previous = null;
            Next = null;
        }
    }

    public void AddLast(T t)
    {
        Node newNode = new Node(t);
        if (_head == null)
        {
            _head = newNode;
        }
    }

    private Node GetLastNode()
    {
        Node node = _head;
        while (node.Next != null)
        {
            node = node.Next;
        }

        return node;
    }
}