
int[] input = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();

int rows = input[0];
int cols = input[1];

int[,] matrix = new int[rows, cols];

int sum = 0;

for (int row = 0; row < rows; row++)
{
    int[] currentRow = Console.ReadLine()
        .Split(", ")
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = currentRow[col];
        sum += matrix[row, col];
    }
}

Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
Console.WriteLine(sum);