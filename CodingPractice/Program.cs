using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CodingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool includePreviousPicks = true;
            PickRandomGyro(includePreviousPicks);
        }

        private static void PickRandomGyro(bool includePreviousPicks)
        {

            var gyroSelector = new RandomSelector();
            string userInput = String.Empty;
            List<string> gyroTeamMembers = new List<string> { "Jason", "Susan", "Naveen", "Josh", "Jessica", "Kelly", "Scott", "Sarah", "Chandra" };
            List<string> previouslySelectedMembers = new List<string> { };
            string selectedMember = String.Empty;
            do
            {
                selectedMember = gyroSelector.GetRandomMemberFromRemaining(gyroTeamMembers, previouslySelectedMembers);
                Console.WriteLine(selectedMember);

                if (includePreviousPicks)
                {
                    previouslySelectedMembers.Add(selectedMember);
                    if (gyroTeamMembers.Count == previouslySelectedMembers.Count)
                    {
                        Console.WriteLine("All team members have been picked. Restart selections 'y' or 'n'?");
                        if(Console.ReadLine().ToString() == "y")
                        {
                            previouslySelectedMembers = new List<string>();
                            selectedMember = String.Empty;
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }


                userInput = Console.ReadLine().ToString();
            }
            while (string.IsNullOrWhiteSpace(userInput) && selectedMember != null);
        }
    }
}
