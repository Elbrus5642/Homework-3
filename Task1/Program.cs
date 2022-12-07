/* Напишите программу, 
которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом
14212 -> нет
12821 -> да
23432 -> да
*/
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

                if(int.TryParse(Console.ReadLine(), out result) &&  result > 9999 && result < 100000)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число");
        }
    }

    return result;

}

void GetPalindrom(int palinDromCheck)
{

  int firstNumber = palinDromCheck / 10000;
  Console.Write($"{firstNumber}, ");
  int secondNumber = (palinDromCheck - firstNumber * 10000)/1000;
  Console.Write($"{secondNumber}, ");
  int thirdNumber = (palinDromCheck - firstNumber * 10000 - secondNumber * 1000)/100; 
  Console.Write($"{thirdNumber}, ");
  int fourNumber = (palinDromCheck - firstNumber * 10000 - secondNumber * 1000 - thirdNumber * 100)/10;
  Console.Write($"{fourNumber}, ");
  int fiveNumber = palinDromCheck - firstNumber * 10000 - secondNumber * 1000 - thirdNumber * 100 - fourNumber * 10; 
  Console.WriteLine($"{fiveNumber}, ");
  
  if (firstNumber == fiveNumber)
  { 
       if (secondNumber == fourNumber)
         {
        Console.WriteLine($"Число {palinDromCheck} - палиндром, т.е одинаково читается справа налево и слева направо");
         }
       else
         {
             Console.WriteLine($"Число {palinDromCheck} -  не палиндром");
         }
  }     
    else
   {
      Console.WriteLine($"Число {palinDromCheck} -  не палиндром");  
   }   
}


int palinDromCheck = GetNumber("Введите пятизначное число : ");
Console.WriteLine($"Проверка на признак палиндрома числа {palinDromCheck}");
GetPalindrom(palinDromCheck); 