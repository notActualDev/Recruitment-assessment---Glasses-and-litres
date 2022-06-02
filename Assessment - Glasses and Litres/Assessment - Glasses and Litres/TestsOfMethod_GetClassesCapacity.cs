using System;

namespace Assessment___Glasses_and_Litres
{
    public class TestsOfMethod_GetClassesCapacity
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
            Test(5);
            Test(6);
            Test(7);
            Test(8);
        }

        void Test(int numberOfGlasses)
        {
            int capacity = solution.GetGlassesCapacity(numberOfGlasses);
            Console.WriteLine($"Capacity of {numberOfGlasses} glasses is: {capacity}");
        }
    }
}
