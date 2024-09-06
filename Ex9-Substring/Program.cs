Console.WriteLine(Substring("Chocolate", 3));

string Substring(string word, int letters)
{
    return string.Concat(word.Substring(0, letters), word.Substring(word.Length - (letters), letters));
}