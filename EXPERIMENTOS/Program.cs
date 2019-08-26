using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;



namespace EXPERIMENTOS
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 

        private static Sorts Ordenamiento;
        [STAThread]



        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            readText();
            //Application.Run(new Form1());
        }


        public static void readText (){


            for (int a = 0; a < 1000; a++)
            {
                /*try
                {*/
                String line = "";
                FileStream fs = File.Open("test.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
          //  Console.WriteLine("archivo encontrado");
            Ordenamiento = new Sorts();

                while ((line = sr.ReadLine()) != null)
                {

                    String[] arrayAux = line.Split(',');

                    int[] arrayInt = new int[arrayAux.Length];
                    int[] aux = new int[arrayAux.Length];


                    for (int i = 0; i < arrayAux.Length; i++)
                    {
                        int numero = int.Parse(arrayAux[i]);
                        arrayInt[i] = numero;
                        aux[i] = numero;

                    }

                    Ordenamiento.DoMergesort(aux);
                   // Console.Write("MergeSort: ");
                    //imprimir(aux);

                    Ordenamiento.DoQuickSort(arrayInt);
                  //  Console.Write("QuickSort: ");
                   // imprimir(arrayInt);
                }





                sr.Close();


            }




          /*  }
            catch (IOException){
                Console.WriteLine("No se lee. error");
            }*/
            
        }

        public static void imprimir(int[] imprimir)
        {
            String cad = "";
            for(int i=0; i<imprimir.Length; i++)
            {
                if (i == imprimir.Length - 1)
                {
                    cad += imprimir[i];
                }
                else
                {
                    cad += imprimir[i] + ",";
                }

            }
            Console.WriteLine(cad);

        }

    }
}
