using System;

namespace UC_3_Remove_Avoidable_word_from_phrase
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "Paranoids");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "because");
            hash.Add("10", "they");
            hash.Add("11", "keep");
            hash.Add("12", "putting");
            hash.Add("13", "themselves");
            hash.Add("14", "deliberately");
            hash.Add("15", "into");
            hash.Add("16", "paranoid");
            hash.Add("17", "avoiding");
            hash.Add("18", "situtions");

            Console.Write("\n");
            Console.WriteLine("Index of the words in the paragraph phrase are: ");
            Console.WriteLine("-------------------------------------------------------");
            string hash0 = hash.Get("0");
            string hash1 = hash.Get("1");
            string hash2 = hash.Get("2");
            string hash3 = hash.Get("3");
            string hash4 = hash.Get("4");
            string hash5 = hash.Get("5");
            string hash6 = hash.Get("6");
            string hash7 = hash.Get("7");
            string hash8 = hash.Get("8");
            string hash9 = hash.Get("9");
            string hash10 = hash.Get("10");
            string hash11 = hash.Get("11");
            string hash12 = hash.Get("12");
            string hash13 = hash.Get("13");
            string hash14 = hash.Get("14");
            string hash15 = hash.Get("15");
            string hash16 = hash.Get("16");
            hash.Remove("17");
            string hash17 = hash.Get("17");
            string hash18 = hash.Get("18");

            Console.WriteLine("oth index value: " + hash0);
            Console.WriteLine("1st index value: " + hash1);
            Console.WriteLine("2nd index value: " + hash2);
            Console.WriteLine("3rd index value: " + hash3);
            Console.WriteLine("4th index value: " + hash4);
            Console.WriteLine("5th index value: " + hash5);
            Console.WriteLine("6th index value: " + hash6);
            Console.WriteLine("7th index value: " + hash7);
            Console.WriteLine("8th index value: " + hash8);
            Console.WriteLine("9th index value: " + hash9);
            Console.WriteLine("10th index value: " + hash10);
            Console.WriteLine("11th index value: " + hash11);
            Console.WriteLine("12th index value: " + hash12);
            Console.WriteLine("13th index value: " + hash13);
            Console.WriteLine("14th index value: " + hash14);
            Console.WriteLine("15th index value: " + hash15);
            Console.WriteLine("16th index value: " + hash16);
            Console.WriteLine("17th index value: " + hash17);
            Console.WriteLine("18th index value: " + hash18);

            Console.Write("\n");
            Console.WriteLine("After remove avoidable word then Sequence of paragraph phrase are: ");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("\"" + hash0 + " " + hash1 + " " + hash2 + " " + hash3 + " " + hash4 + " " + hash5 + " " + hash6 + " " + hash7 + " " + hash8 + "\n " + hash9 + " " + hash10 + " " + hash11 + " " + hash12 + " " + hash13 + " " + hash14 + " " + hash15 + " " + hash16 + " " + hash17 + " " + hash18 + "\"");
            Console.WriteLine("\n");
        }
    }
}
