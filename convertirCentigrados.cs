class convertirCentigrados
{
    private int convertirAKelvin(int Centigrados)
    {
        return Centigrados + 273;
    }

    private int convertirAFahrenheit(int Centigrados)
    {
        return Centigrados * 18 / 10 + 32;
    }

    public void getCentigradosConvertidos(int Centigrados)
    {
        Console.WriteLine("Kelvin = " + convertirAKelvin(Centigrados));
        Console.WriteLine("Fahrenheit = " + convertirAFahrenheit(Centigrados));
    }
}