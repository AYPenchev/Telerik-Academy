using System;
using System.Linq;

namespace Arrays
{
    class Arrays
    {
        private static void AllocateArray01()
        {
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] arrayN = new int[n];

            for (int i = 0; i < n; i++)
            {
                arrayN[i] = i * 5;
                Console.WriteLine(arrayN[i]);
            }
        }

        private static void CompareArrays02()
        {
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];

            Console.WriteLine("Enter numbers for first array: ");
            for (int i = 0; i < n; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            int[] secondArray = new int[n];

            Console.WriteLine("Enter numbers for second array: ");
            for (int i = 0; i < n; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            bool areEqual = true;

            for (int i = 0; i < n; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    break;
                }
            }

            Console.WriteLine(areEqual ? "Equal" : "Not equal");
        }

        private static void CompareCharArrays03()
        {
            bool areLexicographicallyEqual = true;

            Console.WriteLine("Enter first char array: ");
            string firstCharArray = Console.ReadLine();

            Console.WriteLine("Enter second char array: ");
            string secondCharArray = Console.ReadLine();

            if (firstCharArray.Length > secondCharArray.Length)
            {
                Console.WriteLine(firstCharArray + " > " + secondCharArray);
            }
            else if (firstCharArray.Length < secondCharArray.Length)
            {
                Console.WriteLine(firstCharArray + " < " + secondCharArray);
            }
            else
            {
                for (int i = 0; i < firstCharArray.Length; i++)
                {
                    if (firstCharArray[i] != secondCharArray[i])
                    {
                        areLexicographicallyEqual = false;
                        Console.WriteLine("Equal length but not lexicographically equal.");
                        break;
                    }
                }

                if (areLexicographicallyEqual)
                {
                    Console.WriteLine("Equal length and lexicographically equal");
                }
            }
        }

        private static void MaximalSequence04()
        {
            int countSequence = 1;
            int maxSequence = 1;

            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] maxSequenceArray = new int[n];

            if (n != 1)
            {
                Console.WriteLine("Enter n numbers: ");
                for (int i = 0; i < n; i++)
                {
                    maxSequenceArray[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < n - 1; i++)
                {
                    if (maxSequenceArray[i] == maxSequenceArray[i + 1])
                    {
                        countSequence++;
                    }
                    else
                    {
                        countSequence = 1;
                    }

                    if (countSequence > maxSequence)
                    {
                        maxSequence = countSequence;
                    }
                }
            }

            if (n == 0)
            {
                Console.WriteLine(--maxSequence);
            }
            else
            {
                Console.WriteLine(maxSequence);
            }
        }

        private static void MaximalIncreasingSequence05()
        {
            int countSequence = 1;
            int maxIncreasingSequence = 1;

            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] maxIncreasingSequenceArray = new int[n];

            if (n != 1)
            {
                Console.WriteLine("Enter n numbers: ");
                for (int i = 0; i < n; i++)
                {
                    maxIncreasingSequenceArray[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < n - 1; i++)
                {
                    if (maxIncreasingSequenceArray[i] + 1 == maxIncreasingSequenceArray[i + 1])
                    {
                        countSequence++;
                    }
                    else
                    {
                        countSequence = 1;
                    }

                    if (countSequence > maxIncreasingSequence)
                    {
                        maxIncreasingSequence = countSequence;
                    }
                }
            }

            if (n == 0)
            {
                Console.WriteLine(--maxIncreasingSequence);
            }
            else
            {
                Console.WriteLine(maxIncreasingSequence);
            }
        }

        private static void MaximalKSum06()
        {
            int sum = 0, currentMax = int.MinValue;

            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] maxSumArray = new int[n];

            Console.WriteLine("Enter k: ");
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                maxSumArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (currentMax < maxSumArray[j])
                    {
                        currentMax = maxSumArray[j];
                    }
                }

                for (int j = 0; j < n; j++)
                {
                    if (currentMax == maxSumArray[j])
                    {
                        maxSumArray[j] = int.MinValue;
                        break;
                    }
                }

                sum += currentMax;
                currentMax = int.MinValue;
            }

            Console.WriteLine(sum);
        }

        private static void MaximalKSumSecond06()
        {
            int sum = 0, currentMax = int.MinValue;

            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] maxSumArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                maxSumArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter k: ");
            int k = int.Parse(Console.ReadLine());
            int[] maxNumsFromBigArray = new int[k];

            for (int i = 0; i < k; i++)
            {
                maxNumsFromBigArray[i] = maxSumArray[i];
            }

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (maxSumArray[j] > maxNumsFromBigArray[i])
                    {
                        maxNumsFromBigArray[i] = maxSumArray[j];
                        currentMax = maxSumArray[j];
                    }
                }

                for (int j = 0; j < n; j++)
                {
                    if (maxSumArray[j] == currentMax)
                    {
                        maxSumArray[j] = int.MinValue;
                    }
                }

                currentMax = int.MinValue;
            }

            for (int i = 0; i < k; i++)
            {
                Console.Write(maxNumsFromBigArray[i] + " ");
                sum += maxNumsFromBigArray[i];
            }

            Console.WriteLine(sum);
        }

        private static void Swap(ref int firstNum, ref int secondNum)
        {
            firstNum = firstNum + secondNum;
            secondNum = firstNum - secondNum;
            firstNum = firstNum - secondNum;
        }

        private static void SelectionSort07()
        {
            int currentMin;

            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] sortArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                sortArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                currentMin = i;

                for (int j = i; j < n; j++)
                {
                    if (sortArray[j] < sortArray[currentMin])
                    {
                        currentMin = j;
                    }
                }

                if (currentMin != i)
                {
                    Swap(ref sortArray[currentMin], ref sortArray[i]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(sortArray[i]);
            }
        }

        private static void MaximalSum08()
        {
            int maxSum = 0;
            int checkSum = 0;

            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] maxSumArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                maxSumArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n - 3; i++)
            {
                checkSum = maxSumArray[i] + maxSumArray[i + 1] + maxSumArray[i + 2] + maxSumArray[i + 3];
                if (checkSum > maxSum)
                {
                    maxSum = checkSum;
                }
            }

            Console.WriteLine(maxSum);
        }

        private static void FrequentNumber09()
        {
            int counter = 1, countHelper = 1;
            int? copyArrayElement = null;

            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] sortArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                sortArray[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(sortArray);

            for (int i = 0; i < n - 1; i++)
            {
                if (sortArray[i] == sortArray[i + 1])
                {
                    counter++;
                }
                else if (counter > countHelper)
                {
                    countHelper = counter;
                    copyArrayElement = sortArray[i];
                    counter = 1;
                }
                else
                {
                    counter = 1;
                }
            }

            Console.WriteLine("Element: " + copyArrayElement + " " + countHelper + " times.");
        }

        private static void FindSumInArray10()
        {
            int arraySum = 0;
            int? startInx = null, endInx = null;

            Console.WriteLine("Enter Sum: ");
            int givenSum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter array size: ");
            int n = int.Parse(Console.ReadLine());
            int[] findSumArray = new int[n];

            Console.WriteLine("Enter array elements: ");

            for (int i = 0; i < n; i++)
            {
                findSumArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                arraySum = 0;

                for (int j = i; j < n; j++)
                {
                    arraySum += findSumArray[j];
                    if (arraySum == givenSum)
                    {
                        startInx = i;
                        endInx = j + 1;
                        i = n;
                        break;
                    }
                }
            }

            if (startInx != null && endInx != null)
            {
                for (int i = (int)startInx; i < endInx; i++)
                {
                    Console.Write(findSumArray[i] + ", ");
                }

                Console.Write("Sum = " + givenSum + "\n");
            }
            else
            {
                Console.WriteLine("Sum not found!");
            }
        }

        private static int[] CreateAndInitArray()
        {
            Console.WriteLine("Enter array size: ");
            int n = int.Parse(Console.ReadLine());
            int[] createArray = new int[n];

            Console.WriteLine("Enter array elements: ");

            for (int i = 0; i < n; i++)
            {
                createArray[i] = int.Parse(Console.ReadLine());
            }

            return createArray;
        }

        private static void BinarySearch11()
        {
            int[] binarySearchArray = CreateAndInitArray();

            Console.WriteLine("Enter a number: ");
            int searchInxNum = int.Parse(Console.ReadLine());

            int left = 0, right = binarySearchArray.Length - 1;
            int middle;

            while (left <= right)
            {
                middle = left + (right - left) / 2;

                if (binarySearchArray[middle] == searchInxNum)
                {
                    Console.WriteLine("Index: " + middle);
                    return;
                }

                if (binarySearchArray[middle] < searchInxNum)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            Console.WriteLine("This element isn't in the array");
        }

        private static void IndexOfLetters12()
        {
            char[] alphabetArray = new char[26];

            for (int i = 0; i < 26; i++)
            {
                alphabetArray[i] = (char)('a' + i);
            }

            Console.WriteLine("Enter word: ");
            string readWord = Console.ReadLine();

            for (int i = 0; i < readWord.Length; i++)
            {
                for (int j = 0; j < alphabetArray.Length; j++)
                {
                    if (readWord[i] == alphabetArray[j])
                    {
                        Console.WriteLine(readWord[i] + " " + ((int)alphabetArray[j] - 'a'));
                    }
                }
            }
        }

        private static void Merge(int[] mergeTwoSubArrays, int left, int middle, int right)
        {
            int i, j, k;
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] LEFT = new int[n1];
            int[] RIGHT = new int[n2];

            for (i = 0; i < n1; i++)
            {
                LEFT[i] = mergeTwoSubArrays[left + i];
            }

            for (j = 0; j < n2; j++)
            {
                RIGHT[j] = mergeTwoSubArrays[middle + 1 + j];
            }

            i = 0;
            j = 0;
            k = left;

            while (i < n1 && j < n2)
            {
                if (LEFT[i] <= RIGHT[j])
                {
                    mergeTwoSubArrays[k] = LEFT[i];
                    i++;
                }
                else
                {
                    mergeTwoSubArrays[k] = RIGHT[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                mergeTwoSubArrays[k] = LEFT[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                mergeTwoSubArrays[k] = RIGHT[j];
                j++;
                k++;
            }
        }

        private static void MergeSort13(int[] mergeArray, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                MergeSort13(mergeArray, left, middle);
                MergeSort13(mergeArray, middle + 1, right);

                Merge(mergeArray, left, middle, right);
            }
        }

        private static int Partition(int[] arrayToBeSorted, int low, int high)
        {
            int pivot = arrayToBeSorted[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arrayToBeSorted[j] <= pivot)
                {
                    i++;

                    int helpSwapingTwoNumbers = arrayToBeSorted[i];
                    arrayToBeSorted[i] = arrayToBeSorted[j];
                    arrayToBeSorted[j] = helpSwapingTwoNumbers;
                }
            }

            int helpSwapingTwoNumbers2 = arrayToBeSorted[i + 1];
            arrayToBeSorted[i + 1] = arrayToBeSorted[high];
            arrayToBeSorted[high] = helpSwapingTwoNumbers2;

            return i + 1;
        }

        private static void QuickSort(int[] arrayToBeSorted, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(arrayToBeSorted, low, high);

                QuickSort(arrayToBeSorted, low, partitionIndex - 1);
                QuickSort(arrayToBeSorted, partitionIndex + 1, high);
            }
        }

        private static int[] ReadArrayFromUser()
        {
            Console.WriteLine("Enter array size: ");
            int n = int.Parse(Console.ReadLine());
            int[] arrayToBeSorted = new int[n];

            Console.WriteLine("Enter array elements: ");

            for (int i = 0; i < n; i++)
            {
                arrayToBeSorted[i] = int.Parse(Console.ReadLine());
            }

            return arrayToBeSorted;
        }

        private static void PrintArray(int[] arrayToBePrinted)
        {
            for (int i = 0; i < arrayToBePrinted.Length; i++)
            {
                Console.Write(arrayToBePrinted[i] + " ");
            }
        }

        private static void SieveOfEratosthenes15()
        {
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            bool[] prime = new bool[n + 1];

            for (int i = 0; i < n + 1; i++)
            {
                prime[i] = true;
            }

            for (int p = 2; p * p < n; p++)
            {
                if (prime[p] == true)
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        prime[i] = false;
                    }
                }
            }

            for (int i = n; i >= 2; i--)
            {
                if (prime[i] == true)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        private static bool SubsetWithSumS16(int[] subsetArray, int sum, int counter)
        {
            if (sum == 0)
            {
                return true;
            }

            if (counter == 0 && sum != 0)
            {
                return false;
            }

            if (subsetArray[counter - 1] > sum)
            {
                return SubsetWithSumS16(subsetArray, sum, counter - 1);
            }
            else
            {
                return SubsetWithSumS16(subsetArray, sum, counter - 1) ||
                       SubsetWithSumS16(subsetArray, sum - subsetArray[counter - 1], counter - 1);
            }
        }

        private static bool SubsetKWithSumS17(int[] subsetArray, int sum, int k)
        {
            int subSum = 0;
            int counter = 0;
            bool isSubsetSumExist = false;

            for (int i = 0; i < (2 << (subsetArray.Length - 1)); i++) //bitwise pow
            {

                int[] combination = new int[subsetArray.Length];

                for (int j = 0; j < subsetArray.Length; j++)
                {
                    if ((i & (1 << (subsetArray.Length - j - 1))) != 0)
                    {
                        combination[j] = subsetArray[j];
                    }
                }

                for (int j = 0; j < subsetArray.Length; j++)
                {
                    subSum += combination[j];
                    if (combination[j] != 0)
                    {
                        counter++;
                    }
                }

                if (subSum == sum && counter == k)
                {
                    isSubsetSumExist = true;
                    break;
                }
                subSum = 0;
                counter = 0;
            }

            return isSubsetSumExist;
        }

        private static bool IsSorted(int[] arr) //this function ignor all zeros
        {
            var numbersList = arr.ToList();
            numbersList.RemoveAll(i => i == 0);
            arr = numbersList.ToArray();

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    return false;
                }
            }

            return true;
        }

        private static void RemoveElementsFromArray18()
        {
            int[] removeElementsArray = ReadArrayFromUser();
            int minRemoveElements = int.MaxValue;
            int countRemovedElements = 0;

            for (int i = 0; i < (2 << (removeElementsArray.Length - 1)); i++) //bitwise pow
            {
                int[] combination = new int[removeElementsArray.Length];

                for (int j = 0; j < removeElementsArray.Length; j++)
                {
                    if ((i & (1 << (removeElementsArray.Length - j - 1))) != 0)
                    {
                        combination[j] = removeElementsArray[j];
                    }
                }

                if (IsSorted(combination))
                {
                    for (int j = 0; j < removeElementsArray.Length; j++)
                    {
                        if (combination[j] == 0)
                        {
                            countRemovedElements++;
                        }
                    }

                    if (countRemovedElements < minRemoveElements)
                    {
                        minRemoveElements = countRemovedElements;
                    }

                    countRemovedElements = 0;
                }
            }

            Console.WriteLine(minRemoveElements);
        }

        private static void PermutationsOfSet19(int[] permutationArray, int l, int r)
        {
            if (l == r)
            {
                for (int i = 0; i < permutationArray.Length; i++)
                {
                    Console.Write(permutationArray[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    permutationArray = SwapArr(permutationArray, l, i);
                    PermutationsOfSet19(permutationArray, l + 1, r);
                    permutationArray = SwapArr(permutationArray, l, i);
                }
            }
        }

        public static int[] SwapArr(int[] a, int i, int j)
        {
            int swapInt = a[i];
            a[i] = a[j];
            a[j] = swapInt;

            return a;
        }

        private static void VariationsOfSet21()
        {
            Console.Write("Enter a number N: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter a number K: ");
            int k = int.Parse(Console.ReadLine());

            int[] elem = Enumerable.Repeat(1, k).ToArray();

            int c;

            do
            {
                c = 1;
                PrintElements(elem);

                for (int i = 0; i < k; i++)
                {
                    elem[i] += c;

                    if (elem[i] <= n)
                    {
                        c = 0; break;
                    }
                    else
                    {
                        elem[i] = c = 1;
                    }
                }
            }
            while (c != 1);
        }


        private static void PrintElements(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }

        private static void CombinationsOfSet22()
        {
            Console.Write("Enter a number N: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter a number K: ");
            int k = int.Parse(Console.ReadLine());

            int[] elem = Enumerable.Repeat(1, k).ToArray();

            int c;

            do
            {
                c = 1;

                if (IsElementsInIncreasingOrder(elem))
                    PrintElements(elem);

                for (int i = 0; i < k; i++)
                {
                    elem[i] += c;

                    if (elem[i] <= n)
                    {
                        c = 0; break;
                    }
                    else
                    {
                        elem[i] = c = 1;
                    }
                }
            }
            while (c != 1);
        }

        private static bool IsElementsInIncreasingOrder(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static void Main()
        {
            /*
            AllocateArray01();
            CompareArrays02();
            CompareCharArrays03();
            MaximalSequence04();
            MaximalIncreasingSequence05();
            MaximalKSum06();
            MaximalKSumSecond06();
            SelectionSort07();
            MaximalSum08();
            FrequentNumber09();
            FindSumInArray10(); 
            BinarySearch11();
            IndexOfLetters12();
            */

            /* Task 13
            int[] arrayToBeSorted = ReadArrayFromUser();

            Console.Write("Not Sorted: ");

            PrintArray(arrayToBeSorted);

            MergeSort13(arrayToBeSorted, 0, arrayToBeSorted.Length - 1);

            Console.WriteLine();
            Console.Write("Sorted: ");

            PrintArray(arrayToBeSorted);
            */

            /* Task 14
            int[] arrayToBeSorted = ReadArrayFromUser();

            Console.Write("Not Sorted: ");

            PrintArray(arrayToBeSorted);

            QuickSort(arrayToBeSorted, 0, arrayToBeSorted.Length - 1);

            Console.WriteLine();
            Console.Write("Sorted: ");

            PrintArray(arrayToBeSorted);
            */

            //SieveOfEratosthenes15();

            /* Task 16
            int[] subsetArray = ReadArrayFromUser();//{ 2, 1, 2, 4, 3, 5, 2, 6 };
            Console.WriteLine("Enter sum: ");
            int sum = int.Parse(Console.ReadLine()); //14;
            Console.WriteLine(SubsetWithSumS16(subsetArray, sum, subsetArray.Length) ? "Yes" : "No");
            */

            /* Task 17
            int[] subsetArray = ReadArrayFromUser();  //{ 2, 1, 2, 4, 3, 5, 2, 6 };
            Console.WriteLine("Enter sum: ");
            int sum = int.Parse(Console.ReadLine());  //14;
            Console.WriteLine("Enter k: ");
            int k = int.Parse(Console.ReadLine()); // 4; 
            Console.WriteLine(SubsetKWithSumS17(subsetArray, sum, k) ? "Yes" : "No");
            */

            //RemoveElementsFromArray18();

            /*
            int n = int.Parse(Console.ReadLine());
            int[] permutationArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                permutationArray[i] = i + 1;
            }
            PermutationsOfSet19(permutationArray, 0, n - 1);
            */

            //VariationsOfSet21();

            //CombinationsOfSet22();
        }
    }
}
