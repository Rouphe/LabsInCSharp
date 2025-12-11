using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Principal;


namespace Lab3.Library
{
    /// <summary>
    /// Для работы с динамическими массивами
    /// </summary>
    /// <typeparam name="T">тип параметров динамического массива</typeparam>
    public class DynamicArray<T> : IEnumerable<T>, IEnumerable
    {
        private T[] dynArray;
        public DynamicArray() 
        {
            dynArray = new T[8];
        }

        public DynamicArray(int size)
        {
            if (size < 1)
            {
                throw new ArgumentException("Параметр должен быть больше 0", nameof(size));
            }

            dynArray = new T[size];
        }

        public DynamicArray(IEnumerable<T> collection) 
        {
            dynArray = collection.ToArray();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in dynArray)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Копировать массив
        /// </summary>
        /// <param name="arrayFrom">Откуда копируем</param>
        /// <param name="arrayIn">Куда копируем</param>
        private static void CopyArray(T[] arrayFrom, T[]arrayIn)
        {
            for (int i = 0; i < arrayFrom.Length; i++)
            {
                arrayIn [i] = arrayFrom[i];
            }
        }

        public static T[] Add(T[] array, T item) 
        {
            if (array.Length < 1)
            {
                array = new T[1];
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = item;
                    return array;
                }   
            }

            T[] arrayX2 = new T[array.Length * 2];
            CopyArray(array, arrayX2);
            arrayX2[array.Length] = item;
            return arrayX2;
        }

    }
}
