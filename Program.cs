using Calculadora_de_Macros.BancoDeDados;
using Calculadora_de_Macros.GlobalStatic;

namespace Calculadora_de_Macros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Armazenagem global da lista de alimentos adicionado e outros futuros componentes compartilhaveis
            var init = new Global();

            while (true)
            {
                Console.Write("Adicione o nome do alimento: ");
                var input = Console.ReadLine();

                if (input == "Arroz")
                {
                    Console.Write("Adicione a gramagem do alimento: ");
                    var input2 = Console.ReadLine();

                    if (double.TryParse(input2, out double resultado)){
                        init.AdicionarAlimento(new ArrozCru(resultado));
                        Console.WriteLine("Arroz Adicionado!");
                        Console.WriteLine($"Calorias Totais: {init.ObterSomaCalorias()}");
                        Console.WriteLine($"Carboidratos Totais: {init.ObterSomaCarboidratos()}");
                        Console.WriteLine($"Proteinas Totais: {init.ObterSomaProteinas()}");
                        Console.WriteLine($"Gorduras Totais: {init.ObterSomaGorduras()}");
                        Console.WriteLine($"Fibras Totais: {init.ObterSomaFibras()}");
                    }
                }
                else
                {
                    Console.WriteLine("Alimento não cadastrado!");
                }
                Console.WriteLine("Adicione outro alimento...");
            }


        }
    }
}