//using System;
//using System.Collections.Generic;
//using System.Globalization;

//class GFG
//{

//    static int NO_OF_CHARS = 256;
//    static char[] count = new char[NO_OF_CHARS];

//    static void getCharCountArray(string str)
//    {
//        for (int i = 0; i < str.Length; i++ )
//            count[str[i]]++;
//    }


//    static int firstNonRepeating(string str)
//    {
//        getCharCountArray(str);
//        int index = -1, i;

//        for (i = 0; i < str.Length; i++)
//        {
//            if (count[str[i]] == 1)
//            {
//                index = i;
//                break;
//            }
//        }

//        return index;
//    }

    

//    public static void Main()
//    {

//        Console.Write("Input: ");
//        string str = Console.ReadLine();
//        int index = firstNonRepeating(str);
        

//        Console.WriteLine("Output: ");
//        Console.WriteLine(index == -1 ? "First duplicate charactor is:" + " - "

//                                      : "First duplicate charactor is: "
//                                             + str[index]);
        


//    }
//}