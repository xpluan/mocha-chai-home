using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using NetworkSecurity.Helper;

namespace NetworkSecurity
{
    public partial class MainForm : Form
    {
        public string GetKey()
        {
            return string.IsNullOrWhiteSpace(txtKey.Text) ? "default_key" : txtKey.Text;
        }

        public EnumCryptographyAlgorithms GetSelectedAlgorithm()
       