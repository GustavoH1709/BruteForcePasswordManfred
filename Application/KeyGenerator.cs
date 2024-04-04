namespace BruteForcePasswordManfred.Application
{
    public class KeyGenerator(string exePath)
    {
        private readonly string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private readonly int _length = 6;

        private readonly KeyBreaker _kb = new(exePath);
        private bool _keyFound;
        private string key;

        private FileSaver _fileSaver;

        public void Run()
        {
            _fileSaver = new FileSaver();
            Console.WriteLine("Brute force recursivo iniciado...");
            GeneratePasswordsRecursive(chars, _length, "");
        }

        private void GeneratePasswordsRecursive(string chars, int length, string current)
        {
            if (length == 0)
            {
                _keyFound = _kb.TryBruteForce(current);

                if (_keyFound)
                {
                    Console.WriteLine($"A senha é '{current}'");
                    _fileSaver.CriaArquivoComSenha(current);
                }
            }
            else
            {
                foreach (char c in chars)
                {
                    if (_keyFound)
                    {
                        break;
                    }

                    GeneratePasswordsRecursive(chars, length - 1, current + c);
                }
            }
        }
    }
}
