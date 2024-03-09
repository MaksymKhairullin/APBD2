// See https://aka.ms/new-console-template for more information

Console.WriteLine(GetMax([1,2,3,4,5,7,123,45,32,12]));

static int GetMax(int[] arr)
{
    int max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}