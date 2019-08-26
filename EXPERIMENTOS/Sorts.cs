using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPERIMENTOS
{
    class Sorts
    {
        //atributos para el merge sort.
        private int[] array;
        private int[] arrayMerge;
        private int tamanio;

        // constructor del merge.
        public void sort(int[] Arr)
        {
            array = Arr;
            tamanio = Arr.Length;
            arrayMerge = new int[tamanio];
            MergeSort(0, tamanio - 1);
        }

        //metodo que divide el arreglo en 2 partes
        private void MergeSort(int pequenio, int grande)
        {

            if (pequenio < grande)
            {
                int mitad = pequenio + ((grande - pequenio) / 2);
                MergeSort(pequenio, mitad);
                MergeSort(mitad + 1, grande);
                mergeParts(pequenio, mitad, grande);
            }
        }

        // merge.
        private void mergeParts(int pequenio, int mitad, int grande)
        {
            

            for ( int a = pequenio; a <= grande; a++)
            {
                arrayMerge[a] = array[a];
            }

            int i = pequenio;
            int j = mitad + 1;
            int k = pequenio;
            while (i <= mitad && j <= grande)
            {
                if (arrayMerge[i] <= arrayMerge[j])
                {
                    array[k] = arrayMerge[i];
                    i++;
                }
                else
                {
                    array[k] = arrayMerge[j];
                    j++;
                }
                k++;
            }
            while (i <= mitad)
            {
                array[k] = arrayMerge[i];
                k++;
                i++;
            }
        }
    }
}
