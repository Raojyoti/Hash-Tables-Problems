using System;

namespace UC_1_Find_Frequency_in_Sentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            string hash0 = hash.Get("0");
            string hash1 = hash.Get("1");
            string hash2 = hash.Get("2");
            string hash3 = hash.Get("3");
            string hash4 = hash.Get("4");
            string hash5 = hash.Get("5");

            Console.WriteLine("Sequence of sentence are: ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("\"" + hash0 + " " + hash1 + " " + hash2 + " " + hash3 + " " + hash4 + " " + hash5 + "\"");

        }
    }
}
