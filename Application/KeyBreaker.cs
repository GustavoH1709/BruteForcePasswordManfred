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
            //_process.StartInfo.Arguments = key;
            //_process.Start();
            //_process.WaitForExit();

            return false;
        }
    }
}
