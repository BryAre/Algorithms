# create an array of predefined values

# create array


def createArray():
    arr = [9, 8, 7, 6, 5, 4, 3, 2, 1]
    return arr

# print array


def printArray(arr):
    for i in range(len(arr)):
        print(arr[i])

# insertion sort function


def insertionSort(arr):
    for i in range(len(arr)):
        key = arr[i]
        j = i - 1

        while j >= 0 and key < arr[j]:
            arr[j+1] = arr[j]
            j -= 1
        arr[j+1] = key


arr = createArray()
insertionSort(arr)
printArray(arr)
