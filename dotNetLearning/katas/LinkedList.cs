public class Node<T>
{
    public T Data { get; set; }
    public Node<T>? Next { get; set; }

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList<T>
{
    public Node<T>? Head { get; private set; }
    public Node<T>? Tail { get; private set; }
    public int Length { get; private set; } = 0;

    public LinkedList()
    {
        Head = null;
        Tail = null;
    }

    public string PrintList()
    {
        var curr = this.Head;
        T[] arr = { };

        while (curr != null)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = curr.Data;
            curr = curr.Next;
        }

        string res = String.Join(", ", arr);
        return res;
    }

    public void Append(T data)
    {
        Node<T> newNode = new Node<T>(data);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail!.Next = newNode;
            Tail = newNode;
        }

        Length++;
    }

    public void AppendLeft(T data)
    {

        Node<T> newNode = new Node<T>(data);

        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head = newNode;
        }

        Length++;
    }

}
