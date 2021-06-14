using System;
class Homework12
{
    public static int findRepeatFirst(string s)
    {

        int p = -1, i, k;

        int MAX_CHAR = 256;
        int[] hash = new int[MAX_CHAR];

        int[] pos = new int[MAX_CHAR];

        for (i = 0; i < s.Length; i++)
        {
            k = (int)s[i];
            if (hash[k] == 0)
            {
                hash[k]++;
                pos[k] = i;
            }
            else if (hash[k] == 1)
                hash[k]++;
        }

        for (i = 0; i < MAX_CHAR; i++)
        {
            if (hash[i] == 2)
            {
                if (p == -1)
                    p = pos[i];
                else if (p > pos[i])
                    p = pos[i];
            }
        }

        return p;
    }

    public static int NO_OF_CHARS = 256;
    public static char[] count = new char[NO_OF_CHARS];

    public static void getCharCountArray(string str)
    {
        for (int i = 0; i < str.Length; i++)
            count[str[i]]++;
    }


    static int firstNonRepeating(string str)
    {
        getCharCountArray(str);
        int index = -1, i;

        for (i = 0; i < str.Length; i++)
        {
            if (count[str[i]] == 1)
            {
                index = i;
                break;
            }
        }

        return index;
    }

    public static void Main()
    {
        Console.Write("input: ");
        string str = Console.ReadLine();
        int pos = findRepeatFirst(str);
        int index = firstNonRepeating(str);
        if (pos == -1)
            Console.WriteLine("First duplicate charactor is: " + "-");
        else
            Console.WriteLine("First duplicate charactor is: " + str[pos]);

        if (index == -1)
            Console.WriteLine("First duplicate charactor is: " + "-");
        else
            Console.WriteLine("First duplicate charactor is: " + str[index]);







    }
}