using System;
using System.Linq;
class Homework07
{
    public static void Main()
    {
        string strword = (" ");
        strword = Console.ReadLine();
        string[] arrword = strword.Split(' ');

        var a =
        from k in arrword
        orderby k
        select k;

        foreach (string res in a.Distinct())
        {
            Console.Write(" " + res.ToLower());
        }
        Console.ReadLine();
    }
}

