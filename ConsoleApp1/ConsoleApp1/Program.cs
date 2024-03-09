// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

Console.WriteLine(GetAvg([1,2,3,4,5]));

static double GetAvg(int[] arr)
{
    int sum = 0;
    for (int r = 0; r < arr.Length; r++)
    {
        sum += arr[r];
    }
    return sum / arr.Length;
}