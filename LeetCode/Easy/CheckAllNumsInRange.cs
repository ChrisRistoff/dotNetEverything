public class CheckRange{
    public bool IsCovered(int[][] ranges, int left, int right) {

        HashSet<int> nums = new HashSet<int>();

        for (int i = left; i <= right; i++)
        {
            nums.Add(i);
        }

        foreach (var arr in ranges)
        {
            for (int i = arr[0]; i <= arr[1]; i++)
            {
                nums.Remove(i);
            }

            if (nums.Count == 0)
            {
                return true;
            }
        }

        return false;
    }
}
