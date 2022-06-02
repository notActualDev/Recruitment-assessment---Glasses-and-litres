using System;
using System.Collections.Generic;

namespace Assessment___Glasses_and_Litres
{
    class TestsOfMethod_GetAllGlasses
    {
        // TESTED - works great

        Solution solution = new Solution();

        public void RunTests()
        {
            Test(-2);
            Test(-1);
            Test(0);
            Test(1);
            Test(2);
            Test(3);
            Test(4);
        }

        void Test(int numberOfGlasses)
        {
            List<int> allGlasses = solution.GetAllGlasses(numberOfGlasses);
            Console.WriteLine($"Number of glasses is {numberOfGlasses}. List of glasses is:");
            foreach (var glass in allGlasses)
            {
                Console.WriteLine(glass);
            }
        }
    }
}
