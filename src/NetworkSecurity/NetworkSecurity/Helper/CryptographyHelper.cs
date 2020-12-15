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
            else 