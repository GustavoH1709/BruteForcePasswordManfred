using System.Text;

namespace BruteForcePasswordManfred.Application
{
    public class FileSaver
    {
        private readonly string _desktopFilePath;

        public FileSaver()
        {
            _desktopFilePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\deno_aut_{Guid.NewGuid()}.txt";
        }

        public void CriaArquivoComSenha(string senha)
        {
            using (FileStream fs = File.Create(_desktopFilePath))
            {
                // Add some text to file
                byte[] text = new UTF8Encoding(true).GetBytes(senha);
                fs.Write(text, 0, text.Length);
                fs.Close();
            }
        }
    }
}
