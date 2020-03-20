import java.util.*;

// Insertion Sort
public class InsertionSortUserInput{


    public static int[] sort(int array[]){

        int i, j, key;

        for(j = 1; j < array.length; ++j){
            key = array[j];
            i = j - 1;

            while(i >= 0 && array[i] > key){
                array[i + 1] = array[i];
                i = i - 1;
            }

            array[i+1] = key;

        }

        return array;
    }

    public static int[] createArray(int size){
        
        Scanner scan = new Scanner(System.in);
        int[] array = new int[size];

        for(int i = 0; i < size; i++){
            System.out.print("Enter your element: ");
            array[i] = scan.nextInt();
        }

        return array;
    }

    public static int[] shuffleArray(int[] array){

        Random rndm = new Random();
        int a, i ,index;

        for(i = array.length-1; i >= 0; i--){
            index = rndm.nextInt(i+1);

            a = array[index];
            array[index] = array[i];
            array[i] = a;
        }

        return array;
    }

    public static void displayArray(int[] array){
        for(int i = 0; i < array.length; i++){
            System.out.println(array[i]);
        }
    }
    
    public static void main (String args[]){
        System.out.print("Enter your size: ");
        Scanner scan = new Scanner(System.in);
        
        int size = scan.nextInt();
        



        int[] a = createArray(size);
        a = shuffleArray(a);
        a = sort(a);
        displayArray(a);

        
    }
}