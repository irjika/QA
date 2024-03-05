int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
//int facturialNum1 = 0;
//int facturialNum2 = 0;
int result = 0;
Console.WriteLine(result);

while (1 <= num1 && num2 <= 10)
{


    for (int i = 1; i <= num1; i++)
    {
        int facturialNum1 = CalculateFacturial(num1);
        facturialNum1 += i;

        for (int j = 1; i <= num2; j++)
        {
            int facturialNum2 = CalculateFacturial(num2);
            facturialNum2 += j;

            result = facturialNum1 / facturialNum2;

        }

        static int CalculateFacturial(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
