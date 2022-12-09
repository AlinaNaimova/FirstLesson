/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
Console.Write("Введите число!");
int numbers = Convert.ToInt32(Console.ReadLine());

  int CountDigits(int numbers){
    
    int counter = Convert.ToString(numbers).Length;
    int value = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      value = numbers - numbers % 10;
      result = result + (numbers - value);
      numbers = numbers / 10;
    }
   return result;
  }

int sumDigits = CountDigits(numbers);
Console.WriteLine($"Сумма цифр в числе {numbers}: " + sumDigits);