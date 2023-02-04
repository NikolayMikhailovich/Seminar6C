// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10

int InputData(string msg)
{
  Console.WriteLine($"{msg} > ");
  return Convert.ToInt32(Console.ReadLine());
}
int[] ConvertToBinary(int num)
{
  int[] left = new int[8];
  int ind = left.Length - 1;
  while (num != 0)
  {
    left[ind] = num % 2; num /= 2; ind--;
  }
  return left;
}
void PrintArray(int[] array)
{
  Console.WriteLine($"Массив: ");
  foreach (int item in array)
  {
    Console.Write(item);
  }
  Console.WriteLine();
}
int number = InputData($"Введите число");
int[] binaryNumber = ConvertToBinary(number);
PrintArray(binaryNumber);