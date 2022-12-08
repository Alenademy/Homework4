Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numberN)
  {

    int N = Convert.ToString(numberN).Length;
    int SumNumber = 0;
    int result = 0;

    for (int i = 0; i < N; i++)
    {
      SumNumber = numberN - numberN % 10;
      result = result + (numberN - SumNumber);
      numberN = numberN / 10;
    }
   return result;
  }
  int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);


