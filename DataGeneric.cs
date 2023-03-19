using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD5_1302213045
{
    internal class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T datainput)
        {
            this.data = datainput;
        }
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah " + this.data);
        }
    }
}
