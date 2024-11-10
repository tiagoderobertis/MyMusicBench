using Microsoft.EntityFrameworkCore;
using MyMusicBench.Connection;

namespace MyMusicBench
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SQLitePCL.Batteries_V2.Init();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (var context = new MyMusicBenchContext())
            {
                // Pasa la instancia del contexto al formulario
                context.Database.Migrate();
                Application.Run(new Form1(context));
            }
            


        }
    }
}