namespace Properties_Kohnen_Christian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(); //assigns a sub class the name of car
            car.Make = "Mitsubishi"; //assigns the value as Mitsubishi
            car.Model = "Montero"; //assigns the value as Montero

            Console.WriteLine($"The make of the car is {car.Make} and the model of the car is {car.Model}"); //prints the two classes

            Car carnew = new Car(); //assigns a sub class the name of carnew
            car.Make = "Jeep"; //assigns the value as Jeep
            car.Model = "Cherokee"; //assigns the value as Cherokee

            Console.WriteLine($"The make of the car is {car.Make} and the model of the car is {car.Model}"); //prints the two classes

            Car car1 = new Car(); //assigns a sub class the name of car
            Console.WriteLine($"The make of the car is {car1.Make} and the model of the car is {car1.Model}"); //prints the class but leaves the two values of the maker and model empty
        }
    }
}