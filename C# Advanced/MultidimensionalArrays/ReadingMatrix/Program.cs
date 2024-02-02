

int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());

int counter = 0;

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.WriteLine($"matrix[{row}, {col}]=");
        matrix[row, col] = int.Parse(Console.ReadLine());
    }
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write(matrix[row, col] + " ");
    }

    Console.WriteLine();
}