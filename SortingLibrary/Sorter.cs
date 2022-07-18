using System;

namespace SortingLibrary
{
    public class Sorter<T> where T : IComparable<T>
    {
        public static void BubbleSort(T[] arr)
        {
            bool isDone = false;

            while (isDone == false)
            {
                isDone = true;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i].CompareTo(arr[i + 1]) > 0)
                    {
                        var Num = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = Num;
                        isDone = false;
                    }
                }

            }


        }

        public static void InsertionSort(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var NumberToCompair = arr[i];
                for (int y = i - 1; y > -1; y--)
                {
                    if (NumberToCompair.CompareTo(arr[y]) < 0)
                    {
                        arr[y + 1] = arr[y];
                        arr[y] = NumberToCompair;
                    }
                    else
                    {
                        break;
                    }
                }

            }
        }

        public static void SelectionSort(T[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int TempNumber = i;

                for (int y = i + 1; y < arr.Length; y++)
                {
                    if (arr[TempNumber].CompareTo(arr[y]) > 0)
                    {
                        TempNumber = y;
                    }
                }
                var UpdateTheNumber = arr[TempNumber];
                arr[TempNumber] = arr[i];
                arr[i] = UpdateTheNumber;
            }
        }

        public static void QuickSort(T[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }

        public static int Partition(T[] arr, int start, int end)
        {

            T pivot = arr[end];
            int smaller = start;

            for (int i = start; i < end; i++)
            {
                T tempNumber = arr[i];
                if (tempNumber.CompareTo(pivot) < 0)
                {
                    arr[i] = arr[smaller];
                    arr[smaller] = tempNumber;

                    smaller++;
                }
            }

            arr[end] = arr[smaller];
            arr[smaller] = pivot;

            return smaller;
        }

        private static void QuickSort(T[] arr, int start,int end)
        {
            if(start >= end)
            {
                return;
            }
            int index = Partition(arr, start, end);
            QuickSort(arr, start, index - 1);
            QuickSort(arr, index + 1, end);
        }

        public static void MergeSort(T[] arr)
        {
            int arrLenght = arr.Length;

            if (arr.Length == 1) return;

            int midArr = arrLenght / 2;

            T[] arr1 = new T[midArr];
            T[] arr2 = new T[arrLenght - midArr];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = arr[i + midArr];
            }

            MergeSort(arr1);
            MergeSort(arr2);
            Merge(arr, arr1, arr2);

        }

        public static void Merge(T[] arr, T[] left, T[]right)
        {
            
            int lIndex = 0;
            int rIndex = 0;

            int leftSide = left.Length;
            int rightSide = right.Length;

            int AllIndexs = leftSide + rightSide;

            for (int i = 0; i < AllIndexs; i++)
            {
                if(lIndex >= leftSide)
                {
                    arr[i] = right[rIndex];
                    rIndex++;
                }
                else if(rIndex >= right.Length)
                {
                    arr[i] = left[lIndex];
                    lIndex++;
                }
                else if(left[lIndex].CompareTo(right[rIndex])<0)
                {
                    arr[i] = left[lIndex];
                    lIndex++;
                }
                else
                {
                    arr[i] = right[rIndex];
                    rIndex++;
                }
            }


        }

    }
}
