int num = int.Parse(Console.ReadLine());

int[] arr1 = new int[num];
int[] arr2 = new int[num];

for (int i = 0; i < num; i++)
{ 
        arr1[i] = int.Parse(Console.ReadLine());
        arr2[i] = int.Parse(Console.ReadLine());
}

Console.Write(arr1);