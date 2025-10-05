namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
           var celsius = TempConverter.FahrenheitToCelsius(32); //0
           var fahrenheit = TempConverter.CelsiusToFahrenheit(0); //32

            Console.WriteLine("After Conversion:");
            Console.WriteLine($"Celsius {celsius}");
            Console.WriteLine($"Fahrenheit {fahrenheit}");

        }
    }
}
