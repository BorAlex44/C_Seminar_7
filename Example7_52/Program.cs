using static System.Console;
Clear();
Write("Введите размер матрицы, минимальное и максимальное значение елементов матрицы через пробел: ");
int[] parameters = GetArrayInString(ReadLine()!);
int[,] MyMatrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(MyMatrix);
WriteLine("Среднее арифметическое каждой колонки");
double[] AverageSumArray = GetAverageValue(MyMatrix);
WriteLine($"[{String.Join("\t", AverageSumArray)}]");











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

double[] GetAverageValue(int[,] InMatrix)
{
    double[] resultArray = new double[InMatrix.GetLength(1)];
    for (int j = 0; j < InMatrix.GetLength(1); j++)
    {
        double summa = 0;
        for (int i = 0; i < InMatrix.GetLength(0); i++)
        {
            summa += InMatrix[i, j];
        }
        summa = Math.Round(summa / InMatrix.GetLength(1), 2);
        resultArray[j] = summa;
    }
    return resultArray;
}