using System;
using System.Text;

namespace Ambrosial.Ambrosial.Classes
{
    public static class AmbrosialEncrypt
    {
        private static readonly string alphaChars = @"!#$%&*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\]^_`abcdefghijklmnopqrstuvwxyz{}~";

        public static string GenerateRandomString(int length)
        {
            var random = new Random();
            var sb = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                sb.Append(alphaChars[random.Next(alphaChars.Length)]);
            }
            return sb.ToString();
        }

        public static string Encrypt(string inputString)
        {
            var rand = GenerateRandomString(15);
            var encrypted = Cipher.Encrypt(inputString, rand);
            return encrypted + "[AmbrosialPacket]" + rand;
        }

        public static string Decrypt(string inputString)
        {
            var decryptedBasePacket = Cipher.DecryptBase64(inputString);
            var packInfo = decryptedBasePacket.Split(new[] { "[AmbrosialPacket]" }, StringSplitOptions.RemoveEmptyEntries);
            return Cipher.Decrypt(packInfo[0], packInfo[1]);
        }
    }
}

