string t = Console.ReadLine();
int n = int.Parse(Console.ReadLine());

Console.WriteLine(RepeatText(t, n));

static string RepeatText (string text, int count)
{
    string output = "";

        for (int i = 1;  i <= count; i++)
    {
        output += text;
    }
        return output;
}
