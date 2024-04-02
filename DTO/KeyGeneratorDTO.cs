namespace BruteForcePasswordManfred.DTO
{
    public class KeyGeneratorDTO
    {
        public bool HasFound { get; set; }
        public string Key { get; set; }

        public KeyGeneratorDTO()
        {
            HasFound = false;
            Key = string.Empty;
        }

        public KeyGeneratorDTO(bool hasFound, string key)
        {
            HasFound = hasFound;
            Key = key;
        }
    }
}
