int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

Console.WriteLine(RectangleArea(n, m));

static int RectangleArea (int weight, int high)
{
    int area = weight * high;
    return area;
}

