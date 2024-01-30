
string expression = Console.ReadLine();

Stack<int> brackets = new Stack<int>();

for (int i = 0; i < expression.Length; i++)
{
    if (expression[i] == '(')
    {
        brackets.Push(i);
    }
    else if (expression[i] == ')')
    {
        int startIndex = brackets.Pop();
        string contents = expression.Substring(startIndex, i - startIndex + 1);
        Console.WriteLine(contents);
    }
}