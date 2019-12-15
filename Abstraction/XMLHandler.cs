using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class XMLHandler : AbstractHandler
    {
        public XMLHandler(string fileName)
            : base(fileName)
        {
        }

        public override void Chenge()
        {
            Console.WriteLine(fileName + " - XML file changed.");
        }

        public override void Create()
        {
            Console.WriteLine(fileName + " - XML file created.");
        }

        public override void Open()
        {
            Console.WriteLine(fileName + " - XML file is open.");
        }

        public override void Save()
        {
            Console.WriteLine(fileName + " - XML file saved.");
        }
    }
}
