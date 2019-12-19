using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GemBlocks.Utils
{
    /// <inheritdoc />
    /// <summary>
    /// A class to work around T[][]
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RectArray<T> : IEnumerable<T>
    {
        public T[][] Array;

        public T[][] ToArray()
        {
            return Array;
        }

        public static explicit operator RectArray<T>(T[][] tVal)
        {
            return new RectArray<T>(tVal);
        }

        public void Set(int index, int index2, T value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            Array[index][index2] = value;
        }

        public T Get(int index, int index2)
        {
            return Array[index][index2];
        }

        public void Add(T[] value)
        {
            List<T[]> v = Array.ToList();
            v.Add(value);
            Array = v.ToArray();
        }

        public T[][] All(int size1, int size2)
        {
            object[][] newArray = new object[size1][];
            for (int array1 = 0; array1 < size1; array1++)
            {
                newArray[array1] = new object[size2];
            }

            return (T[][])(object)newArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)Array.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Array.GetEnumerator();
        }

        public RectArray()
        {

        }

        public RectArray(T[][] arr)
        {
            Array = arr;
        }

        public RectArray(int size1, int size2)
        {
            T[][] newArray = new T[size1][];
            for (int array1 = 0; array1 < size1; array1++)
            {
                newArray[array1] = new T[size2];
            }

            Array = newArray;
        }

        public T[,] ToMultiDimArray()
        {
            int minorLength = Array[0].Length;
            T[,] ret = new T[Array.Length, minorLength];

            for (int i = 0; i < Array.Length; i++)
            {
                var array = Array[i];
                if (array.Length != minorLength)
                {
                    throw new ArgumentException("All arrays must be the same length");
                }

                for (int j = 0; j < minorLength; j++)
                {
                    ret[i, j] = array[j];
                }
            }

            return ret;
        }
    }

}
