using System;
using System.Security.Cryptography;
using System.Text;

namespace NetworkSecurity.Helper
{
    public static class CryptographyHelper
    {
        public static object GetCryptoServiceProvider(this EnumCryptographyAlgorithms algorithm)
        {
            switch (algorithm)
            {
                // Symmetric Algorithms
                case EnumCryptographyAlgorithms.Aes: return new AesCryptoServiceProvider();// :AES  :SymmetricAlgorithm
                case EnumCryptographyAlgorithms.Des: return new DESCryptoServiceProvider();// :DES :SymmetricAlgorithm
                case EnumCryptographyAlgorithms.TripleDes: return new TripleDESCryptoServiceProvider(); // :TripleDES :SymmetricAlgorithm
                case EnumCryptographyAlgorithms.Rc2: return new RC2CryptoServiceProvider();// :RC2 :SymmetricAlgorithm

                // Hash Algorithms
                case EnumCryptographyAlgorithms.Md5: return new MD5CryptoServiceProvider();// MD5  :HashAlgorithm
                case EnumCryptographyAlgorithms.Sha1: return new SHA1CryptoServiceProvider();// SHA1  :HashAlgorithm
                case EnumCryptographyAlgorithms.Sha256: return new SHA256CryptoServiceProvider();// SHA256 :HashAlgorith
                case EnumCryptographyAlgorithms.Sha384: return new SHA384CryptoServiceProvider();// SHA384  :HashAlgorithm
                case EnumCryptographyAlgorithms.Sha512: return new SHA512CryptoServiceProvider();// SHA512  :HashAlgorithm

                default: return new AesCryptoServiceProvider();
            }
        }

        public static byte[] Encrypt(this byte[] toEncryptArray, string key, EnumCryptographyAlgorithms algorithm)
        {
            byte[] resultArray = null;

            var objAlgorithmProvider = algorithm.GetCryptoServiceProvider();

            if (objAlgorithmProvider is SymmetricAlgorithm symmetricAlg)
            {
                //set the secret key for the symmetric algorithm
                symmetricAlg.SetupSymmetric(key);

                var cTransform = symmetricAlg.CreateEncryptor();
                //transform the specified region of bytes array to resultArray
                resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                //Release resources held by symmetric Encryptor
                symmetricAlg.Clear();
            }
            else if (objAlgorithmProvider is HashAlgorithm hashAlg)
            {
                resultArray = hashAlg.ComputeHash(toEncryptArray);
                //Release resources held by hasher
                hashAlg.Clear();
            }

            return resultArray;
        }

        public static string Encrypt(this string toEncrypt, string key, EnumCryptographyAlgorithms algorithm)
        {
            // string --> (utf8) byte[] --> encrypt ---> byte[] ---> (base64) string
            var toEncryptArray = Encoding.UTF8.GetBytes(toEncrypt);
            var encryptedBytes = toEncryptArray.Encrypt(key, algorithm);

            //Return the encrypted data into unreadable string format
            return Convert.ToBase64String(encryptedBytes, 0, encryptedBytes.Length);
        }

        public static byte[] Decrypt(this byte[] cipherArray, string key, EnumCryptographyAlgorithms algorithm)
        {
            byte[] resultArray = null;

            var objAlgorithmProvider = algorithm.GetCryptoServiceProvider();

            if (objAlgorithmProvider is SymmetricAlgorithm symmetricAlg)
            {
                //set the secret key for the symmetric algorithm
                symmetricAlg.SetupSymmetric(key);

                var cTransform = symmetricAlg.CreateDecryptor();
                resultArray = cTransform.TransformFinalBlock(cipherArray, 0, cipherArray.Length);

                //Release resources held by symmetric Encryptor
                symmetricAlg.Clear();
            }

            return resultArray;
        }

        public static string Decrypt(this string cipherString, string key, EnumCryptographyAlgorithms algorithm)
        {
      