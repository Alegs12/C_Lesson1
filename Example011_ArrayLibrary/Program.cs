void FillArray(int[] collection)
    {
    int length = collection.Length;
    int index = 0;
    while (index < length)
        {
         collection[index] = new Random().Next(1, 10);
         index++;  
        }
    }

void PrintAray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf (int[] collection, int find)
{
    int count = 0;
    int length = collection.Length;
    int posit = -1;
    while (count < length)
        {
        if(collection[count] == find)
            {
                posit = count;
                break;
            }
        count++;
        }
    return posit;    
}


int [] array = new int[10];
FillArray(array);
PrintAray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
