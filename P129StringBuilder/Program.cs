using System;
using System.Text;

namespace P129StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseStr("Salam Qrup Uzvleri"));
        }

        static StringBuilder ReverseStr(string str)
        {
            string[] arr = str.Split(' ');

            StringBuilder reverseStr = new StringBuilder();

            foreach (string item in arr)
            {
                for (int i = item.Length - 1; i >= 0; i--)
                {
                    reverseStr.Append(item[i]);
                }
                if (item != arr[arr.Length-1])
                {
                    reverseStr.Append('-');
                }
            }
            return reverseStr;
        }

        //static string ReverseStr(string str)
        //{
        //    string reverseStr = "";
        //    for (int i = str.Length - 1; i >= 0; i--)
        //    {
        //        reverseStr += str[i];
        //    }
        //    return reverseStr;
        //}
    }
}
