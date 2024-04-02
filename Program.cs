using BruteForcePasswordManfred.Application;

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
            keyGenerator.Run();

            Console.WriteLine("Execução do programa terminou");
        }
    }
}
