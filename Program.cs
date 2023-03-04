// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ['1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


string [] mass1 = {"bido,bido","hahaha","bububu","blablabla","hihihi"};
string [] mass2 = new string [mass1.Length];
Random rnd = new Random();
int index = rnd.Next(mass1.Length);
int count = 0;

Console.Write( "Массив: ");
{
    for (int i = 0; i < mass1.Length; i++)
    Console.Write(" " + mass1[i]);
}
Console.WriteLine();

{
    for (int i = 0; i < mass1.Length; i++)
    {
        if (mass1[i].Length<=3)
        mass2[count] = mass1[i];
        count++;

    }
    Console.WriteLine();
}

for (int i = 0; i < mass1.Length; i++)
Console.WriteLine(mass2[i]);
Console.Write("Рандомный массив: ");
// Console.Write(" | " + mass1[i]); // Сделать вывод



    

