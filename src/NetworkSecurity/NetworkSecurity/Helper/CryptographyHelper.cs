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
                case EnumCryptographyAlgorithms.Sha1: return new SHA1CryptoServiceProvider();// S