﻿using System;
using System.Windows.Forms;

namespace KitapKirtasiyeProgrami
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (new FrmGirisYap().ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmAnaEkran());
            }
        }
    }
}