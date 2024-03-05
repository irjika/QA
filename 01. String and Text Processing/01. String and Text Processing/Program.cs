string text = Console.ReadLine();

while (text != "end")
{
    string output = "";

    for (int i = text.Length - 1; i >=0; i--)
    {
        output += text[i];
    }
    Console.WriteLine(text + " = " + output);
    text = Console.ReadLine();
}


