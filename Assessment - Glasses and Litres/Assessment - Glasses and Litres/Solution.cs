using System.Collections.Generic;

namespace Assessment___Glasses_and_Litres
{
    public class Solution
    {
        public int solution(int numberOfGlasses, int numberOfLitres)
        {
            // Tested - but I'm not sure if I prepared enough tests (tests that were prepared were passed)

            // I assumed that when I have 1 glass and 0 or less litres I need 0 glasses to contain it.

            if (numberOfGlasses < 1) return -1;
            if (numberOfLitres <= 0) return 0;
            if (GetGlassesCapacity(numberOfGlasses) < numberOfLitres) return -1;

            int numberOfGlassesUsed = 0;
            int litresLeft = numberOfLitres;
            List<int> allGlasses = GetAllGlasses(numberOfGlasses);
            for (int i = allGlasses.Count - 1; i >= 0; i--)
            {
                if ((litresLeft - allGlasses[i]) < 0)
                {
                    allGlasses.RemoveAt(i);
                    continue;
                }
                litresLeft -= allGlasses[i];
                numberOfGlassesUsed++;
                if (litresLeft == 0) break;
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

            List<int> allGlasses = new List<int>();
            for (int i = 1; i <= numberOfGlasses; i++)
            {
                allGlasses.Add(i);
            }
            return allGlasses;
        }
    }
}
