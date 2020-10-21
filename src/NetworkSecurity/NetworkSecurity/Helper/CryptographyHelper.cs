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
                case EnumCryptographyAlgorithms.Des: return new DESCryptoServicePro