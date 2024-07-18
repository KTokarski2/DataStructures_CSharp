namespace MyDataStructures;

public class MyLinkedList<T>
{

    private Node _head;
    public Node First => _head;
    public Node Last
    {
        get
        {
            Node node = GetLastNode();
            return node;
        }
    }

    private int _count;

    public int Count
    {
        get
        {
            if (_count < 0)
            {
                _count = 0;
            }

            return _count;
        }
        private set
        {
            _count = value;
        }
    }

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
    
    public void AddFirst(T t)
    {
        Node newNode = new Node(t);
        Count++;
        if (_head == null)
        {
            _head = newNode;
            return;
        }

        newNode.Next = _head;
        _head.Previous = newNode;
        _head = newNode;
    }

    public void AddLast(T t)
    {
        Node newNode = new Node(t);
        Count++;
        if (_head == null)
        {
            _head = newNode;
        }

        Node lastNode = GetLastNode();
        lastNode.Next = newNode;
        newNode.Previous = lastNode;

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