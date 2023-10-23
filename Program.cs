internal class Program
{
   private static void Main(string[] args)
   {
      // Soma();
      // Subtracao();
      // Divisao();
      Menu();
   }

   static void Menu()
   {
      Console.Clear();
      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("4 - Multiplicação");
      Console.WriteLine("5 - Sair");

      Console.WriteLine("-------------------------");

      Console.WriteLine("Selecione uma opção: ");
      short resposta = short.Parse(Console.ReadLine());

      switch (resposta)
      {
         case 1: Soma(); break;
         case 2: Subtracao(); break;
         case 3: Divisao(); break;
         case 4: Multiplicacao(); break;
         case 5: Environment.Exit(0); break;
         default: Menu(); break;
      }

   }

   static void Soma()
   {
      Console.Clear();

      Console.WriteLine("Primeiro Valor");
      double valor1 = double.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor");
      double valor2 = double.Parse(Console.ReadLine());

      Console.WriteLine("");

      double resultado = valor1 + valor2;

      Console.WriteLine($"O resultado da soma é {resultado}");
      Console.ReadKey();
      Menu();
   }

   static void Subtracao()
   {
      Console.Clear();

      Console.WriteLine("Primeiro Valor");
      double valor1 = double.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor");
      double valor2 = double.Parse(Console.ReadLine());

      Console.WriteLine("");

      double resultado = valor1 - valor2;

      Console.WriteLine($"O resultado da subtração é {resultado}");
      Console.ReadKey();
      Menu();
   }

   static void Divisao()
   {
      Console.Clear();

      Console.WriteLine("Primeiro Valor");
      double valor1 = double.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor");
      double valor2 = double.Parse(Console.ReadLine());

      Console.WriteLine("");

      double resultado = valor1 / valor2;

      Console.WriteLine($"O resultado da divisão é {resultado}");
      Console.ReadKey();
      Menu();
   }

   static void Multiplicacao()
   {
      Console.Clear();

      Console.WriteLine("Primeiro Valor");
      double valor1 = double.Parse(Console.ReadLine());

      Console.WriteLine("Segundo Valor");
      double valor2 = double.Parse(Console.ReadLine());

      Console.WriteLine("");

      double resultado = valor1 * valor2;

      Console.WriteLine($"O resultado da multiplicação é {resultado}");
      Console.ReadKey();
      Menu();
   }

}