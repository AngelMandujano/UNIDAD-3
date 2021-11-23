// See https://aka.ms/new-console-template for more information
int valor1 = 0;
int valor2 = 0;
int valor3 = 0;
int total = 0;
Console.WriteLine("ingrese el simbolo de la operacion que desea realizar ");
Console.WriteLine("+ suma");
Console.WriteLine("- resta");
Console.WriteLine("* multiplicacion");
Console.WriteLine("/ division");
string operacion = Console.ReadLine();
Console.WriteLine("ingresa el primer valor");
valor1 = int.Parse(Console.ReadLine());
Console.WriteLine("ingresa el segundo valor ");
valor2 = int.Parse(Console.ReadLine());
Console.WriteLine("ingresa el tercer valor ");
valor3 = int.Parse(Console.ReadLine());
switch (operacion)
{
    case "+":
        total = valor1 + valor2 + valor3;
        Console.WriteLine("El resultado es: " + total);
        break;
    case "-":
        total = valor1 - valor2 - valor3;
        Console.WriteLine("El resultado es: " + total);
        break;
    case "*":
        total = valor1 * valor2 * valor3;
        Console.WriteLine("El resultado es: " + total);
        break;
    case "/":
        total = valor1 / valor2 / valor3;
        Console.WriteLine("El resultado es: " + total );
        break;
{
    
}
}

