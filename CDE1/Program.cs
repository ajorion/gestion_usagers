using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace gestion_usagers
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Debug.Listeners.Add(new TextWriterTraceListener("c:/temp/debug.log"));
            Debug.AutoFlush = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            Debug.Indent();
            Debug.Write(string.Format(DateTime.Now + " : Lancement de l'application"));
            Debug.Unindent();
            
        }
    }
}
