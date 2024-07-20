//Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите элементы массива, через пробел:");
string input = Console.ReadLine();
string[] array = input.Split(' ');


string[] newArray = new string[array.Length];
int newIndex = 0;


for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[newIndex] = array[i];
        newIndex++;
    }
}
Console.WriteLine("новый массив:");
for (int i = 0; i < newIndex; i++)
{
    Console.Write(newArray[i] + " ");
}

