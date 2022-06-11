using System;

namespace Assessment___Glasses_and_Litres
{
    class TestsOfMethod_solution
    {
        // Tested - but I'm not sure if I prepared enough tests (tests that I've prepared were passed)

        Solution solution = new Solution();

        public void RunTests()
        {
            Test(-1, -1);
            Test(-1, 0);
            Test(-1, 1);

            Test(0, -1);
            Test(0, 0);
            Test(0, 1);

            Test(1, -1);
            Test(1, 0);
            Test(1, 1);

            Test(1, 2);
            Test(1, 3);

            Test(2, 2);
            Test(3, 3);

            Test(5, 8);
            Test(5, 10);
            Test(10, 20);
            Test(6, 20);
            Test(6, 21);
            Test(6, 22);
        }

        void Test(int numberOfGlasses, int numberOfLitres)
        {
            int minimumGlassesUsed = solution.solution(numberOfGlasses, numberOfLitres);
            Console.WriteLine($"Number of glasses: {numberOfGlasses}. Number of litres: {numberOfLitres}. Minimum glasses used: {minimumGlassesUsed}.");
        }
    }
}
