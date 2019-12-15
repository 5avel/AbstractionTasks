using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            TEST("test.txt");
            TEST("test.xml");
            TEST("test.doc");
            TEST("test.csv");
        }

        public static void TEST(string fileName)
        {
            AbstractHandler handler = AbstractHandler.ChooseDocument(fileName);
            handler.Open();
            handler.Chenge();
            handler.Save();
            handler.Create();
        }
    }
}
