/* Напишите программу, 
которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);
       
        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Некорректный ввод, введите число");
        }
    }

    return result;
}

void PrintCubeTable (int number)
{
    for (int index = 1; index <= number; index++)
    {
        Console.Write ($"{Math.Pow(index,3)},");
    } 
}

int number = GetNumber("Введите число");

PrintCubeTable (number);
