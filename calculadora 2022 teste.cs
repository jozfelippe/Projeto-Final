public class Calculadora
{
    public static void CalcularSoma()
    {
        double a, b, resultado;

        Console.WriteLine("--- Soma A+B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = Aritmetica.Soma(a, b);

        Console.WriteLine($"{a} somado com {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }

    public static void CalcularSubtracao()
    {
        double a, b, resultado;

        Console.WriteLine("--- Subtração A-B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = Aritmetica.Subtracao(a, b);

        Console.WriteLine($"{a} subtraindo {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }

    public static void CalcularMultiplicacao()
    {
        double a, b, resultado;

        Console.WriteLine("--- Multiplicação A*B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = Aritmetica.Multiplicacao(a, b);

        Console.WriteLine($"{a} multiplicado por {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }

    public static void CalcularDivisao()
    {
        double a, b, resultado;

        Console.WriteLine("--- Divisão A/B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        if (b == 0)
        {
            Console.WriteLine("\nNão é possível dividir por zero.");
        }
        else
        {
            resultado = Aritmetica.Divisao(a, b);

            Console.WriteLine($"{a} dividido por {b} é {resultado}");
        }

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        return;
    }

    public static void CalcularExponenciação()
    {
        Console.Clear();
        double Exponenciação, x, y;

        Console.WriteLine("--- Exponenciação ---\n");
        Console.WriteLine("Digite os valores");

        Console.Write("Base: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Exponente: ");
        y = Convert.ToDouble(Console.ReadLine());

        Exponenciação = Math.Pow(x, y);

        Console.WriteLine($"O Resultado é: {Exponenciação}");

        Console.Write("Pressione uma tecla para continuar");
        Console.ReadKey();
    }
    public static void CalcularRadiciacao()
    {
        Console.Clear();
        double raiz, x;

        Console.WriteLine("--- Radiciação ---");
        Console.WriteLine("Digite os valores");
        Console.Write("Numero: ");
        x = Convert.ToDouble(Console.ReadLine());

        raiz = Math.Sqrt(x);

        Console.WriteLine($"O resultado é: {raiz}");

        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadKey();
    }
    public static void CalcularBhaskara()
    {
        double a, b, c, delta, x1, x2;

        Console.WriteLine("-- Equação do segundo grau --");

        Console.Write("(a): ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("(b): ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("(c): ");
        c = Convert.ToDouble(Console.ReadLine());

        if (a == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Beep();
            Console.WriteLine("Não é uma equação de segundo grau!");
        }
        else
        {
            delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep();
                Console.WriteLine($"Como delta = {delta:N2}, a equação não possui raízes reais!");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"x1 = {x1:N2} e x2 = {x2:N2}");


            }
        }
    }
}
 