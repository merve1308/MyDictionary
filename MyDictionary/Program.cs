using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> studentList = new MyDictionary<int, string>();
            studentList.Add(634, "Merve");
            studentList.Add(686, "Münire");
            studentList.Add(741, "Nazlı");
            studentList.Add(762, "Güney");
            studentList.Add(791, "Ali");

            Console.WriteLine(studentList.Count);
           


           
        }
    }
}
