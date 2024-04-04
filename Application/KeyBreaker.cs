using System.Diagnostics;

namespace BruteForcePasswordManfred.Application
{
    public class KeyBreaker
    {
        private readonly string _executablePath;
        private readonly Process _process;

        public KeyBreaker(string executablePath)
        {
            _executablePath = executablePath;
            _process = new();
            _process.StartInfo.FileName = _executablePath;
        }

        public bool TryBruteForce(string key)
        {
            Console.WriteLine($"Tentativa atual: {key}");

            _process.StartInfo.Arguments = $"administrador {key}";
            _process.StartInfo.UseShellExecute = false;
            _process.StartInfo.RedirectStandardOutput = true;
            _process.Start();
            _process.WaitForExit();

            string output = _process.StandardOutput.ReadToEnd();

            return output.Contains("acesso concedido");
        }
    }
}
