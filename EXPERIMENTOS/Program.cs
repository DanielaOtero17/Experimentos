using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXPERIMENTOS
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


        public int[] readText (){
            int counter = 0;
            String line ;
            String[] arrayAux;
            int[] arrayInt ;

            System.IO.StreamReader file = new System.IO.StreamReader(@"c:\test.txt");  

            while(file.Peek() != 1){  
               arrayAux = line.ReadLine().Split(",");
               counter++;
               int numero = Integer.parseInt(arrayAux[counter]) ;  
               arrayInt[counter] = numero;
              }  

             file.Close();  

            return arrayInt ;
        }

    }
}
