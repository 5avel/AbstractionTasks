using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class TXTHandler: AbstractHandler
    {
        public TXTHandler(string fileName)
           : base(fileName)
        {
        }

        public override void Chenge()
        {
            Console.WriteLine(fileName + " - TXT file changed.");
        }

        public override void Create()
        {
            Console.WriteLine(fileName + " - TXT file created.");
        }

        public override void Open()
        {
            Console.WriteLine(fileName + " - TXT file is open.");
        }

        public override void Save()
        {
            Console.WriteLine(fileName + " - TXT file saved.");
        }
    }
}
