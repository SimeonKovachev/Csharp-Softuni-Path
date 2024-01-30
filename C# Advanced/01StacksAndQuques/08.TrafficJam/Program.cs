Queue<string> cars = new Queue<string>();

int carsToPass = int.Parse(Console.ReadLine());

string command = Console.ReadLine();

int carsPassed = 0;

while (command != "end")
{

    if(command == "green")
    {
        int i = 0;
        while (cars.Count > 0 && i < carsToPass)
        {
            string car = cars.Dequeue();

            Console.WriteLine($"{car} passed!");
            i++;
            carsPassed++;
        }  
    }

    else
    {
        cars.Enqueue(command);
    }

    command = Console.ReadLine();
}

Console.WriteLine($"{carsPassed} cars passed the crossroads.");