using System;

using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TipCalculator());
        }
    }
}
