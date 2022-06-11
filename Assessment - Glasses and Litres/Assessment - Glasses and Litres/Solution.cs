using System.Collections.Generic;

namespace Assessment___Glasses_and_Litres
{
    public class Solution
    {
        public int solution(int numberOfGlasses, int numberOfLitres)
        {
            // Tested - but I'm not sure if I prepared enough tests (tests that I've prepared were passed)

            // I assumed that when I have 1 glass and 0 or less litres I need 0 glasses to contain it.

            if (numberOfGlasses < 1) return -1;
            int glassesCapacity = GetGlassesCapacity(numberOfGlasses);
            if (glassesCapacity < numberOfLitres) return -1;

            int numberOfGlassesUsed = 0;
            List<int> allGlasses = GetAllGlasses(numberOfGlasses);
            for (int i = allGlasses.Count - 1; i >= 0; i--)
            {
                if ((numberOfLitres - allGlasses[i]) < 0)
                {
                    allGlasses.RemoveAt(i);
                    continue;
                }
                numberOfLitres -= allGlasses[i];
                numberOfGlassesUsed++;
                if (numberOfLitres == 0) break;
            }

            return numberOfGlassesUsed;
        }

        public int GetGlassesCapacity(int numberOfGlasses)
        {
            // Tested - works great

            int capacity = 0;
            for (int i = 1; i <= numberOfGlasses; i++)
            {
                capacity += i;
            }
            return capacity;
        }

        public List<int> GetAllGlasses(int numberOfGlasses)
        {
            // Tested - works great

            List<int> allGlasses = new List<int>(numberOfGlasses);
            for (int i = 1; i <= numberOfGlasses; i++)
            {
                allGlasses.Add(i);
            }
            return allGlasses;
        }
    }
}
