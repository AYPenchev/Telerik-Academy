using System;

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
            Console.WriteLine("Enter Sum: ");
            int givenSum = int.Parse(Console.ReadLine());
            int arraySum = 0;
            int? startInx = null, endInx = null;
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] findSumArray = new int[n];

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

            for (int i = (int)startInx; i < endInx; i++)
            {
                Console.Write(findSumArray[i] + ", ");
            }
            Console.Write(givenSum);
        }

        static void Main()
        {
            /*AllocateArray01();
            CompareArrays02();
            CompareCharArrays03();
            MaximalSequence04();
            MaximalIncreasingSequence05();
            MaximalKSum06();
            MaximalKSumSecond06();
            SelectionSort07();
            MaximalSum08();
            FrequentNumber09();*/
            FindSumInArray10();
        }
    }
}
