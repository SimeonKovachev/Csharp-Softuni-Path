
string input = Console.ReadLine();

string[] tokens = input.Split(' ');

Queue<string> stack = new Queue<string>(tokens);

int result = int.Parse(stack.Dequeue());

while (stack.Count > 0)
{
    string op = stack.Dequeue();

    if (stack.Count > 0)
    {
        int nextNumber = int.Parse(stack.Dequeue());

        if (op == "+")
        {
            result += nextNumber;
        }
        else if (op == "-")
        {
            result -= nextNumber;
        }
    }
}

Console.WriteLine(result);