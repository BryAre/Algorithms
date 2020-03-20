# Insertion Sort using an array of 100 integers.

# prints array


def printArray(arr):
    for i in arr:
        print(i)

# creates array that starts at 100 and descends to 1


def createArray():
    arr = []
    for i in range(100, 0, -1):
        arr.append(i)
    return arr

# insertion sort function


def insertionSort(arr):
    for i in range(1, len(arr)):
        key = arr[i]
        j = i-1

        while j >= 0 and key < arr[j]:
            arr[j+1] = arr[j]
            j -= 1
        arr[j+1] = key


arr = createArray()
insertionSort(arr)
printArray(arr)
