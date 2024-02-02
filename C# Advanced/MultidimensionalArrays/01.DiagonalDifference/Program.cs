

int input = int.Parse(Console.ReadLine());

int rows = input;
int cols = input;

int[,] matrix = new int[rows, cols];

int primaryDiagonal = 0;
int secondaryDiagonal = 0;

for (int row = 0; row < rows; row++)
{
    int[] currentRow = Console.ReadLine()
        .Split(' ')
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = currentRow[col];
    }
}

for (int row = 0; row < rows; row++)
{
    primaryDiagonal += matrix[row, row];
    secondaryDiagonal += matrix[row, cols - row - 1];
}

int totalSum = Math.Abs(primaryDiagonal - secondaryDiagonal);
Console.WriteLine(totalSum);