﻿using CapsLockSharpPrototype.Runtime;
using System;
using System.Windows.Forms;

namespace CapsLockSharpPrototype
{
    static class Program
    {
        public static Controller GlobalController;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
