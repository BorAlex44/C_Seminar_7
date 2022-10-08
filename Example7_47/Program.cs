using static System.Console;
Clear();
Write("Введите размер матрицы, минимальное и максимальное значение елементов матрицы через пробел: ");
int[] parameters = GetArrayInString(ReadLine()!);
double[,] MyMatrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(MyMatrix);










double[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    double[,] resultMatrix = new double[rows, columns];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = Math.Round(rnd.Next(minValue, maxValue + 1) + rnd.NextDouble(), 1);
        }
    }
    return resultMatrix;
}


void PrintMatrix(double[,] newMatrix)
{
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            Write($"{newMatrix[i, j]} ");
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