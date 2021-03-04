
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