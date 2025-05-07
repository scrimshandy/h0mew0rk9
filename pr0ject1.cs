//нахождение наименьшего числа в массиве
int[] myArray = { 123, 404, 405, 406, 407, 408, 409, 410, 1414 };

int minValue = myArray [0];

for (int i = 1; i < myArray.Length; i++)
{
    if (myArray[i] < minValue)
    {
        minValue = myArray[i];
    }
}
Console.WriteLine("Минимальное число массива: " + minValue);
Console.ReadLine();
