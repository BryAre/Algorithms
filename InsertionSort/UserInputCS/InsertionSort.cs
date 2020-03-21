using System;

namespace InsertionSortCSharpUserInput
{
    class InsertionSort
    {
        public static int[] InitializeArray(int[] array, int size){
            
            for(int i = 0; i < size; i++){
                Console.WriteLine("Enter your element");
                array[i] = Int32.Parse(Console.ReadLine());
            }
            return array;
        }

        public static void printArray(int[] array, int size){
            for(int i = 0; i < size; i++){
                Console.WriteLine(array[i]);
            }
        }

        public static int[] Sort(int[] array, int size){

            int i, j,key;

            for( i = 1; i < size; i++){
                key = array[i];
                j = i -1;

                while(j >= 0 && array[j] > key){
                    array[j+1] = array[j];
                    j--;
                }
                array[j+1] = key;
            }

            return array;
        }

        
        static void Main(string[] args)
        {
            int size;

            Console.WriteLine("Enter the size of the array");
            size = Int32.Parse(Console.ReadLine());
            int[] array = new int[size];
            array = InitializeArray(array, size);

            Console.WriteLine("Your sorted array will look like this: \n");
            array = Sort(array, size);
            printArray(array,size);     
        }
    }
}
