using System;
using System.Linq;

namespace dailyTasks
{
    public class Tasks
    {
        #region k-lists

        /*
        public static class IDictionaryExtensions
        {
            public static TKey FindKeyByValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TValue value)
            {
                if (dictionary == null)
                    throw new ArgumentNullException("dictionary");
    
                foreach (KeyValuePair<TKey, TValue> pair in dictionary)
                    if (value.Equals(pair.Value))
                        return pair.Key;
    
                throw new Exception("the value is not found in the dictionary");
            }
        }

      public class minHeap
        {
            public int size;
            public int[] mH;
            public int position;

            public minHeap(int size)
            {
                this.size = size;
                mH = new int[size + 1];
                position = 0;
            }

            public void createHeap(int[] arrA)
            {
                if (arrA.Length > 0)
                {
                    for (int i = 0; i < arrA.Length; i++)
                    {
                        insert(arrA[i]);
                    }
                }
            }

            public void display()
            {
                for (int i = 1; i < mH.Length; i++)
                {
                    Console.Write(" " + mH[i]);
                }

                Console.Write("");
            }

            public void insert(int x)
            {
                if (position == 0)
                {
                    mH[position + 1] = x;
                    position = 2;
                }
                else
                {
                    mH[position++] = x;
                    bubbleUp();
                }
            }

            public void bubbleUp()
            {
                int pos = position - 1;
                while (pos > 0 && mH[pos / 2] > mH[pos])
                {
                    int y = mH[pos];
                    mH[pos] = mH[pos / 2];
                    mH[pos / 2] = y;
                    pos = pos / 2;
                }
            }

            public int extractMin()
            {
                int min = mH[1];
                mH[1] = mH[position - 1];
                mH[position - 1] = 0;
                position--;
                sinkDown(1);
                return min;
            }

            public void sinkDown(int k)
            {
                int a = mH[k];
                int smallest = k;
                if (2 * k < position && mH[smallest] > mH[2 * k])
                {
                    smallest = 2 * k;
                }

                if (2 * k + 1 < position && mH[smallest] > mH[2 * k + 1])
                {
                    smallest = 2 * k + 1;
                }

                if (smallest != k)
                {
                    swap(k, smallest);
                    sinkDown(smallest);
                }

            }

            public void swap(int a, int b)
            {
                //System.out.println("swappinh" + mH[a] + " and " + mH[b]);
                int temp = mH[a];
                mH[a] = mH[b];
                mH[b] = temp;
            }
        }


        public static void OptimalMergeSort(byte[] a, out int min1, out int min2)
        {
            min1 = a[0];
            min2 = a[1];
            if (min2 < min1)
            {
                min1 = a[1];
                min2 = a[0];
            }

            for (int i = 2; i < a.Length; i++)
            {
                if (a[i] < min1)
                {
                    min2 = min1;
                    min1 = a[i];
                }
                else if (a[i] < min2)
                {
                    min2 = a[i];
                }
            }
        }

        public static byte[] MergeSort(byte[] array1, byte[] array2, int m, int n)
        {
            byte[] result = new byte[n+m];
            int i = 0;
            int k = 0;
            int j = 0;
            int added = 0;
            while (i<m &&j<n)
            {
                if (array1[i] == array2[j])
                {
                    result[k] = array1[i];
                    i++;
                    j++;
                    added++;
                }
                else
                {
                    if (array1[i] < array2[j])
                    {
                        result[k] = array1[i];
                        i++;
                        added++;
                    }
                    else
                    {
                        result[k] = array2[j];
                        j++;
                        added++;
                    }
                }
            }

            //Package to reference type
            Array.Resize(ref result, added);
            return result;
        }

        //min heap?
                  byte n = 4;
            //TODO SOMETHING WITH DUPLICATE DATA
            byte[] n1 = new byte[] {6, 2, 26, 64, 88, 96, 96};
            byte[] n2 = new byte[] {4, 8, 20, 65, 86};
            byte[] n3 = new byte[] {7, 1, 4, 16, 42, 58, 61, 69};
            byte[] n4 = new byte[] {84, 1};//
            byte[] n5 = new byte[] {1, 16};
            byte[] n6 = new byte[] {1, 84};
            byte[] n7 = new byte[] {1, 84};// Contain?
           
           
            //TODO KeyValuePair
            var massive = new Dictionary<KeyValuePair<byte,int> ,byte[]>();

            byte[] r = new byte[] {2, 7, 5, 8, 2}; //change to massive.Values

            
             /*for (int i = 0; i < n; i++)
             {
                 byte[] b = Console.ReadLine().Split(' ')
                     .GroupBy(x => x).Select(x => Convert.ToByte(x)).ToArray();
                 Array.Sort(b);
                 massive.Add(b, b.Length);
             }#1#
            Array.Sort(n1);
            Array.Sort(n2);
            Array.Sort(n3);
            Array.Sort(n4);
            Array.Sort(n5);
            
            massive.Add(new KeyValuePair<byte,int>(0,n1.Length),n1);
            massive.Add(new KeyValuePair<byte,int>(1,n2.Length),n2);
            massive.Add(new KeyValuePair<byte,int>(2,n3.Length),n3);
            massive.Add(new KeyValuePair<byte,int>(3,n4.Length),n4);
            massive.Add(new KeyValuePair<byte,int>(4,n5.Length),n5);
            
            

            while (n >= 0)
            {
                int min1 = 0;
                int min2 = 0;
                OptimalMergeSort(r, out min1, out min2);
                var q = new KeyValuePair<byte, int>(0, min1);
                byte[] result = MergeSort(massive[q], massive, min1, min2);
                massive.Remove();
                massive.Add(result, result.Length);
                
                n--;
            }


            //Remove arrays from dictionary? time<
            //Do nothing Space x2
            */
            
            

#endregion

    }
}