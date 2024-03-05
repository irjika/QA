string text = Console.ReadLine();

while (text != "end")
{
    char[] output = text.ToCharArray().Reverse().ToArray();
    string reversed = string.Join("", output);

    Console.WriteLine(text + " = " + reversed);
    text = Console.ReadLine();
}
