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
            return;
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

    public T GetAt(int index)
    {
        if (index < 0 || index >= Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        return Get(_head, index, 0);
    }

    private T Get(Node node, int targetIndex, int currentIndex)
    {
        if (currentIndex == targetIndex)
        {
            return node.Value;
        }

        return Get(node.Next, targetIndex, currentIndex + 1);
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
            
        }
        Remove(_head, index, 0);
        Count--;
    }

    private void Remove(Node node, int targetIndex, int currentIndex)
    {
        if (currentIndex == targetIndex)
        {
            if (node.Previous == null)
            {
                _head = node.Next;
                if (_head != null)
                {
                    _head.Previous = null;
                }
            }
            else if (node.Next == null)
            {
                node.Previous.Next = null;
            }
            else
            {
                node.Previous.Next = node.Next;
                node.Next.Previous = node.Previous;
            }
            return;
        }

        Remove(node.Next, targetIndex, currentIndex + 1);
    }

}