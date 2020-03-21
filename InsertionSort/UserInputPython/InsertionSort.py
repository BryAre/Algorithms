

def createArray(number):
    arr = []
    for i in range(number):
        add = input("enter array value")
        arr.append(add)
    return arr


def printArray(arr):
    for i in range(len(arr)):
        print(arr[i])


def insertionSort(arr):
    for i in range(len(arr)):
        key = arr[i]
        j = i - 1

        while j >= 0 and key < arr[j]:
            arr[j+1] = arr[j]
            j -= 1
        arr[j+1] = key


a = createArray(5)
insertionSort(a)
printArray(a)
