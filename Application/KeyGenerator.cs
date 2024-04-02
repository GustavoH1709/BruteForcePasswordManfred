namespace BruteForcePasswordManfred.Application
{
    public class KeyGenerator(string exePath)
    {
        private readonly string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private readonly int _length = 6;

        private readonly KeyBreaker _kb = new(exePath);
        private bool _keyFound;

        public void Run()
        {
            Console.WriteLine("Brute force recursivo iniciado...");
            GeneratePasswordsRecursive(chars, _length, "");
        }

        private void GeneratePasswordsRecursive(string chars, int length, string current)
        {
            if (length == 0)
            {
                _keyFound = _kb.TryBruteForce(current);
            }
            else
            {
                foreach (char c in chars)
                {
                    if (_keyFound)
                    {
                        if (current.Length == _length)
                        {
                            Console.WriteLine($"A senha é '{current}'");
                        }

                        break;
                    }

                    GeneratePasswordsRecursive(chars, length - 1, current + c);
                }
            }
        }
    }
}
