static double area_circulo(double radio)
{
    double area;
    area = radio * radio * Math.PI;

    Console.WriteLine("El area del circulo es " + area);
    return area;
}

static double perimetro_rectangulo(double ancho, double altura)
{
    double perimetro;
    perimetro = 2 * (ancho + altura);

    Console.WriteLine($"el perimetro del rectangulo es " + perimetro);
    return perimetro;
}

static double promedio_lista(double n1, double n2, double n3, double n4)
{
    double suma, promedio;
    suma = n1 + n2 + n3 + n4;
    promedio = suma / 4;

    Console.WriteLine("El promedio es de: " + promedio);
    return promedio;
}

static int num_par_impar(int num)

{
    if (num % 2 == 0)
    {
        Console.WriteLine( + num +" es par");
    }
    else
    {
        Console.WriteLine( + num + " es impar");
    }
    return num;
}

static string cad_Mayu(string cadena)
{
    string mayuscula = cadena.ToUpper();
    Console.WriteLine(mayuscula);
    return mayuscula;
}

static double dist_cart(double x1, double y1, double x2, double y2) {

    double distancia;

    distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

    Console.WriteLine("La distancia es de: " + distancia);
    return distancia;  
        }

static int suma_n(int n)
{
    int suma = 0;

    for (int i = 1; i <= n; i++)
    {
        suma += i;
    }
    Console.WriteLine("La suma es " + suma);
    return suma;
}

static int factorial ( int n)
{
    int factorial = 1;
    for (int i = 1; i <= n; i++)
    {
        factorial = factorial * i;

    }
    Console.WriteLine("el factorial de " + n + " es: " + factorial);
    return factorial;
}

area_circulo(3);
perimetro_rectangulo(10, 5);
promedio_lista(10, 5, 8, 6);
num_par_impar(5);
cad_Mayu("hola Mundo");
dist_cart(1.5, 2, 2, 2.5);
suma_n(5);
factorial(5);

