﻿using System;
using System.Windows.Forms;

namespace AppWrapper_TestWindow
{
    public static class Program
    {
        public static AppWrapper appWrapper;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            appWrapper = new AppWrapper();
            appWrapper.Initialize(form.Handle, ActivateMode.DEFAULT);
            Application.Run(form);
        }
    }
}