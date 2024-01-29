Stack<int> stack = new Stack<int>();

stack.Push(0);
stack.Push(1);
stack.Push(34);
stack.Push(123);
stack.Push(42);
stack.Push(44);
stack.Push(12);
stack.Push(25);
stack.Push(867);


while (stack.Count != 0)
{
    int element = stack.Pop();
    Console.WriteLine(element);
}