using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortApp
{
    public class Logic
    {
        public static string BubleSort(string input)
        {
            char[] toBubleSort = input.ToCharArray();
            char tempLastValue;
            string result = "";

            for (int characterPos = 0; characterPos < toBubleSort.Length; characterPos++)
            {
                for (int valueToCompare = 0; valueToCompare < toBubleSort.Length - 1; valueToCompare++)
                {
                    if (toBubleSort[valueToCompare].CompareTo(toBubleSort[valueToCompare + 1]) > 0)
                    {
                        tempLastValue = toBubleSort[valueToCompare];
                        toBubleSort[valueToCompare] = toBubleSort[valueToCompare + 1];
                        toBubleSort[valueToCompare + 1] = tempLastValue;

                    }
                }
            }

            for (int x = 0; x < toBubleSort.Length; x++)
            {
                result += toBubleSort[x];
            }

            return result;
        }

        public static string MergeSort(string input)
        {

            if(input.Length <= 1)
            {
                return input;
            }

            int centerIndex = input.Length / 2;
            string leftGroup = input.Substring(0, centerIndex);
            string rightGroup = input.Substring(centerIndex);


            leftGroup = MergeSort(leftGroup);
            rightGroup = MergeSort(rightGroup);
            return ResultMerge(leftGroup, rightGroup);
  
        }

       private static string ResultMerge(string left , string right)
        {
            string result = "";
            char[] leftArray = left.ToCharArray();
            char[] rightArray = right.ToCharArray();

            while(leftArray.Length > 0 || rightArray.Length > 0)
            {
                if(leftArray.Length > 0 && rightArray.Length > 0)
                {
                    if (leftArray[0].CompareTo(rightArray[0]) < 0)
                    {
                        result += leftArray[0];
                        leftArray = left.Remove(0,1).ToCharArray();
                        left = left.Remove(0, 1);
                    }
                    else
                    {
                        result += rightArray[0];
                        rightArray = right.Remove(0, 1).ToCharArray();
                        right = right.Remove(0, 1);
                    }
                }
                else if(leftArray.Length > 0)
                {
                    result += leftArray[0];
                    leftArray = left.Remove(0, 1).ToCharArray();
                    left = left.Remove(0, 1);
                }
                else if(rightArray.Length > 0)
                {
                    result += rightArray[0];
                    rightArray = right.Remove(0, 1).ToCharArray();
                    right = right.Remove(0, 1);
                }
            }

            return result;

        }
    }
}
