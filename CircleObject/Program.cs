using CircleObject;

Console.WriteLine("Welcome to the Circle Tester");
bool runProgram = true;
while (true)
{
    Console.WriteLine("Please enter a radius");
    double radius = double.Parse(Console.ReadLine());

    List<Circle> Objects = new List<Circle>()
{
    new Circle(radius)
};

    foreach (Circle size in Objects)
    {
        Console.WriteLine($"{size.radius} {size.CalculateArea(radius)} {size.CalculateCircumference(radius)}");
    }
    Console.WriteLine("Would you like to continue? y/n?");
    string response = Console.ReadLine().ToLower().Trim();

    if (response == "y")
    {
        runProgram = true;
    }
    else if (response == "n")
    {
        runProgram = false;
        Console.WriteLine($"GoodBye! You made {Objects.Count} circles");
        
    }
}