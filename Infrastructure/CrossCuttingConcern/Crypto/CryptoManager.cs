using System.Security.Cryptography;
using System.Text;

namespace Infrastructure.CrossCuttingConcern.Crypto
{
    public class CryptoManager
    {
        public static string MD5Encrypt(string orginalValue)
        {
            MD5 md5 = MD5.Create();
            byte[] inputByte = Encoding.ASCII.GetBytes(orginalValue);
            byte[] hashByte = md5.ComputeHash(inputByte);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashByte.Length; i++)
            {
                sb.Append(hashByte[i].ToString("X2"));
            }

            return sb.ToString();
        }

        public static string SHA1Encrypt(string orginalValue)
        {
            SHA1 sha1 = SHA1.Create();

            byte[] inputByte = Encoding.ASCII.GetBytes(orginalValue);
            byte[] hashByte = sha1.ComputeHash(inputByte);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashByte.Length; i++)
            {
                sb.Append(hashByte[i].ToString("X2"));
            }

            return sb.ToString();
        }

        public static string AESEncrypt(string clearText, string encryptionKey)
        {
            byte[] clearByte = Encoding.Unicode.GetBytes(clearText);
            using (Aes encrytor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x76, 0x64, 0x65, 0x76 });
                encrytor.Key = pdb.GetBytes(32);
                encrytor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms,encrytor.CreateEncryptor(),CryptoStreamMode.Write))
                    {
                        cs.Write(clearByte, 0, clearByte.Length);
                        cs.Close();
                    }
                }
            }
            return clearText;
        }

        public static string AESDecrypt(string cipherText, string encryptionKey)
        {
            byte[] clearByte = Encoding.Unicode.GetBytes(cipherText);
            using (Aes encrytor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x76, 0x64, 0x65, 0x76 });
                encrytor.Key = pdb.GetBytes(32);
                encrytor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encrytor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearByte, 0, clearByte.Length);
                        cs.Close();
                    }
                }
            }
            return cipherText;
        }
    }
}
