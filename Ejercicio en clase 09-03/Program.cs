//Elercicio 1
static void suma()
{
    int respuesta, val1, val2 = 0;
    val1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese valor 2:");
    val2 = Convert.ToInt32(Console.ReadLine());
    respuesta = val1 + val2;
    Console.WriteLine("Suma= " + respuesta);
}


//Ejercicio 2
static void nombre()
{
    Console.WriteLine("Cual es su nombre:");
    String nombre = Console.ReadLine();
    Console.WriteLine("Mucho gusto: " + nombre);
}


//Ejercicio 3
static void edad()
{
    Console.WriteLine("Ingrese su año de nacimiento:");
    int yearBorn = Convert.ToInt32(Console.ReadLine());
    int edad = 2024 - yearBorn;
    Console.WriteLine("Su edad es:" + edad);
}


static int suma1(int val1, int val2, int val3);
{
    return val1 + val2 + val3;
}