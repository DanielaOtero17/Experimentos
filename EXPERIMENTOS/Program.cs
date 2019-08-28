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
            writeFile();
            //Application.Run(new Form1());
        }


        public static void readText (){

                /*try
                {*/
                String line = "";


            FileStream fs = File.Open("test.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
          //  Console.WriteLine("archivo encontrado");

            Ordenamiento = new Sorts();
            String rutaM = "MergeSort.txt";
            String rutaQ = "QuickSort.txt";
            String timeM = "TiempoMerge.txt";
            String timeQ = "TiempoQuick.txt";

            if (File.Exists(rutaM))
                File.Delete(rutaM);
            if (File.Exists(rutaQ))
                File.Delete(rutaQ);
            if (File.Exists(timeM))
                File.Delete(timeM);
            if (File.Exists(timeQ))
                File.Delete(timeQ);
            using (StreamWriter merge = File.AppendText(rutaM)) ;
            using (StreamWriter quick = File.AppendText(rutaQ)) ;
            using (StreamWriter TimeM = File.AppendText(timeM)) ;
            using (StreamWriter TimeQ = File.AppendText(timeQ)) ;

            int iterator = 1;
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

                String cadMerge = "cadena" + iterator + "   ";
                String cadQuick = "cadena" + iterator + "   ";

                for (int p = 0; p < 45; p++)
                {
                    String timeMerge = Ordenamiento.DoMergesort(aux);
                    String timeQuick = Ordenamiento.DoQuickSort(arrayInt);
                                                                            

                    cadMerge +=  timeMerge + " ---  ";
                    cadQuick +=   timeQuick + " ---  ";

                }
                using (StreamWriter fileM = new StreamWriter(rutaM, true))
                {
                    fileM.WriteLine(imprimir(aux));

                }

                using (StreamWriter fileQ = new StreamWriter(rutaQ, true))
                {
                    fileQ.WriteLine(imprimir(arrayInt));
                }
                using (StreamWriter fileTimeM = new StreamWriter(timeM, true))
                    {

                    fileTimeM.WriteLine(cadMerge);

                     }

                     using (StreamWriter fileTimeQ = new StreamWriter(timeQ, true))
                    {
                    fileTimeQ.WriteLine(cadQuick);
                    }

                iterator++;
            }
             sr.Close();


          /*  }
            catch (IOException){
                Console.WriteLine("No se lee. error");
            }*/
            
        }

        public static void writeFile()
        {
            string ruta = "test.txt";


            if (File.Exists(ruta))
                File.Delete(ruta);
            
                using (StreamWriter mylogs = File.AppendText(ruta)) ;         //se crea el archivo

                using (StreamWriter file = new StreamWriter(ruta, true))
                {
                    Random rnd = new Random();
                    for (int k = 0; k < 20; k++) // 20 es el número de arreglos que tendrá el archivo (líneas).
                    {

                        String cad = "";
                        int[] arrayRandom = new int[1000]; // creación de un arreglo que tendrá 1000 enteros.

                        for (int j = 0; j < arrayRandom.Length; j++)
                        {

                            int num = rnd.Next(999999);
                            arrayRandom[j] = num;
                            if (j == arrayRandom.Length - 1)
                            {
                                cad += arrayRandom[j];
                            }
                            else
                            {
                                cad += arrayRandom[j] + ",";
                            }
                        }

                        file.WriteLine(cad);

                        /*  StreamWriter sw = File.AppendText("test.txt");
                         sw.WriteLine(cad);
                          sw.Close();*/


                    }
                    file.Close();
                }

            readText();
        }
        public static String imprimir(int[] imprimir)
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
          //  Console.WriteLine(cad);
            return cad;

        }

    }
}
