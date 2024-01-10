// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении 
// не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Решение:

string[] StrArray(string symbol)
{
    string[] stringArray = new string[symbol.Length];
    stringArray = symbol.Split(",");
    return stringArray;
}

string[] FindThreeSymbol(string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        string sym = stringArray[i]
        if (sym.Length <= 3)
        {
            count++;
        }
    }
    string[] arrayThreeSymbol = new string[count];
    for (int i = 0, j = 0; i < stringArray.Length; i++)
    {
        string sym = stringArray[i];
        if (sym.Length <= 3)
        {
            arrayThreeSymbol[j] = sym;
            j++;
        }
    }
    return arrayThreeSymbol;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"{array[i]}, ");
    }
    System.Console.WriteLine();
}


System.Console.WriteLine("Введите набор символов через ',': ");
string symbol = Console.ReadLine();
