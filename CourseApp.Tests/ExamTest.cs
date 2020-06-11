using System;
using System.Collections.Generic;
using Xunit;

namespace CourseApp.Tests
{
    public class ExamTest
    {
        [Fact]
        public void EmptyTest()
        {
            Dictionary<string, Dictionary<string, Dictionary<string, string>>> dict = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
            Dictionary<string, string> exp = new Dictionary<string, string>();
            Assert.Equal(exp, Exam.MyFlatFunc(dict));
        }

        [Fact]
       public void Test1()
        {
            Dictionary<string, Dictionary<string, Dictionary<string, string>>> dict = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
            dict.Add("a", new Dictionary<string, Dictionary<string, string>>());
            dict["a"].Add("b", new Dictionary<string, string>());
            dict["a"]["b"].Add("c", "12");
            Dictionary<string, string> exp = new Dictionary<string, string>();
            exp.Add("a/b/c", "12");
            Assert.Equal(exp, Exam.MyFlatFunc(dict));
        }

        [Fact]
        public void Test2()
        {
            Dictionary<string, Dictionary<string, Dictionary<string, string>>> dict = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
            dict.Add("a", new Dictionary<string, Dictionary<string, string>>());
            dict["a"].Add("b", new Dictionary<string, string>());
            dict["a"]["b"].Add("c", "12");
            dict["a"]["b"].Add("d", "Hello World");
            Dictionary<string, string> exp = new Dictionary<string, string>();
            exp.Add("a/b/c", "12");
            exp.Add("a/b/d", "Hello World");
            Assert.Equal(exp, Exam.MyFlatFunc(dict));
        }

        [Fact]
        public void Test3()
        {
            Dictionary<string, Dictionary<string, Dictionary<string, string>>> dict = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
            dict.Add("a", new Dictionary<string, Dictionary<string, string>>());
            dict["a"].Add("b", new Dictionary<string, string>());
            dict["a"]["b"].Add("c", "12");
            dict["a"]["b"].Add("d", "Hello World");
            dict["a"]["b"].Add("e", "1, 2, 3");
            Dictionary<string, string> exp = new Dictionary<string, string>();
            exp.Add("a/b/c", "12");
            exp.Add("a/b/d", "Hello World");
            exp.Add("a/b/e", "1, 2, 3");
            Assert.Equal(exp, Exam.MyFlatFunc(dict));
        }
    }
}