class program
{
    static void Main(string[] args)
    {
        int[,] twoDimensionalArray = { { 5, 2, 3, 7 }, { 4, 4, 6, 9 }, { 7, 8, 9, 1 } };
        int twoDimensionalArrayStringCounter;
        int twoDimensionalArrayColumnCounter;
        int sumOfSecondLine = 0;
        int firstColumnMultiplication = 1;
        int numberString = 1;
        int numberColumn = 0;

        for (twoDimensionalArrayStringCounter = 0; twoDimensionalArrayStringCounter < twoDimensionalArray.GetLength(0); twoDimensionalArrayStringCounter++)
        {
            for (twoDimensionalArrayColumnCounter = 0; twoDimensionalArrayColumnCounter < twoDimensionalArray.GetLength(1); twoDimensionalArrayColumnCounter++)
            {
                Console.Write(twoDimensionalArray[twoDimensionalArrayStringCounter, twoDimensionalArrayColumnCounter]);
            }
            Console.WriteLine();
        }

        for (twoDimensionalArrayColumnCounter = 0; twoDimensionalArrayColumnCounter < twoDimensionalArray.GetLength(0); twoDimensionalArrayColumnCounter++)
        {
            firstColumnMultiplication *= twoDimensionalArray[twoDimensionalArrayColumnCounter, numberColumn];
        }

        for (twoDimensionalArrayStringCounter = 0; twoDimensionalArrayStringCounter < twoDimensionalArray.GetLength(1); twoDimensionalArrayStringCounter++)
        {
            sumOfSecondLine += twoDimensionalArray[numberString, twoDimensionalArrayStringCounter];
        }
        Console.WriteLine($"Произведение первой колонки - {firstColumnMultiplication}\nСумма второй строки - {sumOfSecondLine}");
    }
}