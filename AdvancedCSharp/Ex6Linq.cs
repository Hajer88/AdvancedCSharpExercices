using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdvancedCSharp
{
    class Ex6Linq
    {
        public void LinqToString()
        {
        //tableau de string
        string[] strTable = { " aa", "bbb", " aa " };
            //Query syntax
            //Deffered query
            var strlinq = from s in strTable
                          where s.Contains(" ")
                          select s;
            foreach(var item in strlinq)
            {
                Console.WriteLine(item);
            }
            //DotNotation Syntax
            //Deffered syntax
            var strlinq2 = strTable.Where(c => c.Contains(" ")).Select(c=>c);
            
        }
    }
}
