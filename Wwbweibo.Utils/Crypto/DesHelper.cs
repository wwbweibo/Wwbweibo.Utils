using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace Wwbweibo.Utils.Crypto
{
    public class DesHelper
    {
        public static byte[] DesEncrypt(byte[] data, byte[] key, byte[] IV)
        {
            using var provider = new DESCryptoServiceProvider();

            provider.Key = HandleKey(key);
            provider.IV = IV.Length == 8 ? IV : new byte[8];
            using var ct = provider.CreateEncryptor();
            using var ms = new MemoryStream();
            using var cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);
            cs.Write(data, 0, data.Length);
            cs.FlushFinalBlock();
            return ms.ToArray();
        }

        public static byte[] DesDecrypt(byte[] data, byte[] key, byte[] IV)
        {
            using var provider = new DESCryptoServiceProvider();
            provider.Key = HandleKey(key);
            provider.IV = IV.Length == 8 ? IV : new byte[8];
            using var ct = provider.CreateDecryptor();
            using var ms = new MemoryStream();
            using var cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);
            cs.Write(data, 0, data.Length);
            cs.FlushFinalBlock();
            return ms.ToArray();
        }

        private static byte[] HandleKey(byte[] key)
        {
            byte[] k;
            if (key.Length <= 8)
            {
                k = new byte[8];
                key.CopyTo(k, 0);
            }
            else
            {
                throw new ArgumentException("the given key is to long");
            }
            return k;
        }
    }
}