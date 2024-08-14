class ejerciciosPractica
{   
    public void animalYholaM()
    {
        Console.WriteLine("Hola");
        Console.WriteLine("Alfredo");


        Console.WriteLine("Cual es tu animal Favorito");
        string animalFavorito = Console.ReadLine();
        Console.WriteLine("El " + animalFavorito + " tambien es mi animal favorito");
    }
    public void saludaNombre()
    {
        Console.WriteLine("Ingresa tu nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine("Hola encantado de conocerte, " + nombre);
    }

    public void superficeYVolumenDeCirculo()
    {
        Console.WriteLine("Ingresa El radio Del Circulo");
        float radio = Convert.ToSingle(Console.ReadLine());
        float pi = 3.1415926535f;

        float superficie = 4 * pi * (radio * radio);
        float volumen = 4/3 * pi * (radio * radio * radio);

        Console.WriteLine("El volumen del circulo es " + volumen);
        Console.WriteLine("La superfice del circulo es " + superficie);
    }

    public void operacionesAritmeticas()
    {   
        Console.WriteLine("Ingresa el primer numero diferente a 0");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa el segundo numero diferente a 0");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} + {1} = {2}", numero1, numero2, numero1 + numero2);
        Console.WriteLine("{0} - {1} = {2}", numero1, numero2, numero1 - numero2);
        Console.WriteLine("{0} x {1} = {2}", numero1, numero2, numero1 * numero2);
        Console.WriteLine("{0} / {1} = {2}", numero1, numero2, numero1 / numero2);
        Console.WriteLine("{0} mod {1} = {2}", numero1, numero2, numero1 % numero2);
    }
    
}
