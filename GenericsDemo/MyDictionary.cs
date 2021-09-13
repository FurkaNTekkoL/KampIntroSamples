using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    class MyDictionary<T>
    {
        T[] _numbers;
        T[] _tempArray;

        public MyDictionary()
        {
            _numbers = new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _numbers;
            _tempArray = new T[_numbers.Length+1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _numbers[i] = _tempArray[i];
            }

            _numbers[_numbers.Length - 1] = item;

        }
    }
}
