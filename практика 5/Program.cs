Console.Write("Введите количество цифр = ");
int k = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число = ");
int n = Convert.ToInt32(Console.ReadLine());

while (k > 1)
{
    int first = 1;
    for (int i = 1; i < k; i++)
    {
        first *= 10;
    }

    int end = 1;
    int result = 0;

    for (int i = 0; i < k / 2; i++)
    {
        int left = n / first % 10;
        int right = n / end % 10;
        int sum = left + right;

        if (sum >= 10)
            result = result * 100 + sum;
        else
            result = result * 10 + sum;

        first /= 10;
        end *= 10;
    }   

    n = result;
    Console.WriteLine(n);

    k = 0;
    int t = n;
    while (t > 0)
    {
        k++;
        t /= 10;
    }
}

Console.WriteLine("Ответ = " + n);