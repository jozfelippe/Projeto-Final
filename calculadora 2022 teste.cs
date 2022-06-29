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
            Console.WriteLine("Não é uma equação de segundo grau!");
        }
        else
        {
            delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine($"Como delta = {delta:N2}, a equação não possui raízes reais!");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"x1 = {x1:N2} e x2 = {x2:N2}");


            }
        }
    }
public static string ExibeSair()
    {
        Console.Clear();
        string saida;

        Console.WriteLine("Deseja sair do programa?");
        Console.WriteLine("S-Sim || N-Não");
        Console.Write("Escolha uma opção: ");
        saida = Console.ReadLine()!;

        switch (saida.ToUpper())
        {
            case "S":

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\nObrigado por usar meu programa!");
                Console.ResetColor();

                return saida;

            case "N" or "n":
                return saida;

                default:
                return "N";
        }
    }
    public static void ExibeMiniintroduçao()
    {
        Console.Clear();
        Console.WriteLine("-- Sobre o desenvolvedor e seu projeto --\n");

        Console.WriteLine("Meu nome é Jose Felipe, tenho 17 anos e faço curso técnico de Informática, na Etec Adolpho Berezin.");

        Console.WriteLine("O prjeto foi desenvolvido com o intuito de praticar os ensinamentos dados em aula, por a prova os conhecimentos e mostrar nosso esforço aos professores que ministram as aulas de Programação de Computadores (PC)!\n");
        Console.WriteLine("Saudações aos professores, Ermogenes Palacio e Diego Neri, e um muito obrigado pelos ensinamentos dados em aula, por tirar nossas dúvidas e fazer com que possamos aprender com nossos erros, e assim melhorar cada vez mais.");


        Console.WriteLine("Pressione uma tecla para continuar\n");
        Console.ReadKey();
    }

}
 