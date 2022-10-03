namespace ExceptionStoringServiceClassicWebApp.Exstensions
{
    public static class Extensions
    {
        public static int GetDeterministicHashCode(this string str)
        {
            unchecked
            {
                int hash1 = (5393 << 16) + 5393;
                int hash2 = hash1;
                int maxI = str.Length - 1;
                for (int i = 0; i < str.Length; i += 2)
                {
                    hash1 = ((hash1 << 5) + hash1) ^ str[i];
                    if (i == maxI)
                        break;
                    hash2 = ((hash2 << 5) + hash2) ^ str[i + 1];
                }

                return hash1 + (hash2 * 1566083941);
            }
        }

    }
}
