
﻿using System.Drawing;

namespace NetworkSecurity
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.gbEncrypted = new System.Windows.Forms.GroupBox();
            this.lblEncryptDuration = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblBrowseEncryptedBinaryFile = new System.Windows.Forms.Label();
            this.btnBrowseEncryptedBinaryFile = new System.Windows.Forms.Button();
            this.lblEncryptedText = new System.Windows.Forms.Label();
            this.txtEncryptedText = new System.Windows.Forms.TextBox();
            this.gbDecrypted = new System.Windows.Forms.GroupBox();
            this.lblDecryptDuration = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblBrowseDecryptedBinaryFile = new System.Windows.Forms.Label();
            this.btnBrowseDecryptedBinaryFile = new System.Windows.Forms.Button();
            this.lblDecryptedText = new System.Windows.Forms.Label();
            this.txtDecryptedText = new System.Windows.Forms.TextBox();
            this.rbtnSelectTextType = new System.Windows.Forms.RadioButton();
            this.rbtnSelectBinaryType = new System.Windows.Forms.RadioButton();
            this.cmbCryptoTypes = new System.Windows.Forms.ComboBox();
            this.gbCrypto = new System.Windows.Forms.GroupBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.gbEncrypted.SuspendLayout();
            this.gbDecrypted.SuspendLayout();
            this.gbCrypto.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(0, 73);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainer.Panel1.Controls.Add(this.gbEncrypted);
            this.splitContainer.Panel1MinSize = 50;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer.Panel2.Controls.Add(this.gbDecrypted);
            this.splitContainer.Panel2MinSize = 50;
            this.splitContainer.Size = new System.Drawing.Size(1014, 532);
            this.splitContainer.SplitterDistance = 502;
            this.splitContainer.TabIndex = 1;
            // 
            // gbEncrypted
            // 
            this.gbEncrypted.BackColor = System.Drawing.Color.Thistle;
            this.gbEncrypted.Controls.Add(this.lblEncryptDuration);
            this.gbEncrypted.Controls.Add(this.btnDecrypt);
            this.gbEncrypted.Controls.Add(this.lblBrowseEncryptedBinaryFile);
            this.gbEncrypted.Controls.Add(this.btnBrowseEncryptedBinaryFile);
            this.gbEncrypted.Controls.Add(this.lblEncryptedText);
            this.gbEncrypted.Controls.Add(this.txtEncryptedText);
            this.gbEncrypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEncrypted.Location = new System.Drawing.Point(0, 0);
            this.gbEncrypted.Name = "gbEncrypted";
            this.gbEncrypted.Size = new System.Drawing.Size(502, 532);
            this.gbEncrypted.TabIndex = 0;
            this.gbEncrypted.TabStop = false;
            this.gbEncrypted.Text = "Encrypted";
            // 
            // lblEncryptDuration
            // 
            this.lblEncryptDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEncryptDuration.AutoSize = true;
            this.lblEncryptDuration.Location = new System.Drawing.Point(31, 412);
            this.lblEncryptDuration.Name = "lblEncryptDuration";
            this.lblEncryptDuration.Size = new System.Drawing.Size(114, 17);
            this.lblEncryptDuration.TabIndex = 6;
            this.lblEncryptDuration.Text = "Encrypt Duration";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecrypt.Location = new System.Drawing.Point(318, 484);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(148, 36);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Decrypt =>";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            // 
            // lblBrowseEncryptedBinaryFile
            // 
            this.lblBrowseEncryptedBinaryFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBrowseEncryptedBinaryFile.AutoSize = true;
            this.lblBrowseEncryptedBinaryFile.Location = new System.Drawing.Point(31, 350);
            this.lblBrowseEncryptedBinaryFile.Name = "lblBrowseEncryptedBinaryFile";
            this.lblBrowseEncryptedBinaryFile.Size = new System.Drawing.Size(107, 17);
            this.lblBrowseEncryptedBinaryFile.TabIndex = 4;
            this.lblBrowseEncryptedBinaryFile.Text = "Binary File Path";
            // 
            // btnBrowseEncryptedBinaryFile
            // 
            this.btnBrowseEncryptedBinaryFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseEncryptedBinaryFile.Location = new System.Drawing.Point(34, 294);
            this.btnBrowseEncryptedBinaryFile.Name = "btnBrowseEncryptedBinaryFile";
            this.btnBrowseEncryptedBinaryFile.Size = new System.Drawing.Size(432, 43);
            this.btnBrowseEncryptedBinaryFile.TabIndex = 3;
            this.btnBrowseEncryptedBinaryFile.Text = "Browse Binary File";
            this.btnBrowseEncryptedBinaryFile.UseVisualStyleBackColor = true;
            // 
            // lblEncryptedText
            // 
            this.lblEncryptedText.AutoSize = true;
            this.lblEncryptedText.Location = new System.Drawing.Point(31, 45);
            this.lblEncryptedText.Name = "lblEncryptedText";