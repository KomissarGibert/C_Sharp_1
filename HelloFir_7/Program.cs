/*
Алгоритм:
1. Определить три точки
2. Выбрать две любых
3. Найти середину
4. Поставить точку
5. Выбрать случайную вершину треугольника
6. Соединить её с полученной на 4 шаге точкой
7. Перейти к шагу 3
8. Шаги 3 – 7 повторить 9, 28, 31 раз
*/


//Console.Clear(); 
int xa = 40, ya = 1, 
    xb = 1, yb = 30, 
    xc = 80, yc = 30;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb; //случайная точки Х

int count = 0; //чётчик который будет определять колличество раз нахождение отрезков и деление пополам

while (count < 10000) //пока канут меньше чем...
{
    int what = new Random().Next(0, 3); //...сгенерировать случайное число(точку)
    if(what == 0)
    {
        x = (x + xa) / 2; //в Х кладём середину отрезка
        y = (y + ya) / 2; //в Х кладём середину отрезка
    }

    if(what == 1)
    {
        x = (x + xb) / 2; //в Х кладём середину отрезка
        y = (y + yb) / 2; //в Х кладём середину отрезка
    }

    if(what == 2)
    {
        x = (x + xc) / 2; //в Х кладём середину отрезка
        y = (y + yc) / 2; //в Х кладём середину отрезка
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}