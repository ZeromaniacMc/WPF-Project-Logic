using System;
using WPF_Project_Logic.Cards.Project;
using WPF_Project_Logic.Cards.Common.Helper;

namespace WPF_Project_Logic {
    internal class Program {
        static void Main(string[] args) {

            // Realistically, we will always need a helper class to generate ids, type check names and other
            // data, so it makes perfect sense to always have an instance available in the startup.
            Helper helperClass = new Helper();

            Project garnierProject = new Project("Garnier", helperClass.generateID());
            Console.WriteLine(garnierProject.Name);
            Console.WriteLine(garnierProject.ID);

        }  
    }
}
