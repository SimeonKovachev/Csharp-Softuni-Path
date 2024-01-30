
Queue<string> strings = new Queue<string>();

string command = Console.ReadLine();

while(command != "End")
{
    if(command == "Paid")
    {
<<<<<<< HEAD
        while (strings.Count > 0)
        {
            string name = strings.Dequeue();
=======
        for(int i = 0; i <= strings.Count + 1; i++)
        {
            string name = strings.Dequeue();

>>>>>>> 51f5195331b051c136b901c9755ae743f77f3879
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