// Вид 1

// void Metod1()
// {
//     Console.WriteLine("Автор ...")
// }

// Metod1();




// Вид 2

// void Method2(string msg)
// {
//     System.Console.WriteLine(msg);
// }

// Method2("Текст сообщения");

//или

// void Method2_1(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         System.Console.WriteLine(msg);
//         i++;
//     }
// }

// Method2_1("Текст", 4);
// Method2_1(msg: "Текст", count: 4);
//Method2_1(count: 4, msg: "Текст");




// Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// System.Console.WriteLine(year);



// Вид 4

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;   // Присваиваем пустую строку, тоже самое, что и: string result = "";

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "asdfg ");
// System.Console.WriteLine(res);


// или вариация через For

// string Method4(int count, string text)
// {
//     string result = String.Empty;   // Присваиваем пустую строку, тоже самое, что и: string result = "";

//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
    
//     return result;
// }

// string res = Method4(10, "asdfg ");
// System.Console.WriteLine(res);



// ЦИКЛ в ЦИКЛЕ. Пример - таблица умножения

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         System.Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     System.Console.WriteLine();
// }



//=====Работа с тектом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде, "
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
// s[2] будет равно e

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     for (int i = 0; i < text.Length; i++)
//     {
//         if (text[i] == oldValue) result = result + newValue;
//         else result = result + text[i];
//     }
// return result;
// }
// string newText = Replace(text, ' ', '|');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// System.Console.WriteLine(newText);



// Сортировка массива

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1, 2};

void PrintArray(int[] array)
{
   int count = array.Length;

   for (int i = 0; i < count; i++)
   {
        System.Console.Write($"{array[i]} ");
   } 
   System.Console.WriteLine();
}

void SelectionSort(int [] array)
{       
    for (int i = 0; i < array.Length - 1; i++)
    {   
        int minPosition = i;        
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }

}

//сортировка от Макс к Мин


void SelectionSortRevers(int [] array)
{       
    for (int i = 0; i < array.Length - 1; i++)
    {   
        int maxPosition = i;        
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            {
                maxPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }

}


PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
SelectionSortRevers(arr);
PrintArray(arr);

