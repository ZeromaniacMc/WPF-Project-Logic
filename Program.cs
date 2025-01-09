using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Project_Logic.Common;

namespace WPF_Project_Logic {
    internal class Program {
        static void Main(string[] args) {

            DataType mydata = new DataType();
            mydata = DataType.Project;
            Console.WriteLine(mydata);
        }
    }
}
