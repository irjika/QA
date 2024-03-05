string text = Console.ReadLine();

int vowelsCount = CountVowels(text);
Console.WriteLine(vowelsCount);

static int CountVowels (string text)
{
    int vowelsCount = 0;
    for (int i = 0; i < text.Length; i++)
    {
        char c = char.ToLower(text[i]);
        if ((c == 'a') || (c == 'o') || (c == 'u') || (c == 'e') || (c == 'i')) {
            vowelsCount++;
        }
    }
    return vowelsCount;
}