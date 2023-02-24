// Решение задач с одномерным массивом

//Перебор массива
int[] myArray = new int[10] { 1, 2, 1, 4, 5, 1, 5, 8, 9, 25 };
int[] myArrayTwo = new int[10] { 1, 2, 3, 4, 5, -1, 7, 8, 9, 11 };
//Выводит все элементы массива.
void PrintArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"{myArray[i]}  ");
    }
}

//Выводит все элементы массива в обратном порядке.
void PrintArrayReverse(int[] myArray)
{
    for (int i = myArray.Length - 1; i >= 0; i--)
    {
        Console.Write($"{myArray[i]}  ");
    }
}

//Выводит чётные элементы массива.
void PrintArrayHonest(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] % 2 == 0) Console.Write($"{myArray[i]}  ");
    }
}

//Выводит все элементы массива через 1.
void PrintArrayThroughOne(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i += 2)
    {
        Console.Write($"{myArray[i]}  ");
    }
}

//Выводит все элементы массива пока не встретится элемент.
void PrintArraySearchElement(int[] myArray, int searchNum)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"{myArray[i]}  ");
        if (myArray[i] == searchNum) break;
    }
}

// Добавление и удаление элементов массива

//В массив добавляется элемент в конец.
int[] AddetLastElementArray(int[] myArray, int newElement)
{
    int[] newMyArray = new int[myArray.Length + 1];
    for (int i = 0; i < myArray.Length; i++)
    {
        newMyArray[i] = myArray[i];
    }
    newMyArray[newMyArray.Length - 1] = newElement;
    myArray = newMyArray;
    return myArray;
}

//В массив добавляется элемент в начало.
int[] AddetFirstElementArray(int[] myArray, int newElement)
{
    int[] newMyArray = new int[myArray.Length + 1];
    for (int i = 1; i <= myArray.Length; i++)
    {
        newMyArray[i] = myArray[i - 1];
    }
    newMyArray[0] = newElement;
    myArray = newMyArray;
    return myArray;
}

//В массив добавляется элемент в позицию (допустим 4).
int[] AddetPositionElementArray(int[] myArray, int position, int newElement)
{
    int[] newMyArray = new int[myArray.Length + 1];
    for (int i = 0, j = 0; i <= myArray.Length; i++)
    {
        if (i == position) continue;
        newMyArray[i] = myArray[j];
        j++;
    }
    newMyArray[position] = newElement;
    myArray = newMyArray;
    return myArray;
}

//Из массива удаляется элемент с конца.
int[] DeleteLastElementArray(int[] myArray)
{
    int[] newMyArray = new int[myArray.Length - 1];
    for (int i = 0; i < newMyArray.Length; i++)
    {
        newMyArray[i] = myArray[i];
    }
    myArray = newMyArray;
    return myArray;
}

//Из массива удаляется элемент с начала
int[] DeleteFirstElementArray(int[] myArray)
{
    int[] newMyArray = new int[myArray.Length - 1];
    for (int i = 1; i <= newMyArray.Length; i++)
    {
        newMyArray[i - 1] = myArray[i];
    }
    myArray = newMyArray;
    return myArray;
}

//Из массива удаляется элемент с позиции (допустим 5)
int[] DeletePositionElementArray(int[] myArray, int position)
{
    int[] newMyArray = new int[myArray.Length - 1];
    for (int i = 0, j = 0; i < myArray.Length; i++)
    {
        if (i == position) continue;
        newMyArray[j] = myArray[i];
        j++;
    }
    myArray = newMyArray;
    return myArray;
}

// Создание массива из двух массивов. В итоговом массиве должны быть элементы первого и второго массива
int[] CreatingSharedArray(int[] myArray, int[] myArrayTwo)
{
    int[] newMyArray = new int[myArray.Length + myArrayTwo.Length];
    for (int i = 0, j = 0; i < newMyArray.Length; i++)
    {
        if (i < myArray.Length) newMyArray[i] = myArray[i];
        if (i >= myArray.Length)
        {
            newMyArray[i] = myArrayTwo[j];
            j++;
        }
    }
    return newMyArray;
}

// Нахождения максимальных и минимальных элементов в массиве 

// Нахождение максимально элемента массива
int MaxSearchElementArray(int[] array)
{
    int maxValue = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (maxValue < array[i]) maxValue = array[i];
    }
    return maxValue;
}

// Нахождение минимального элемента массива
int MinSearchElementArray(int[] array)
{
    int minValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (minValue > array[i]) minValue = array[i];
    }
    return minValue;
}

// Нахождение второго минимального элемента массива
int MinSearchTwoElementArray(int[] array)
{
    int minValue = array[0], minValueTwo = array[1];
    if (minValueTwo < minValue)
    {
        minValue = minValueTwo;
        minValueTwo = array[0];
    }
    for (int i = 2; i < array.Length; i++)
    {
        if (minValue > array[i])
        {
            minValueTwo = minValue;
            minValue = array[i];
        }
        if (minValueTwo > array[i] && array[i] != minValue)
        {
            minValueTwo = array[i];
        }
    }
    return minValueTwo;
}

// Нахождение второго максимального элемента массива
int MaxSearchTwoElementArray(int[] array)
{
    int maxValue = array[0], maxValueTwo = array[1];
    if (maxValueTwo > maxValue)
    {
        maxValue = maxValueTwo;
        maxValueTwo = array[0];
    }
    for (int i = 2; i < array.Length; i++)
    {
        if (maxValue < array[i])
        {
            maxValueTwo = maxValue;
            maxValue = array[i];
        }
        if (maxValueTwo < array[i] && array[i] != maxValue)
        {
            maxValueTwo = array[i];
        }
    }
    return maxValueTwo;
}

