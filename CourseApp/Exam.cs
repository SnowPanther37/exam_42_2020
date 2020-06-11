using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Exam
    {
        public static Dictionary<string, string> MyFlatFunc(Dictionary<string, Dictionary<string, Dictionary<string, string>>> dict)
        {
            Dictionary<string, string> dictresult = new Dictionary<string, string>();
            string path;
            foreach (var a in dict)
            {
                if (a.Value is Dictionary<string, Dictionary<string, string>>)
                {
                    path = a.Key + "/";
                    foreach (var b in a.Value)
                    {
                        if (b.Value is Dictionary<string, string>)
                        {
                            path += b.Key + "/";
                            foreach (var c in b.Value)
                            {
                                if (c.Value is string)
                                {
                                    dictresult.Add(path + c.Key, c.Value);
                                }
                            }
                        }
                    }
                }
            }

            return dictresult;
        }

        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, Dictionary<string, string>>> dict = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
            dict.Add("a", new Dictionary<string, Dictionary<string, string>>());
            dict["a"].Add("b", new Dictionary<string, string>());
            dict["a"]["b"].Add("c", "12");
            dict["a"]["b"].Add("d", "Hello World");
            dict["a"]["b"].Add("e", "1, 2, 3");

            foreach (var a in MyFlatFunc(dict))
            {
                Console.WriteLine(a);
            }
        }
    }
}