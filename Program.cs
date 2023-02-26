// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ['1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string [] mass = {"bido,bido","hahaha","bububu","blablabla","hihihi"};

{
    for (int i = 0; i < mass.Length; i++)
    {
        string str = mass [new Random().Next(0,5)];
        System.Console.Write("|" + str);
        
        // if (str[0]==str[1])
        // for (int i = 1; i < mass.Length; i++);
        

    //    if (str[0]==str[1])
    //    for (int i = 1; i < mass.Length; i++)
    //    str = new string;
    //    System.Console.Write(str);
       
    //    if (str[1]==str[2])
    //    for (int i = 2; i < mass.Length; i++)
       
    //    if (str[2]==str[3])
    //    for (int i = 3; i < mass.Length; i++)

    //    if (str[3]==str[4])
    //    for (int i = 4; i < mass.Length; i++)


    }
    
}
