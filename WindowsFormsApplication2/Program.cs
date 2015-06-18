/*
 * John Gordon & Lauren Wang
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeminiCore;
using System.IO;
namespace WindowsFormsApplication2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            Memory mainMem = new Memory();
            IPE ipe = new IPE(@"test5.s", mainMem);
            try
            {
                ipe.ParseFile();
            }
            catch(CustomException e)
            {
                Console.WriteLine(e.lineNumber);
                Console.WriteLine(e.Message);
            }  
            */
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
