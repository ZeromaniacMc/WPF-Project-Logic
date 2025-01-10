using System;
using WPF_Project_Logic.Cards.Project;
using WPF_Project_Logic.Cards.Common.Helper;

namespace WPF_Project_Logic {
    internal class Program {
        static void Main(string[] args) {

            while (true) {
                Console.WriteLine("Enter the project name:");
                // Read user input
                String userInput = Console.ReadLine();
                
                try {
                // Create new project object
                Project someProject = new Project(userInput, Helper.generateID());

                // Print details
                Console.WriteLine("Current data details:");
                Console.WriteLine($"Registered Project Name: {someProject.Name}");
                Console.WriteLine($"Generated ID: {someProject.ID}");

                // Success message
                Console.WriteLine("Project created successfully!");

                // Exit loop if success
                break;

                // TODO: If the check fails, we want to clear only the faulty data, not regenerate the whole block.
                // If the user has to retype the whole form because of one mistake, I think he'd be angry. Rightfully so lol.

                } catch (Exception ex) {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

        }  
    }
}
