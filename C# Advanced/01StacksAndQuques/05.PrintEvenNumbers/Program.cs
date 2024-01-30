/*
Queue<string> tickets = new Queue<string>();

tickets.Enqueue("John");
tickets.Enqueue("Richard");
tickets.Enqueue("Amanda");
tickets.Enqueue("Terry");

*//*Console.WriteLine(tickets.Dequeue());
Console.WriteLine(tickets.Dequeue());
Console.WriteLine(tickets.Dequeue());*//*

while (tickets.Count > 0)
{
    string name = tickets.Dequeue();
    Console.WriteLine(name);
}*/

string input = Console.ReadLine();
string[] tokens = input.Split(' ');

Queue<int> queue = new Queue<int>(tokens.Select(token => int.Parse(token)));

List<int> evenNumbers = new List<int>();

while (queue.Count > 0)
{
    int number = queue.Dequeue();

    if(number % 2 == 0)
    {
        evenNumbers.Add(number);
    }
}

Console.WriteLine(string.Join(", ", evenNumbers));