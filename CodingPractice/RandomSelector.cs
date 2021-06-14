using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingPractice
{
    class RandomSelector
    {
        public RandomSelector()
        {
            Random = new Random();
        }
        
        public Random Random { get; set; }

        public string GetNextRandomMember(List<string> listMembers)
        { 
            if(listMembers.Count == 0) { return null; }

            int index = Random.Next(listMembers.Count);
            return listMembers[index];
        }

        public string GetRandomMemberFromRemaining(List<string> listMembers, List<string> previousSelections)
        {
            return GetNextRandomMember(listMembers.Except(previousSelections).ToList());
        }
    }
}
