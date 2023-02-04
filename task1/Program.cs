// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Функция ввода целого числа
int InputInt(string msg)
{
  System.Console.Write($"{msg}: ");
  return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int len, int minValue = 0, int maxValue = 10)
{
  int[] array = new int[len];
  Random rnd = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(minValue, maxValue);
  }
  return array;
}
void PrintArray(int[] array)
{
  foreach (int item in array)
  {
    System.Console.Write($"{item}; ");
  }
  System.Console.WriteLine();
}

int[] Reverse(int[] array)
{
  for (int i = 0; i < array.Length / 2; i++)
  {
    Swap1(array, i, array.Length - 1 - i);
  }
  return array;
}

void Swap(int[] array, int i, int j)
{
  int temp = array[i];
  array[i] = array[j];
  array[j] = temp;
}

void Swap1(int[] array, int i, int j)
{
  (array[i], array[j]) = (array[j], array[i]);
}

int len = InputInt("Введите длину массива");
int[] array = GenerateArray(len);
PrintArray(array);
PrintArray(Reverse(array));