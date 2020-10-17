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
                case EnumC