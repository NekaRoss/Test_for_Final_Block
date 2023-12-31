﻿Commands();
string[] array = new string[] {};

string fromUser = ReadInput("Введите нужный массив: ");       //Определение значений
switch (fromUser)
{
    case "1":
        array = new string[] { "Hello", "2", "world", ":-)" };
        break;
    case "2":
        array = new string[] { "1234", "1567", "-2", "computer science" };
        break;
    case "3":
        array = new string[] { "Russia", "Denmark", "Kazan" };
        break;
    default:
        Console.WriteLine($"{fromUser} - Нет такого массива");
        break;
}

int lenNewArray = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) lenNewArray++;
}

string[] newArray = new string[lenNewArray];
int idx = 0;

for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[idx] = array[i];
        idx++;
    }
}

PrintArray(array);
Console.Write("→ ");
PrintArray(newArray);

//Отображение массивов
void Commands()
{
    Console.WriteLine();
    Console.WriteLine("1 – массив: [“Hello”, “2”, “world”, “:-)”]");
    Console.WriteLine("2 – массив: [“1234”, “1567”, “-2”, “computer science”]");
    Console.WriteLine("3 – массив: [“Russia”, “Denmark”, “Kazan”]");
    Console.WriteLine();
}


string ReadInput(string msg)   //Ввод номера массива

{
    Console.Write(msg);
    return Console.ReadLine();
}

//Вывод массина на терминале
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}