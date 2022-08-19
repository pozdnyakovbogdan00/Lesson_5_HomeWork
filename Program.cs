static int Program_Main_InputData()
{
    Console.WriteLine("Choose one of the suggested values: ");
    Console.WriteLine("1: Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
    Console.WriteLine("2: Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
    Console.WriteLine("3: Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
    Console.WriteLine("Your choice? ");
    int InputData = Convert.ToInt32(Console.ReadLine());
    
    return InputData; 
}


expansion.expansion_main(Program_Main_InputData());