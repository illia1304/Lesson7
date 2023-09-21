int[] array = { 5, 2, 10, 8, 1, -15, 4, 16};

BubbleSort(array);
printArray(array);


//selection
void BubbleSort(int[] array)
{
    for(int i = 0; i < array.Length-1; i++)
    {
        for(int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                (array[j], array[j + 1])=(array[j+1], array[j]);
            }
        }
    }
}

void printArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
}
