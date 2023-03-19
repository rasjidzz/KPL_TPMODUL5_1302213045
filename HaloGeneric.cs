using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD5_1302213045
{
    internal class HaloGeneric
    {
        public void Sapauser<T>(T username)
        {
            Console.WriteLine("Hello user " + username + " !!!");
        }
    }
}
