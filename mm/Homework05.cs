using System;

class Homework05
{
    public static void Main()
    {

        string[] lis = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
        string[] num = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };

        foreach (var s in lis)
        {
            Console.Write(s + "  ");

        }
        Console.WriteLine("");
        foreach (var t in num)
        {
            Console.Write(" " + t + "   ");
        }
        Console.WriteLine("");

        while (true)
        {
            int sa = 0;

            Console.Write("Please choose LED to turn On / Off:");
            String le = Console.ReadLine();

            foreach (var l in num)
            {
                if (le == l && lis[sa] == "[ ]")
                {
                    lis[sa] = "[!]";
                    foreach (var s in lis)
                    {
                        Console.Write(s + "  ");

                    }
                    Console.WriteLine("");
                    foreach (var t in num)
                    {
                        Console.Write(" " + t + "   ");
                    }
                    Console.WriteLine("");


                }
                else if (le == l && lis[sa] == "[!]")
                {

                    lis[sa] = "[ ]";
                    foreach (var s in lis)
                    {
                        Console.Write(s + "  ");

                    }
                    Console.WriteLine("");
                    foreach (var t in num)
                    {
                        Console.Write(" " + t + "   ");
                    }
                    Console.WriteLine("");
                }

                sa++;
            }
        }
    }
}


