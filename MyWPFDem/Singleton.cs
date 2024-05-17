using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWPFDem
{
    internal class Singleton
    {
        public static readonly MyDemDBEntities DB = new MyDemDBEntities();
    }
}
