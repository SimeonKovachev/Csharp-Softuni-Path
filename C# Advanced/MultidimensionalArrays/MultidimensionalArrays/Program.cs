int[,] matrix = new int[3, 3];

matrix[0, 0] = 1;
matrix[0, 1] = 2;
matrix[0, 2] = 3;

matrix[1, 0] = 4;
matrix[1, 1] = 5;
matrix[1, 2] = 6;

matrix[2, 0] = 7;
matrix[2, 1] = 8;
matrix[2, 2] = 9;

for(int row = 0; row < matrix.GetLength(0); row++)
{
    for(int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row, col] + " ");
    }

    Console.WriteLine();
}


/*//other syntaxies for matrix
int[,] ints = new int[4, 3] 
{ 
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 },
    { 10, 11, 12 }
};


//list matrix
List<List<int>> matrix2 = new List<List<int>>()
{
    new List<int> { 1, 2, 3 },
    new List<int> { 4, 5, 6 },
    new List<int> { 7, 8, 9 },
    new List<int> { 10, 11, 12 }
};*/