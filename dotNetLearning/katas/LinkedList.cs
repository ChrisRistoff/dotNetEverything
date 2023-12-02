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
        return;
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

        return;
    }

    public T Pop()
    {
        if (Head == null && Tail == null)
        {
            throw new InvalidOperationException("List is empty");
        }

        T popped;

        if (Head == Tail)
        {
            popped = Head!.Data;
            Head = null;
            Tail = null;

            return popped;
        }

        popped = Tail!.Data;
        Node<T> curr = Head!;

        for (int i = 2; i < Length; i++)
        {
            curr = curr.Next!;
        }

        curr.Next = null;
        Tail = curr;
        Length--;
        return popped;
    }

    public T PopLeft()
    {
        if (Head == null && Tail == null)
        {
            throw new InvalidOperationException("List is empty");
        }

        T popped;

        if (Head == Tail) {
            popped = Head!.Data;
            Head = null;
            Tail = null;
            return popped;
        }

        popped = Head!.Data;
        Head = Head.Next;

        return popped;
    }

    public T GetByIndex(int index)
    {
        if (index >= Length || Length == 0)
        {
            throw new InvalidOperationException("Index out of range");
        }
        Node<T> curr = Head!;
        for (int i = 0; i < index; i++)
        {
            curr = curr.Next!;
        }

        return curr.Data;
    }
}
