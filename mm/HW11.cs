//using System;

//public class ConvertDigitsToWords
//{
//    private static string ThaiBahtText(string strNumber, bool IsTrillion = false)
//    {
//        int _Number = Convert.ToInt32(Number);
//        String name = "";
//        switch (_Number)
//        {

//            case 1:
//                name = "หนึ่ง";
//                break;
//            case 2:
//                name = "สอง";
//                break;
//            case 3:
//                name = "สาม";
//                break;
//            case 4:
//                name = "สี่";
//                break;
//            case 5:
//                name = "ห้า";
//                break;
//            case 6:
//                name = "หก";
//                break;
//            case 7:
//                name = "เจ็ด";
//                break;
//            case 8:
//                name = "แปด";
//                break;
//            case 9:
//                name = "เก้า";
//                break;
//        }
//        return name;
//    }
//    private static String tens(String Number)
//    {
//        int _Number = Convert.ToInt32(Number);
//        String name = null;
//        switch (_Number)
//        {
//            case 10:
//                name = "สิบ";
//                break;
//            case 11:
//                name = "สิบเอ็ด";
//                break;
//            case 12:
//                name = "สิบสอง";
//                break;
//            case 13:
//                name = "สิบสาม";
//                break;
//            case 14:
//                name = "สิบสี่";
//                break;
//            case 15:
//                name = "สิบห้า";
//                break;
//            case 16:
//                name = "สิบหก";
//                break;
//            case 17:
//                name = "สิบเจ็ด";
//                break;
//            case 18:
//                name = "สิบแปด";
//                break;
//            case 19:
//                name = "สิบเก้า";
//                break;
//            case 20:
//                name = "ยี่สิบ";
//                break;
//            case 30:
//                name = "สามสิบ";
//                break;
//            case 40:
//                name = "สี่สิบ";
//                break;
//            case 50:
//                name = "ห้าสิบ";
//                break;
//            case 60:
//                name = "หกสิบ";
//                break;
//            case 70:
//                name = "เจ็ดสิบ";
//                break;
//            case 80:
//                name = "แปดสิบ";
//                break;
//            case 90:
//                name = "เก้าสิบ";
//                break;
//            default:
//                if (_Number > 0)
//                {
//                    name = tens(Number.Substring(0, 1) + "0") + "" + ones(Number.Substring(1));
//                }
//                break;
//        }
//        return name;
//    }
//    private static String ConvertWholeNumber(String Number)
//    {
//        string word = "";
//        try
//        {
//            bool beginsZero = false;//tests for 0XX    
//            bool isDone = false;//test if already translated    
//            double dblAmt = (Convert.ToDouble(Number));
//            //if ((dblAmt > 0) && number.StartsWith("0"))    
//            if (dblAmt > 0)
//            {//test for zero or digit zero in a nuemric    
//                beginsZero = Number.StartsWith("0");

//                int numDigits = Number.Length;
//                int pos = 0;//store digit grouping    
//                String place = "";//digit grouping name:hundres,thousand,etc...    
//                switch (numDigits)
//                {
//                    case 1://ones' range    

//                        word = ones(Number);
//                        isDone = true;
//                        break;
//                    case 2://tens' range    
//                        word = tens(Number);
//                        isDone = true;
//                        break;
//                    case 3://hundreds' range    
//                        pos = (numDigits % 3) + 1;
//                        place = " ร้อย ";
//                        break;
//                    case 4://thousands' range    

//                        pos = (numDigits % 4) + 1;
//                        place = " พัน ";
//                        break;

//                    case 5:

//                        pos = (numDigits % 5) + 1;
//                        place = " หมื่น ";
//                        break;
//                    case 6:
//                        pos = (numDigits % 6) + 1;
//                        place = " แสน ";
//                        break;

//                    case 7://millions' range    
//                    case 8:
//                    case 9:
//                        pos = (numDigits % 7) + 1;
//                        place = " ล้าน ";
//                        break;
//                    case 10://Billions's range    
//                    case 11:
//                    case 12:

//                        pos = (numDigits % 10) + 1;
//                        place = " พันล้าน ";
//                        break;
//                    //add extra case options for anything above Billion...    
//                    default:
//                        isDone = true;
//                        break;
//                }
//                if (!isDone)
//                {//if transalation is not done, continue...(Recursion comes in now!!)    
//                    if (Number.Substring(0, pos) != "0" && Number.Substring(pos) != "0")
//                    {
//                        try
//                        {
//                            word = ConvertWholeNumber(Number.Substring(0, pos)) + place + ConvertWholeNumber(Number.Substring(pos));
//                        }
//                        catch { }
//                    }
//                    else
//                    {
//                        word = ConvertWholeNumber(Number.Substring(0, pos)) + ConvertWholeNumber(Number.Substring(pos));
//                    }

//                    //check for trailing zeros    
//                    //if (beginsZero) word = " and " + word.Trim();    
//                }
//                //ignore digit grouping names    
//                if (word.Trim().Equals(place.Trim())) word = "";
//            }
//        }
//        catch { }
//        return word.Trim();
//    }
//    private static String ConvertToWords(String numb)
//    {
//        String val = "", wholeNo = numb, points = "", andStr = "", pointStr = "";
//        String endStr = "";
//        try
//        {
//            int decimalPlace = numb.IndexOf(".");
//            if (decimalPlace > 0)
//            {
//                wholeNo = numb.Substring(0, decimalPlace);
//                points = numb.Substring(decimalPlace + 1);
//                if (Convert.ToInt32(points) > 0)
//                {
//                    andStr = "and";// just to separate whole numbers from points/cents    
//                    endStr = "Paisa " + endStr;//Cents    
//                    pointStr = ConvertDecimals(points);
//                }
//            }
//            val = String.Format("{0} {1}{2} {3}", ConvertWholeNumber(wholeNo).Trim(), andStr, pointStr endStr);
//        }
//        catch { }
//        return val;
//    }
//    private static String ConvertDecimals(String number)
//    {
//        String cd = "", digit = "", engOne = "";
//        for (int i = 0; i < number.Length; i++)
//        {
//            digit = number[i].ToString();
//            if (digit.Equals("0"))
//            {
//                engOne = "Zero";
//            }
//            else
//            {
//                engOne = ones(digit);
//            }
//            cd += " " + engOne;
//        }
//        return cd;
//    }
//    static void Main(string[] args)
//    {
//        string isNegative = "";
//        try
//        {
//            Console.WriteLine("Please input number:");
//            string number = Console.ReadLine();
//            number = Convert.ToDouble(number).ToString();

//            if (number.Contains("_"))
//            {
//                isNegative = "Minus ";
//                number = number.Substring(1, number.Length - 1);
//            }
//            if (number == "0")
//            {
//                Console.WriteLine("The\nZero ");
//            }
//            else
//            {
//                Console.WriteLine("The \n{0}", isNegative + ConvertToWords(number));
//            }
//            Console.ReadKey();
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}


