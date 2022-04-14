using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Library_Nikitin.ClassHelper
{
    class AppData
    {
        public static EF.LibraryISP17Entities1 Context { get; } = new EF.LibraryISP17Entities1();
    }
}
