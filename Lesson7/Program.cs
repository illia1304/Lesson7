int count = int.Parse(Console.ReadLine());
int[] array = new int[count];

for(int i = 0; i < count; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

SelectionSort(array);


//selection
void SelectionSort(int[] array)
{
    int length = array.Length;
    int indexMin, temp;

    for(int i=0; i < length - 1; i++){
        indexMin = i;
        for(int j = i + 1; j < length; j++)
        {
            if(array[j] < array[indexMin])
                indexMin = j;
        }
        temp = array[i];
        array[indexMin] = array[i];
        array[i] = temp;
    }
}







void printArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]+" ");
    }
}
