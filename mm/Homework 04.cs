using System;

    class Homework04
    {
    static void Main(string[] args)
    {
        Console.Write("");
        string age = Console.ReadLine();
        string[] sa = age.Split(",");
        foreach (var s in sa)
        {
            int i = (s.Length - 1);
            double sum = 0, j = 0;
            while (i >= 0)
            {
                sum += Convert.ToDouble(s.Substring(i, 1)) *
                       Convert.ToDouble(Math.Pow(2.00, Convert.ToDouble(j)));
                j++;
                i--;
            }
            if
               (sum % 5 == 0)
            {
                Console.Write(s + " ");
            }

        }

    }
}