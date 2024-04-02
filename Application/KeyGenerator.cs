using BruteForcePasswordManfred.DTO;

namespace BruteForcePasswordManfred.Application
{
    public class KeyGenerator(string exePath)
    {
        private readonly string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private readonly int _length = 6;

        private readonly KeyBreaker _kb = new(exePath);

        private bool found;
        private string key;

        public KeyGeneratorDTO Run()
        {
            Console.WriteLine("Brute force recursivo iniciado...");
            GeneratePasswordsRecursive(chars, _length, "");
            KeyGeneratorDTO resultado = new(found, key);
            return resultado;
        }

        private void GeneratePasswordsRecursive(string chars, int length, string current)
        {
            if (length == 0)
            {
                found = _kb.TryBruteForce(current);
            }
            else
            {
                foreach (char c in chars)
                {
                    if (found)
                    {
                        if (current.Length == _length)
                        {
                            key = current;
                        }

                        break;
                    }

                    GeneratePasswordsRecursive(chars, length - 1, current + c);
                }
            }
        }
    }
}
