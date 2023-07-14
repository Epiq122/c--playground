var temperature = new Temperature(TemperatureUnit.Celsius, 32);
Console.WriteLine($"Temperature: {temperature.ValueInCelsius:0.0}C");

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
      return Unit switch
      {
        TemperatureUnit.Celsius when Value > 100 => Math.Round(Value, 0),
        TemperatureUnit.Celsius => Value,
        TemperatureUnit.Fahrenheit => (Value - 32) * 5 / 9,
        TemperatureUnit.Kelvin => Value - 273.15m,
        _ => 0,// Default value if the unit is not recognized
      };
    }
  }
}