int [] array = {1, 2, 3, 4, 6, 4, 5, 66};
int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
    {
    if (array[index] == find)
        {
        Console.WriteLine("Найдено! " + "Индекс = " + index);
        break;
        }
    index++;

}