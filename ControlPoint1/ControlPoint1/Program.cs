using ControlPoint1;
class Program
{
    static void Main(string[] args)
    {
        Property[] properties = new Property[10];
        properties[0] = new Appartment(5000000, 90);
        properties[1] = new Appartment(6000000, 150);
        properties[2] = new Appartment(7000000, 350);
        properties[3] = new Car(3000000, 2000);
        properties[4] = new Car(2500000, 2500);
        properties[5] = new Car(4000000, 3000);
        properties[6] = new Boat(400000, 2666);
        properties[7] = new Boat(500000, 3000);
        properties[8] = new CountryHouse(8000000, 200);
        properties[9] = new CountryHouse(9000000, 350);

        foreach (var property in properties)
        {
            Console.WriteLine(property.ToString());
        }
    }
}