﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetPT2K
{
    public static class Program
    {


        /// <summary>
        /// Application main starting point
        /// </summary>
        [STAThread]
        
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new App();

        }

        // ...

    }
}
