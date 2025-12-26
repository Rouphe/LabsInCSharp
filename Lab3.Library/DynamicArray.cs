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
        private int n = 8;
        private T[] dynArray;
        private int length;
        public DynamicArray() 
        {
            dynArray = new T[n];
            length = 0;
        }

        public DynamicArray(int size)
        {
            if (size < 1)
            {
                throw new ArgumentException("Параметр должен быть больше 0", nameof(size));
            }

            dynArray = new T[size];
            length = 0;
        }

        public DynamicArray(IEnumerable<T> collection) 
        {
            dynArray = collection.ToArray();
            length = dynArray.Length;   
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

        /// <summary>
        /// Добавить эллемент в конец массива
        /// </summary>
        /// <param name="array">массив</param>
        /// <param name="item">элемент</param>
        /// <returns>Массив с новым элементом</returns>

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
            array = arrayX2;
            return array;
        }

        /// <summary>
        /// Добавить содержимое коллекции в конец массива
        /// </summary>
        /// <param name="array">массив</param>
        /// <param name="collection">коллекция</param>
        /// <returns>Массив с добавленной коллекцией</returns>
        /// <exception cref="ArgumentException">Ошибка при передачи пустой коллекции</exception>
        public static T[] AddRange(T[] array, IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentException("Коллекция не должна быть пустой", nameof(collection));
            }

            int collectionCountElements = collection.Count();
            int correntCount = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    correntCount++;
                }
            }

            int requiredLenght = collectionCountElements + correntCount;
            if (requiredLenght > array.Length)
            {
                int newLenght = array.Length;
                while (newLenght < requiredLenght)
                {
                    newLenght *= 2;
                }

                T[] newArray = new T[newLenght];
                CopyArray(array, newArray);
                array = newArray;
            }
            

            foreach (var item in collection)
            {
                array[correntCount++] = item;
            }

            return array;
        }

        /// <summary>
        /// Удалить элемент
        /// </summary>
        /// <param name="item">элемент</param>
        /// <returns>true - элемент удалён, false - Элемент не найден</returns>
        public bool Remove(T item)
        {
            if (EqualityComparer<T>.Default.Equals(item, default(T)))
            {
                for (int i = 0; i < length; i++)
                {
                    if (EqualityComparer<T>.Default.Equals(dynArray[i], default(T)))
                    {
                        for (int j = i; j < length - 1; j++)
                        {
                            dynArray[j] = dynArray[j + 1];
                        }
                        dynArray[length - 1] = default(T);
                        length--;
                        return true;
                    }
                }
                return false;
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    if (EqualityComparer<T>.Default.Equals(dynArray[i], item))
                    {
                        for (int j = i; j < length - 1; j++)
                        {
                            dynArray[j] = dynArray[j + 1];
                        }
                        dynArray[length - 1] = default(T);
                        length--;
                        return true;
                    }
                }
                return false;
            }
        }

        /// <summary>
        /// Добавить элемент в ячейку заданного индекса
        /// </summary>
        /// <param name="index">индекс ячейки</param>
        /// <param name="item">элемент</param>
        /// <returns>true - элемент добавлен</returns>
        /// <exception cref="ArgumentOutOfRangeException">Ошибка выхода за пределы массива</exception>
        public bool Insert(int index, T item)
        {
            if (index < 0 || index > length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Индекс выходит за границы массива");
            }

            if (length >= dynArray.Length)
            {
                int newCapacity = dynArray.Length * 2;
                T[] newArray = new T[newCapacity];
                CopyArray(dynArray, newArray);
                dynArray = newArray;
            }

            for (int i = length; i > index; i--)
            {
                dynArray[i] = dynArray[i - 1];
            }

            dynArray[index] = item;
            length++;
            return true;
        }

        /// <summary>
        /// Количество элемментов в массиве
        /// </summary>
        public int Length
        {
            get { return length; }
        }

        /// <summary>
        /// Максимальлная длина массива
        /// </summary>
        public int Capacity
        {
            get { return dynArray.Length; }
        }

        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="index"></param>
        /// <returns>get -  эллемент по указоному индексу, set - присваивание значения элемента по индексу</returns>
        /// <exception cref="ArgumentOutOfRangeException">Ошибка выхода за пределы массива</exception>
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= length)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Индекс выходит за границы массива");
                }
                return dynArray[index];
            }
            set
            {
                if (index < 0 || index >= length)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Индекс выходит за границы массива");
                }
                dynArray[index] = value;
            }
        }

    }
}
