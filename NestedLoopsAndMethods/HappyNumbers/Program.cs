﻿int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= 9; i++)
{
    for (int j = 0; j <= 9; j++)
    {
        for (int k = 0; k <= 9; k++)
        {
            for (int l = 0; l <= 9; l++)
            {
                    if (i + j == k + l && i + j == n)
                    {
                        Console.Write($"{i}{j}{k}{l} "); 
                    }
                }
            }
        }
    }

