using System;
using WPF_Project_Logic.Cards.Project;
using WPF_Project_Logic.Cards.Common.Helper;
using WPF_Project_Logic.Cards.Agency;

namespace WPF_Project_Logic {
    internal class Program {
        static void Main(string[] args) {

            DataFeeder feed = new DataFeeder();
            Agency agency = feed.BuildSampleAgency();

            Console.WriteLine(String.Join(Helper.listSeparator, agency.Adress));

        }  
    }
}
