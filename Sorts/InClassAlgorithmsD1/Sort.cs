using System;
using System.Collections.Generic;
using System.Text;

namespace InClassAlgorithmsD1
{
    public class Sort
    {

        //Selection Sort Sources:
        //https://www.tutorialspoint.com/selection-sort-program-in-chash
        //http://cforbeginners.com/CSharp/SelectionSort.html
        public void SelectionDouble(List<double> doubleList)
        {
            double temp = 0;

            for (int i = 0; i < doubleList.Count; i++)
            {
                for (int n = i + 1; n < doubleList.Count; n++)
                {

                    if (doubleList[n] < doubleList[i])
                    {
                        temp = doubleList[i];
                        doubleList[i] = doubleList[n];
                        doubleList[n] = temp;
                    }

                }
                Console.WriteLine(doubleList[i]);
            }
            Console.Read();
        }


        public void SelectionGuid(List<Guid> guidList)
        {
            Guid temp;

            for (int i = 0; i < guidList.Count; i++)
            {
                for (int j = i + 1; j < guidList.Count; j++)
                {
                    if (guidList[i].CompareTo(guidList[j]) > 0)
                    {
                        temp = guidList[i];
                        guidList[i] = guidList[j];
                        guidList[j] = temp;
                    }

                }
                Console.WriteLine(guidList[i]);
            }
            Console.Read();
        }


        //Bubble Sort Sources:
        //https://stackoverflow.com/questions/14768010/simple-bubble-sort-c-sharp
        //https://www.tutorialspoint.com/Bubble-Sort-program-in-Chash
        //https://www.c-sharpcorner.com/UploadFile/prasoonk/guids-in-C-Sharp-and-net/
        public void BubbleDouble(List<double> doubleList)
        {
            double temp = 0;

            for (int i = 0; i < doubleList.Count; i++)
            {
                for (int j = i + 1; j < doubleList.Count; j++)
                {
                    if (doubleList[j] < doubleList[i])
                    {
                        temp = doubleList[j];
                        doubleList[j] = doubleList[i];
                        doubleList[i] = temp;
                    }
                }
                Console.WriteLine(doubleList[i]);
            }
            Console.Read();
        }


        public void BubbleGuid(List<Guid> guidList)
        {
            Guid temp;

            for (int i = 0; i < guidList.Count; i++)
            {
                for (int j = i + 1; j < guidList.Count; j++)
                {
                    if (guidList[i].CompareTo(guidList[j]) > 0)
                    {
                        temp = guidList[j];
                        guidList[j] = guidList[i];
                        guidList[i] = temp;
                    }
                }
                Console.WriteLine(guidList[i]);
            }
            Console.Read();
        }
    }
}











