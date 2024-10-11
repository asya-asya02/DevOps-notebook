using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace Vybor_noutbuka
{

    public static class CallBackMy
    {
        public delegate void callbackEvent(string what1, string what2, string what3);
        public static callbackEvent callbackEventHandler;
    }
    public static class Data_id
    {
        public static int Value { get; set; }
    }
    static class tab1
    {
        public static string Value { get; set; }
    }
    static class col1
    {
        public static string Value { get; set; }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        
        
        static class Data_s
        {
            public static string Value { get; set; }
        }
        
        
                
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
         }

        //*********
        
        //*********
        
    }
}
