﻿using System;
using System.Windows.Forms;

namespace PlaylistByProchy
{
    internal static class Program
    {
        /// <summary>
        ///     Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}