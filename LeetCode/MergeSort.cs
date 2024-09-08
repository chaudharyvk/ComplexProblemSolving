using System.Linq;

class MergeSort1{
            
        
        public static void MergeSort(int[] array, int left, int right)
        {
            if(left < right)
            {
                int middle = (left + (right - 1)) / 2 + 1;
               /* Console.WriteLine(left);
                Console.WriteLine(right);
                Console.WriteLine(middle);
                Console.WriteLine(string.Join(",",array));
                Console.WriteLine("------"); */
                MergeSort(array, left, middle - 1);
                MergeSort(array, middle, right);

                Merge(array, left, middle, right);
            }
             Console.WriteLine(string.Join(",",array));
        }
        public static void Merge(int[] array, int left, int middle, int right)
        {
            int leftIterator, rightIterator, arrayIterator;

            int leftArrayLength = middle - left;
            int rightArrayLength = right - middle + 1;

            int[] leftArray = new int[leftArrayLength];
            int[] rightArray = new int[rightArrayLength];

            for(leftIterator = 0; leftIterator < leftArrayLength; leftIterator++)
            {
                leftArray[leftIterator] = array[left + leftIterator];
            }

            for(rightIterator = 0; rightIterator < rightArrayLength; rightIterator++)
            {
                rightArray[rightIterator] = array[middle + rightIterator];
            }

            leftIterator = 0; 
            rightIterator = 0; 
            arrayIterator = left;
            
            while(leftIterator < leftArrayLength && rightIterator < rightArrayLength)
            {
                if (leftArray[leftIterator] <= rightArray[rightIterator])
                {
                    array[arrayIterator++] = leftArray[leftIterator++];
                }
                else
                {
                    array[arrayIterator++] = rightArray[rightIterator++];
                }
            }

            int remainderIterator;

            if(leftIterator == leftArrayLength)
            {
                for(remainderIterator = rightIterator; remainderIterator < rightArrayLength; remainderIterator++)
                {
                    array[arrayIterator++] = rightArray[remainderIterator];
                }
            }

            if(rightIterator == rightArrayLength)
            {
                for (remainderIterator = leftIterator; remainderIterator < leftArrayLength; remainderIterator++)
                {
                    array[arrayIterator++] = leftArray[remainderIterator];
                }
            }
        }
        }