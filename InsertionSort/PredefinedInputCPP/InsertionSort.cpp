
#include <random>
#include <iostream>
using namespace std;

int *createArray(int *array, int size)
{

    for (int i = 0; i < size; i++)
    {
        array[i] = i + 1;
    }
    return array;
}

int *shuffleArray(int *array, int size)
{
    srand(time(0));

    int a, i, index;

    for (i = size - 1; i >= 0; i--)
    {
        index = rand() % size;

        a = array[index];
        array[index] = array[i];
        array[i] = a;
    }

    return array;
}

int *sort(int *array, int size)
{
    int i, j, key;

    for (int i = 1; i < size; i++)
    {
        key = array[i];
        j = i - 1;

        while (j >= 0 && array[j] > key)
        {
            array[j + 1] = array[j];
            j = j - 1;
        }
        array[j + 1] = key;
    }

    return array;
}

void printArray(int *array, int size)
{
    for (int i = 0; i < size; i++)
    {
        std::cout << "\n"
                  << array[i];
    }
}

int main()
{
    int array[] = { 9,8,7,6,5,4,3,2,1 };
    int size = sizeof(array)/ sizeof(array[0]);
    shuffleArray(array, size);
    sort(array, size);
    printArray(array, size);
}
