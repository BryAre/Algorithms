using System;

namespace InsertionSortCSharpPredefinedInput{
    class InsertionSort{

        public static void printArray(int[] array, int size){
            for(int i = 0; i < size; i++){
                Console.WriteLine(array[i]);
            }
        }

        public static int[] sort(int[] array, int size){
            int i, j, key;

            for(i = 1; i < size; i++){
                key = array[i];
                j = i - 1;

                while( j >= 0 && array[j] > key ){
                    array[j+1] = array[j];
                    j = j - 1;
                }
                array[j+1] = key;
            }

            return array;
        }
        static void Main(String[] args){
            int size = 4;
            int[] array = new int[] { 4, 3, 2, 1 };


            array = sort(array, size);
            printArray(array, size);
        }
    }
}
