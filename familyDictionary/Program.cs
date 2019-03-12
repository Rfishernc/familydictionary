using System;
using System.Collections.Generic;

namespace familyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Forest" }, { "age", "37" } });

            var output = "";

            foreach(var (relation, data) in myFamily)
            {
                output += $"{data["name"]} is my {relation} and is {data["age"]} years old.";
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
