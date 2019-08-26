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

        // Método que se va a utilizar para hacer el llamado al merge Sort.
        public void DoMergesort(int[] Arr)
        {
            array = Arr;
            tamanio = Arr.Length;
            arrayMerge = new int[tamanio];
            MergeSort(0, tamanio - 1);
        }


        public void DoQuickSort(int[] array)
        {
            array = quicksort1(array);
        }

        public int[] quicksort1(int[] numbers)
        {
            return quicksort2(numbers,0,numbers.Length-1);
        }

        public int[] quicksort2(int[] numbers, int izq, int der)
        {
            if (izq >= der)
                 return numbers;
            int i = izq, d=der;

            if(izq!= der){
                
                int pivote; 
                int aux;
                pivote=izq;
                 while(izq!=der){
                                       
                  while(numbers[der] >= numbers[pivote] && izq<der)
                    der--;

                  while(numbers[izq] >= numbers[pivote] && izq<der)
                    izq++;
                    
                  if(der!=izq)
                    {
                      aux = numbers[der];
                        numbers[der] = numbers[izq];
                        numbers[izq] = aux;
                  }
                 }
                  if(izq==der){
                    
                    quicksort2(numeros,i,izq-1);
                    quicksort2(numeros,izq+1,d);    
                  }                
            }else
                return numbers;

            return numbers;
        }

        //metodo MergeSort que divide el arreglo en 2 partes
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


            for (int a = pequenio; a <= grande; a++)
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
