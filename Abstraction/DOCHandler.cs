using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class DOCHandler : AbstractHandler
    {
        public DOCHandler(string fileName)
           : base(fileName)
        {
        }

        public override void Chenge()
        {
            Console.WriteLine(fileName + " - DOC file changed.");
        }

        public override void Create()
        {
            Console.WriteLine(fileName + " - DOC file created.");
        }

        public override void Open()
        {
            Console.WriteLine(fileName + " - DOC file is open.");
        }

        public override void Save()
        {
            Console.WriteLine(fileName + " - DOC file saved.");
        }
    }
}
