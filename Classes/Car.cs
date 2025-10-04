namespace Classes;

public class Car
{
    
    //Properties - PascalCasing
    
    //Vehicle Make Property (string)
    public string Make { get; set; }
    
    //Vehicle Model Property (string)
    public string Model { get; set; }
    
    //Vehicle Year Property (int)
    public int Year { get; set; }

    public void CarDetails()
    {
        Console.WriteLine($"{Year} {Make} {Model}");
    }
    
}