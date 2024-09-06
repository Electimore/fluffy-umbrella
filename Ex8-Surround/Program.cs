Console.WriteLine(Surround("XxxX", "N00bSl@y3r69"));

string Surround(string outer, string inner)
{
    return string.Concat(outer.Substring(0, 2), inner, outer.Substring(2, 2));
}