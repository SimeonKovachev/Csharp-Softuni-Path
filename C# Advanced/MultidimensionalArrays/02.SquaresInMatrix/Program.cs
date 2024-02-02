


int[] input = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int rows = input[0];
int cols = input[1];

char[,] matrix = new char[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] currentRow = Console.ReadLine()
        .Split(' ')
        .ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = currentRow[col][0];
    }
}

int squareCount = 0;

for (int row = 0; row < rows - 1; row++)
{
    int sum = 0;
    for (int col = 0; col < cols - 1; col++)
    {
        if (matrix[row, col] == matrix[row, col + 1] &&
            matrix[row, col] == matrix[row + 1, col] &&
            matrix[row, col] == matrix[row + 1, col + 1])
        {
            squareCount++;
        }
    }
}
Console.WriteLine(squareCount);