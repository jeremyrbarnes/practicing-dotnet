using PracticingDotNet.Util;;

namespace PracticingDotNet.Array
{
    class ArrayExercises
    {
        protected int[] _numbers;

        public ArrayExercises(int size = DEFAULT_SIZE)
        {
            _numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                _numbers[i] = i + 1;
            }
        }

        public void Scramble(int size = DEFAULT_SIZE)
        {
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                int randomIndex = rand.Next(size);
                int temp = _numbers[i];
                _numbers[i] = _numbers[randomIndex];
                _numbers[randomIndex] = temp;
            }
        }

        public int[] GetArray()
        {
            return _numbers;
        }

        public int GetElementAt(int index)
        {
            if (index < 0 || index >= _numbers.Length)
            {
                throw new IndexOutOfRangeException("Index is out of bounds.");
            }
            return _numbers[index];
        }

        public void Sort(SortType.Type sortType)
        {
            _numbers = sortType switch
            {
                SortType.Type.Bubble => BubbleSort(),
                SortType.Type.Selection => SelectionSort(_numbers),
                SortType.Type.Insertion => InsertionSort(_numbers),
                SortType.Type.Merge => MergeSort(_numbers),
                SortType.Type.Quick => QuickSort(_numbers),
                _ => _numbers,
            };
        }

        protected int[] BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = _numbers[j];
                        _numbers[j] = _numbers[j + 1];
                        _numbers[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        protected int[] SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = _numbers[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }

        protected int[] InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            return arr;
        }

        protected int[] MergeSort(int[] arr)
        {
            return null;
        }

        protected int[] QuickSort(int[] arr)
        {
            return null;
        }

        public void Reverse()
        {
            Array.Reverse(_numbers);
        }
    }
}
