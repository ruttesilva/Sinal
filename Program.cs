int numeroDigitado;

Console.Write("Digite um número: ");
numeroDigitado = Convert.ToInt32(Console.ReadLine());

if (numeroDigitado < 0)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Negativo");
}
else if (numeroDigitado > 0)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Positivo");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Zero");
}

Console.ResetColor();