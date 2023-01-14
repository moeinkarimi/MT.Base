using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MT.Base
{
    public class SecurityExtention
    {
        public static string GlobalDecryption(string textToDecrypted, string guid)
        {
            string str;
            if ((string.IsNullOrEmpty(textToDecrypted) ? false : !(textToDecrypted == "null")))
            {
                RijndaelManaged RijndaelCipher = new();
                byte[] EncryptedData = Convert.FromBase64String(textToDecrypted);
                Encoding aSCII = Encoding.ASCII;
                int length = guid.Length;
                byte[] Salt = aSCII.GetBytes(length.ToString());
                PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(guid, Salt);
                ICryptoTransform Decryptor = RijndaelCipher.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));
                MemoryStream memoryStream = new MemoryStream(EncryptedData);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, Decryptor, CryptoStreamMode.Read);
                byte[] PlainText = new byte[(int)EncryptedData.Length];
                int DecryptedCount = cryptoStream.Read(PlainText, 0, (int)PlainText.Length);
                memoryStream.Close();
                cryptoStream.Close();
                str = Encoding.Unicode.GetString(PlainText, 0, DecryptedCount);
            }
            else
            {
                str = null;
            }
            return str;
        }

        public static string GlobalEncryption(string textToEncrypted, string guid)
        {
            string base64String;
            if (!string.IsNullOrEmpty(textToEncrypted))
            {
                RijndaelManaged RijndaelCipher = new();
                byte[] PlainText = Encoding.Unicode.GetBytes(textToEncrypted);
                Encoding aSCII = Encoding.ASCII;
                int length = guid.Length;
                byte[] Salt = aSCII.GetBytes(length.ToString());
                PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(guid, Salt);
                ICryptoTransform Encryptor = RijndaelCipher.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write);
                cryptoStream.Write(PlainText, 0, (int)PlainText.Length);
                cryptoStream.FlushFinalBlock();
                byte[] CipherBytes = memoryStream.ToArray();
                memoryStream.Close();
                cryptoStream.Close();
                base64String = Convert.ToBase64String(CipherBytes);
            }
            else
            {
                base64String = null;
            }
            return base64String;
        }
    }
}
