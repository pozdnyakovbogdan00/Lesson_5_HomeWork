class expansion
{
    public static void expansion_main(int value)
    {

        switch (value)
        {
            // Задача 34
            case 1: NumberOfEvenNumbers.NumberOfEvenNumbersMethodMain(); break;
            // Задача 36:
            case 2: SumOfValuesOddPositions.SumOfValuesOddPositionsMethodMain(); break;
            // Задача 38:
            case 3: QuotientMaxAndMin.QuotientMaxAndMinMethodMain(); break;
            
            default: Console.WriteLine("You have entered an invalid value (Enter 1 - 3)."); break;
        }
    }
}

class NumberOfEvenNumbers
{
    // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
    // Напишите программу, которая покажет количество чётных чисел в массиве.
    public static void NumberOfEvenNumbersMethodMain()
    {
        string[] InputTextArr = CommonMethods.DataInput("Enter the dimension of the array: ");
        int[] IntArray = CommonMethods.FillArray(Convert.ToInt32(InputTextArr[0]), 100, 999);
        int result = FindNumberEven(IntArray);
        string StringArray = IntArray.Length == 0 ? "" : CommonMethods.ArrayToString(IntArray);
        CommonMethods.OutPutData("Your array: " + StringArray, "Result: " + Convert.ToString(result));
    }

    private static int FindNumberEven(int[] IntArray)
    {
        int result = 0;
        foreach (var item in IntArray)
        {
            result = item % 2 == 0 ? result + 1 : result;
        }
        return result;
    }

}

class SumOfValuesOddPositions
{
    // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
    // Найдите сумму элементов, стоящих на нечётных позициях.
    public static void SumOfValuesOddPositionsMethodMain()
    {
        string[] InputTextArr = CommonMethods.DataInput("Enter the dimension of the array: ", "Enter the left border of the range", "Enter the right border of the range");
        int N = Convert.ToInt32(InputTextArr[0]);
        int[] IntArray = CommonMethods.FillArray(N, Convert.ToInt32(InputTextArr[1]), Convert.ToInt32(InputTextArr[2]));
        int result = FindSumValuesOddPositions(IntArray, N);
        string StringArray = IntArray.Length == 0 ? "" : CommonMethods.ArrayToString(IntArray);
        CommonMethods.OutPutData("Your array: " + StringArray, "Result: " + Convert.ToString(result));
    }

    private static int FindSumValuesOddPositions(int[] IntArray, int N)
    {
        int result = 0;

        for (int i = 0; i < N; i++)
        {
            result = i % 2 == 0 ? result : result + IntArray[i];
        }

        return result;
    }
}

class QuotientMaxAndMin
{
    // Задача 38: Задайте массив вещественных чисел. 
    // Найдите разницу между максимальным и минимальным элементов массива.
    public static void QuotientMaxAndMinMethodMain()
    {
        string[] InputTextArr = CommonMethods.DataInput("Enter the dimension of the array: ", "Enter the left border of the range", "Enter the right border of the range");
        int N = Convert.ToInt32(InputTextArr[0]);
        int[] IntArray = CommonMethods.FillArray(N, Convert.ToInt32(InputTextArr[1]), Convert.ToInt32(InputTextArr[2]));
        string StringArray = IntArray.Length == 0 ? "" : CommonMethods.ArrayToString(IntArray);
        SortArray(ref IntArray);
        string StringSorted = IntArray.Length == 0 ? "" : CommonMethods.ArrayToString(IntArray);
        int result = FindQuotient(IntArray[0], IntArray[IntArray.GetUpperBound(0)]);
        CommonMethods.OutPutData("Your array: " + StringArray, "Sorted array: " + StringSorted, "Result: " + Convert.ToString(result));
    }
    private static void SortArray(ref int[] IntArray)
    {
        int temp;

        for (int i = 0; i < IntArray.GetUpperBound(0); i++)
        {
            for (int j = i + 1; j < IntArray.Length; j++)
            {
                if (IntArray[i] > IntArray[j])
                {
                    temp = IntArray[i];
                    IntArray[i] = IntArray[j];
                    IntArray[j] = temp;
                }
            }
        }

    }
    
    private static int FindQuotient(int min, int max) => max - min;
}

class CommonMethods
{
    public static string[] DataInput(params string[] OffersToInPut)
    {
        int DataRequired = OffersToInPut.Length;
        string[] InputTextArr = new string[DataRequired];

        int i = 0;
        while (i < DataRequired)
        {
            Console.WriteLine(OffersToInPut[i]);
            InputTextArr[i] = Console.ReadLine();
            i++;
        }

        return InputTextArr;
    }
    public static void OutPutData(params string[] OutPutText)
    {
        foreach (var item in OutPutText)
        {
            Console.WriteLine(item);
        }

    }

    public static string ArrayToString(int[] IntArray)
    {
        string StringArray = "[ ";

        foreach (var item in IntArray)
        {
            StringArray = StringArray + item + "; ";
        }

        StringArray = StringArray + "]";

        return StringArray;
    }

    public static int[] FillArray(int N, int Left, int Right)
    {
        int[] IntArray = new int[N];
        int i = 0;

        while (i < N)
        {
            Random rand = new Random();
            IntArray[i] = rand.Next(Left, Right + 1);
            i++;
        }

        return IntArray;
    }
}