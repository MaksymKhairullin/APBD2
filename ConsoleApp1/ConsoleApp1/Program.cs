// See https://aka.ms/new-console-template for more information

Console.WriteLine(GetAvg([1,2,3,4,5]));

static double GetAvg(int[] arr)
{
    int sum = 0;
    for (int l = 0; l < arr.Length; l++)
    {
        sum += arr[l];
    }
    return sum / arr.Length;
}