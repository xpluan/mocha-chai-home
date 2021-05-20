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
        {
            return (EnumCryptographyAlgorithms)cmbCryptoTypes.SelectedItem;            
        }


        public FileInfo EncryptedFileInfo => new FileInfo(lblBrowseEncryptedBinaryFile.Text);
        public FileInfo DecryptedFileInfo => new FileInfo(lblBrowseDecryptedBinaryFile.Text);

        public MainForm()
        {
            InitializeComponent();

            //
            // Declare events for UI controls
            //
            txtDecryptedText.TextChanged += (sender, args) => rbtnSelectTextType.Checked = true;
            txtEncryptedText.TextChanged += (sender, args) => rbtnSelectTextType.Checked = true;
            
            btnBrowseDecryptedBinaryFile.Click += BtnBrowseBinaryFile_Click;
            btnBrowseEncryptedBinaryFile.Click += BtnBrowseBinaryFile_Click;

            btnDecrypt.Click += BtnDecrypt_Click;
            btnEncrypt.Click += BtnEncrypt_Click;
        }


        private void BtnBrowseBinaryFile_Click(object sender, EventAr