﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TibiaTekPlus
{

    static class Program
    {
        /// <summary>
        /// Instance of the Kernel object.
        /// </summary>
        static public Kernel kernel;

        /// <summary>
        /// Instance of the main form.
        /// </summary>
        static public MainForm mainForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Instantiate the kernel object
            kernel = new Kernel();
            


            // Show timed splash screen
            SplashScreenForm ssf = new SplashScreenForm();
            ssf.ShowDialog();

            // Create the main form
            mainForm = new MainForm();

            // Enable the kernel (initialization prior to main window)
            kernel.Enable();

            ApplicationContext appContext = new ApplicationContext(mainForm);
            appContext.ThreadExit += new EventHandler(OnApplicationExit);
            Application.Run(appContext);
        }

        static private void OnApplicationExit(object sender, EventArgs e)
        {
            // Save settings here?
            
            //global::TibiaTekPlus.Properties.Settings.Default
        }

    }
}
