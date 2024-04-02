using BruteForcePasswordManfred.Application;
using BruteForcePasswordManfred.DTO;

namespace BruteForcePasswordManfred
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                throw new Exception("Informe o caminho para o arquivo executavel");
            }

            string exePath = args.First();

            KeyGenerator keyGenerator = new(exePath);
            KeyGeneratorDTO resultado = keyGenerator.Run();

            if (resultado.HasFound)
            {
                Console.WriteLine($"Senha é '{resultado.Key}'");
            }
            else
            {
                Console.WriteLine($"Senha não encontrada");
            }

            Console.WriteLine("Execução do programa terminou");
        }
    }
}
