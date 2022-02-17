int[] arr = { 1, 2, 3, 4, 5, 34, 342, 23, 1231, 213, 123, 213, 21321, 3, 123, 12, 3, 123, 12, 3, 213, 123, 1, 312, 3, 1, 312, 1, 3, 32242543, 645 };

int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 40)
    {
        count++;
    }
}

int[] arr2 = new int[count];
int Index = 0;
for (int i = 0; i < arr2.Length; i++)
{
    if (arr[i] > 40)
    {
        arr2[Index] = arr[i];
        Index++;
    }
}

Array.Sort(arr2);
Array.Reverse(arr2);

foreach (int i in arr2)
Console.WriteLine(i + " ");
Console.ReadLine();


