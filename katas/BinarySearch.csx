int[] arr = [1, 2, 3, 6, 8, 12, 17, 21, 26, 29, 32, 36, 39, 45, 47, 49, 50, 54, 57, 62, 66, 69, 72];

int BinarySearch(int[] arr, int target, int left = 0, int right = 0)
{
    int mid = ((left + right) / 2);

    if (left >= right)
    {
        return -1;
    }

    if (arr[mid] == target)
    {
        return mid;
    }

   if (arr[mid] > target)
    {
        right = mid;
        return BinarySearch(arr, target, left, right);
    }

   if (arr[mid] < target)
    {
        left = mid + 1;
        return BinarySearch(arr, target, left, right);
    }

   return -1;
}


System.Console.WriteLine(BinarySearch(arr, 32, 0, arr.Length));
