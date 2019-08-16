using COMP123Assignment5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123Assignment5.Views
{
    public static class Program
    {
        public static SplashForm SplashForm;

        public static StartForm StartForm;
        public static Select Select;
        public static About About;
        public static ProductInfo ProductInfo;
        public static Order Order;
        public static product product;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SplashForm = new SplashForm();
            StartForm = new StartForm();
            Select = new Select();
            About = new About();
            ProductInfo = new ProductInfo();
            Order = new Order();
            product = new product();

            Application.Run(new SplashForm());
        }
    }
}
