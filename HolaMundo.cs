/* Ejercicio 3
   date: 14/8/2024
 */

public class HolaMundo
{
    public static void Main(string[] args)
    {
        //ejerciciosPractica Ejercicios = new ejerciciosPractica();

        //Ejercicios.animalYholaM();
        //Ejercicios.saludaNombre();
        //Ejercicios.superficeYVolumenDeCirculo();
        //Ejercicios.operacionesAritmeticas();

        convertirCentigrados convercion = new convertirCentigrados();
        Console.WriteLine("Ingresa los centigrados a convertir");
        int Centigrados = Convert.ToInt32(Console.ReadLine());

        convercion.getCentigradosConvertidos(Centigrados);
    }
}