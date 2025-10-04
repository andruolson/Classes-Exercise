namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            
            //Dot notation
            car1.Year = 1978;
            car1.Make = "Nissan";
            car1.Model = "Datsun";
            

            car1.CarDetails();

        }
    }
}
