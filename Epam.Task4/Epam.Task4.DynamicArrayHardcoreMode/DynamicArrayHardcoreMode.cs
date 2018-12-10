using System;
using System.Collections.Generic;
using Epam.Task4.DynamicArray;

namespace Epam.Task4.DynamicArrayHardcoreMode
{
    internal class DynamicArrayHardcoreMode<T> : DynamicArray<T>, ICloneable
    {
        public DynamicArrayHardcoreMode()
        {
        }

        public DynamicArrayHardcoreMode(int n) : base(n)
        {
        }

        public DynamicArrayHardcoreMode(IEnumerable<T> arr) : base(arr)
        {
        }

        public new T this[int index]
        {
            get
            {
                if (index >= 0)
                {
                    return base[index];
                }

                return base[index + this.Length];
            }

            set
            {
                if (index >= 0)
                {
                    base[index] = value;
                }

                base[index + this.Length] = value;
            }
        }

        public object Clone()
        {
            var temp = new DynamicArrayHardcoreMode<T>(Capacity);
            temp.AddRange(this.InnerArray);
            temp.Length = this.Length;
            return temp;
        }

        public void SetCapacity(int index)
        {
            if (index < this.Length)
            {
                this.Length = index;
            }

            var tmp = new T[index];
            for (var i = 0; (i < index) & (i < this.Capacity); i++)
            {
                tmp[i] = this.InnerArray[i];
            }

            this.InnerArray = tmp;
        }

        public T[] ToArray()
        {
            var arrayResult = new T[this.Length];
            for (var i = 0; i < this.Length; i++)
            {
                arrayResult[i] = this.InnerArray[i];
            }

            return arrayResult;
        }
    }
}