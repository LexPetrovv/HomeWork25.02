// Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29


int m = 3;
int n = 5;

int functionAkkerman = Ack(m, n);
int Ack(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Ack(m - 1, 1);
    else
        return Ack(m - 1, Ack(m, n - 1));
}

Console.Write($"Функция Аккермана = {functionAkkerman} ");