using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexerdemo
{
     class Program
    {
        static void Main(string[] args)
        {
            indexer i;
            i = new indexer();
            i[3] = 4.3f;
            Console.WriteLine(i[3]);

        }
    }
}
