/* Напишите программу,
 которая принимает на вход координаты двух точек
  и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

                if(int.TryParse(Console.ReadLine(), out result) )
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

double GetDistance (int x1, int y1, int z1,  int x2, int y2, int z2)
{
    //Нахождение расстояния
    return Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2-z1,2));
}

int x1 =  GetNumber ("Введите координату x1  : " );
int y1 =  GetNumber ("Введите координату y1  : " );
int z1 =  GetNumber( "Введите координату z1  :  ");
int x2 =  GetNumber ("Введите координату x2  : " );
int y2 =  GetNumber ("Введите координату y2  : " );
int z2 =  GetNumber( "Введите координату z2  :  ");

double distance = GetDistance (x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками равно {distance}");
