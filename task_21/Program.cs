/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int getCoordinateFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.Write($"Ошибка ввода! Ожидается целое число. {userInformation}: ");
    }
    return result;
}

int userCoordinateX1 = getCoordinateFromUser("X1 = ");
int userCoordinateY1 = getCoordinateFromUser("Y1 = ");
int userCoordinateZ1 = getCoordinateFromUser("Z1 = ");
int userCoordinateX2 = getCoordinateFromUser("X2 = ");
int userCoordinateY2 = getCoordinateFromUser("Y2 = ");
int userCoordinateZ2 = getCoordinateFromUser("Z2 = ");

double findRangeBetweenTwoPoints(int coordinateX1, int coordinateY1,
                                 int coordinateZ1, int coordinateX2,
                                 int coordinateY2, int coordinateZ2)
{
    return Math.Sqrt(Math.Pow(coordinateX2 - coordinateX1, 2) +
                     Math.Pow(coordinateY2 - coordinateY1, 2) +
                     Math.Pow(coordinateZ2 - coordinateZ1, 2));
}

Console.WriteLine(findRangeBetweenTwoPoints(userCoordinateX1, userCoordinateY1,
                                            userCoordinateZ1, userCoordinateX2,
                                            userCoordinateY2, userCoordinateZ2));