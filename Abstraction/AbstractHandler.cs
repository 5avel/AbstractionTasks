using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public abstract class AbstractHandler
    {
        protected string fileName;

        public AbstractHandler(string fileName)
        {
            this.fileName = fileName;
        }

        public abstract void Open();
        public abstract void Create();
        public abstract void Chenge();
        public abstract void Save();



        public static AbstractHandler ChooseDocument(string fileName)
        {
            string format = fileName.Substring(fileName.Length - 4);
            switch (format.ToLower())
            {
                case ".txt":
                    return new TXTHandler(fileName);
                case ".doc":
                    return new DOCHandler(fileName);
                case ".xml":
                    return new XMLHandler(fileName);
                default:
                    throw new FormatException($"{fileName} - not suported");
            }

        }
    }
}
