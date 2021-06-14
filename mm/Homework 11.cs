using System;

class Homework11
{
    public static void Main()
    {
        string bahtTxt, n, bahtTH = "", str = "";
        double amount;
        bool Trillion = false;
        Console.WriteLine("กรอกตัวเลข");
        bahtTH = Console.ReadLine();
        try { amount = Convert.ToDouble(bahtTH); }
        catch { amount = 0; }
        bahtTH = "";
        bahtTxt = amount.ToString("####.00");
        string[] num = { "ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า", "สิบ" };
        string[] rank = { "", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน" };
        string[] temp = bahtTxt.Split('.');
        string intVal = temp[0];
        string decVal = temp[1];
        if (Convert.ToDouble(bahtTxt) == 0)
            bahtTH = "ศูนย์บาทถ้วน";
        else
        {
            if (intVal.Length > 7)
            {
                Trillion = true;
                str = intVal.Substring(0, intVal.Length - 6);
                intVal = intVal.Substring(str.Length);
                for (int i = 0; i < str.Length; i++)
                {
                    n = str.Substring(i, 1);
                    if (n != "0")
                    {
                        if (str.Length == 1)
                        {
                            bahtTH += num[Convert.ToInt32(n)];
                        }
                        else
                        {

                            if ((i == (str.Length - 1)) && (n == "1"))
                                bahtTH += "เอ็ด";
                            else if ((i == (str.Length - 2)) && (n == "2"))
                                bahtTH += "ยี่";
                            else if ((i == (str.Length - 2)) && (n == "1"))
                            {
                                bahtTH += "";
                            }
                            else
                                bahtTH += num[Convert.ToInt32(n)];
                            bahtTH += rank[(str.Length - i) - 1];

                        }
                    }
                }
            }
            for (int i = 0; i < intVal.Length; i++)
            {
                n = intVal.Substring(i, 1);
                if (n != "0")
                {
                    if (intVal.Length == 1)
                    {
                        bahtTH += num[Convert.ToInt32(n)];
                    }
                    else
                    {

                        if ((i == (intVal.Length - 1)) && (n == "1"))
                            bahtTH += "เอ็ด";
                        else if ((i == (intVal.Length - 2)) && (n == "2"))
                            bahtTH += "ยี่";
                        else if ((i == (intVal.Length - 2)) && (n == "1"))
                        {
                            bahtTH += "";
                        }
                        else
                            bahtTH += num[Convert.ToInt32(n)];
                        bahtTH += rank[(intVal.Length - i) - 1];

                    }


                }
            }
            if (Trillion)
            {
                bahtTH += "ล้าน";
            }

            Console.WriteLine(bahtTH);
        }
    }
//}