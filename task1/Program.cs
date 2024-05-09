// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

System.Console.WriteLine("Задайте начальную строку из 5 слов или символов через пробел");
string text = Console.ReadLine();
string[] arrayText = text.Split(" ");

string[] ShortArray(string[] array, int size)
{   
    string[] resultArray = new string[3];
    
    for (int i = 0; i < size; i+=2)
    {
        resultArray[i/2] = array[i];
    }
    return resultArray;
}

string[] resultArray = ShortArray(arrayText, 5);

void PrintArray(string[] array)
{   
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.Write("]");
}

PrintArray(resultArray);