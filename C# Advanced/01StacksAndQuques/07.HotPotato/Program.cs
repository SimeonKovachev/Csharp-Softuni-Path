
Queue<string> children = new Queue<string>(Console.ReadLine().Split());
int n = int.Parse(Console.ReadLine());

int toses = 1;

while (children.Count > 1)
{
    string childWithPotato = children.Dequeue();
    if(toses == n)
    {
        Console.WriteLine($"Removed {childWithPotato}");
        toses = 0;
    }
    else
    {
        children.Enqueue(childWithPotato);
    }

    toses++;
}

Console.WriteLine($"Last is {children.Dequeue()}");