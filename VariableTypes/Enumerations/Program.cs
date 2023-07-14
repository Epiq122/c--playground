var temperature = new Temperature(TemperatureUnit.Celsius, 20);
Console.WriteLine($"Temperature is {temperature.Value} {temperature.Unit}");

var temperature2 = new Temperature(TemperatureUnit.Fahrenheit, 68);
Console.WriteLine($"Temperature is {temperature2.Value} {temperature2.Unit}");

var temperature3 = new Temperature(TemperatureUnit.Kelvin, 293.15m);
Console.WriteLine($"Temperature is {temperature3.Value} {temperature3.Unit}");

// Underlying values are int
Console.WriteLine((int)TemperatureUnit.Celsius);
Console.WriteLine((int)TemperatureUnit.Fahrenheit);
Console.WriteLine((int)TemperatureUnit.Kelvin);

//Casting values from int to TemperatureUnit
int temperature4 = 2;
TemperatureUnit kelvin = (TemperatureUnit)temperature4;
Console.WriteLine($"Temperature is {kelvin}"); 


enum TemperatureUnit
{
    Celsius,
    Fahrenheit,
    Kelvin,
}

class Temperature
{
    public Temperature(TemperatureUnit unit, decimal value)
    {
        Unit = unit;
        Value = value;
    }

    public TemperatureUnit Unit { get; set; }
    public decimal Value { get; set; }

    public decimal ValueInCelsius
    {
        get
        {
            if (Unit == TemperatureUnit.Celsius)
            {
                return Value;
            }
            if (Unit == TemperatureUnit.Fahrenheit)
            {
                return (Value - 32) * 5 / 9;
            }
            if (Unit == TemperatureUnit.Kelvin)
            {
                return Value - 273.15m;
            }
            return 0; // Default value if the unit is not recognized
        }
    }
}