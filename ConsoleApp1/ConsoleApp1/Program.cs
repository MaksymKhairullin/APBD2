// See https://aka.ms/new-console-template for more information

Console.WriteLine(GetAvg([1,2,3,4,5]));

static double GetAvg(int[] arr)
{
    int sumNum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sumNum += arr[i];
    }
    return sumNum / arr.Length;
}