using static System.Console;
Clear();
Write("Введите размер матрицы, минимальное и максимальное значение елементов матрицы через пробел: ");
int[] parameters = GetArrayInString(ReadLine()!);
int[,] MyMatrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(MyMatrix);
WriteLine("Введите номер строки: ");
int numStr = int.Parse(ReadLine()!);
WriteLine("Ввдите номер колонки: ");
int numColum = int.Parse(ReadLine()!);
GetPositionsElement(numStr, numColum, MyMatrix);










int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return resultMatrix;
}


void PrintMatrix(int[,] newMatrix)
{
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            Write($"{newMatrix[i, j]}\t");
        }
        WriteLine();
    }
}


int[] GetArrayInString(string parameters)
{
    string[] parametr = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] parametrNum = new int[parametr.Length];
    for (int i = 0; i < parametrNum.Length; i++)
    {
        parametrNum[i] = int.Parse(parametr[i]);
    }
    return parametrNum;
}


void GetPositionsElement(int num1, int num2, int[,] InMatrix)
{
    if (num1 > InMatrix.GetLength(0) || num2 > InMatrix.GetLength(1))
    {
        WriteLine("Такого элемента нет в массиве");
    }
    else
    {
        WriteLine($"Значение элемента массива {InMatrix[num1, num2]}");
    }

}