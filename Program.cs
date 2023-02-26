

string[] array = InputArray();
string[] result = FindArray(array, 3);
Console.WriteLine($"[{string.Join(", ", result)}]");

string[] FindArray(string[] array, int n)
{
   int k = 0;
   string[] resultArray = new string[FindLengthArray(array, n)];
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i].Length <= n)
      {
         resultArray[k] = array[i];
         k++;
      }
   }
   return resultArray;
}

int FindLengthArray(string[] array, int n)
{
   int count = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i].Length <= n)
      {
         count++;
      }

   }
   return count;
}

string[] InputArray()
{
   Console.Write("Введите значения массива через пробел: ");
   return Console.ReadLine()!.Split(" ");
}
