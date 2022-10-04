// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



// Ввод чисел 
int Num()
{
    int num=0;
    try
    {
        Console.Write(":> ");
        num = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {    
        Console.WriteLine("Нужно вводить целое число!");
    }
    return num;
}


// Реализация функции Аккермана
int AckermanFunction(int m, int n)
{
    if ( m < 0 || n < 0)
    {
        Console.WriteLine("Функция определена для неотрицательных чисел! Попробуйте использовать другие данные");
        Environment.Exit(0); // Проверка данных внутри метода и вывод ошибки, если входные данные вне допустимых значений
    }
    if (m==0) return n+1;
    if (n==0) return AckermanFunction(m-1, 1);
    return AckermanFunction(m-1, AckermanFunction(m, n-1));
}

// Основная программа

// Ввод чисел
int m=0;
int n=0;
Console.Write("Введите число 'n'");
n = Num();
Console.Write("Введите число 'm' ");
m = Num();

Console.WriteLine($"Значение функции Аккермана для m={m}, n={n} равно: {AckermanFunction(m,n)}");