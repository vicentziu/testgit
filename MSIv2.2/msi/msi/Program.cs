using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace msi
{
    static class Program
    { 
        //*:ne engedje ujra megnyitni az alkalmazast
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            string new_window ="Application/newwindow.txt";
            string error = "Aplicatia ruleaza deja!";
            if(!File.Exists(new_window))
                File.Create(new_window);
            try
            {
                
                FileStream fs = new FileStream(new_window, FileMode.Open, FileAccess.Write);
                if (fs.CanWrite)
                {
                    Application.Run(new Form1());
                }
                else
                    MessageBox.Show(error);
            }
            catch
            {
                MessageBox.Show(error);
                Application.Exit();
            }
            
        }
    }
}