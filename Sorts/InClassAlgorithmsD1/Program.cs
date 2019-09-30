using System;
namespace InClassAlgorithmsD1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Selection and Bubble Sort Application";

            GuidDataGenerator test = new GuidDataGenerator();

            Sort s = new Sort();

            // ---Selection Double Sort: ---
            s.SelectionDouble(test.myDoubles);
            //Selection Guid Sort:
            s.SelectionGuid(test.myGuids);
            //Bubble Double Sort:
            s.BubbleDouble(test.myDoubles);
            //Bubble Guid Sort:
            s.BubbleGuid(test.myGuids);
        }
    }
}
