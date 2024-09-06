Console.WriteLine(MakeAbba("Bajo", "Jajo"));
Console.WriteLine(MakeAbba("A", "B"));

string MakeAbba(string a, string b)
{
    return string.Concat(a, b, b, a);
}