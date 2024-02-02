
Queue<string> strings = new Queue<string>();

string command = Console.ReadLine();

while(command != "End")
{
    if(command == "Paid")
    {
        while (strings.Count > 0)
        {
            string name = strings.Dequeue();

        for(int i = 0; i <= strings.Count + 1; i++)
        {
            string name = strings.Dequeue();

            Console.WriteLine(name);
        }
    }
    else
    {
      strings.Enqueue(command);
    }
    command = Console.ReadLine();
}

Console.WriteLine($"{strings.Count} people remaining.");