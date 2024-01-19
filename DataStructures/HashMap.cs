public class HashMap
{
    private readonly object[]? Bucket;
    public int MaxSize = 20;
    public int Size = 0;

    public HashMap(int MaxSize)
    {
        this.Bucket = new object[MaxSize][];
    }

    private int HashKey(string key)
    {
        int index = 0;
        for (int i = 0; i < key.Length ; i++)
        {
            index = (index << 5) + (int)key[i];
            index = index & index;
            index = Math.Abs(index);
        }

        index = index % this.MaxSize;
        return index;
    }

    public void Set(string key, string value)
    {
        int hashedKey = this.HashKey(key);
        if (this.Bucket?[hashedKey] == null)
        {
            this.Size++;
        }

        this.Bucket![hashedKey] = new object[] {key, value};
    }

    public string PrintMap()
    {
        if (this.Size == 0)
        {
            return "Map is empty";
        }

        string result = "| ";
        for (int i = 0; i < this.Bucket!.Length; i++)
        {
            if(this.Bucket[i] != null) {
                var kvPair = this.Bucket[i];
            }
        }

        return result;
    }
}
