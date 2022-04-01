class program
{
    static void Main(string[] args)
    {
        int[,] two_Dimensional_array = { { 5, 2, 3, 7 }, { 4, 4, 6, 9 }, { 7, 8, 9, 1 } };
        int arrayStringCounter;
        int arrayColumnCounter;
        int sumOfSecondLine = 0;
        int firstColumnMultiplication = 1;
        int numberString = 1;
        int numberColumn = 0;

        for (arrayStringCounter = 0; arrayStringCounter < two_Dimensional_array.GetLength(0); arrayStringCounter++)
        {
            for (arrayColumnCounter = 0; arrayColumnCounter < two_Dimensional_array.GetLength(1); arrayColumnCounter++)
            {
                Console.Write(two_Dimensional_array[arrayStringCounter, arrayColumnCounter]);
            }
            Console.WriteLine();
        }

        for (arrayStringCounter = 0; arrayStringCounter < two_Dimensional_array.GetLength(0); arrayStringCounter++)
        {
            for (arrayColumnCounter = 0; arrayColumnCounter < two_Dimensional_array.GetLength(1); arrayColumnCounter++)
            {
                if (arrayStringCounter == numberString)
                {
                    sumOfSecondLine += two_Dimensional_array[arrayStringCounter, arrayColumnCounter];
                }

                if (arrayColumnCounter == numberColumn)
                {
                    firstColumnMultiplication = two_Dimensional_array[arrayStringCounter, arrayColumnCounter] * firstColumnMultiplication;
                }
            }
        }
        Console.WriteLine($"Сумма второй строки массива - {sumOfSecondLine}\nПроизведение первого столбца массива - {firstColumnMultiplication}");
    }

}
