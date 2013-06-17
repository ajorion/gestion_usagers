using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NLog;

namespace gestion_usagers
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        /// 
        private static Logger logger = LogManager.GetCurrentClassLogger();

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            logger.Info("Lancement de l'application"); 
            Application.Run(new LoginForm());
            
            
        }
    }
}
