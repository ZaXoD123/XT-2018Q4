using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Epam.Task4.DynamicArray
{
    public class DynamicArray<T> : IEnumerable<T>
    {
         public DynamicArray() : this(8)
        {
        }

        public DynamicArray(int n)
        {
            this.InnerArray = new T[n];
            this.Length = 0;
        }

        public DynamicArray(IEnumerable<T> inputCollection) : this(inputCollection.Count())
        {
            var tempIndex = 0;
            this.Length = inputCollection.Count();
            foreach (var item in inputCollection)
            {
                this.InnerArray[tempIndex++] = item;
            }
        }

        public int Length { get; protected set; }

        public int Capacity => this.InnerArray.Length;

        protected T[] InnerArray { get; set; }
        
        public T this[int index]
        {
            get
            {
                if (!this.IsIndexCorrect(index))
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.InnerArray[index];
            }

            set
            {
                if (!this.IsIndexCorrect(index))
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.InnerArray[index] = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = 0; i < this.Length; i++)
            {
                yield return this.InnerArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Add(T newItem)
        {
            if (this.Length == this.Capacity)
            {
                this.SetLargerCapacity(this.Capacity);
            }

            this.InnerArray[this.Length++] = newItem;
        }

        public void AddRange(IEnumerable<T> addableCollection)
        {
            if (addableCollection.Count() + this.Length > this.Capacity)
            {
                this.SetLargerCapacity(addableCollection.Count() + this.Length - this.Capacity);
            }

            foreach (var item in addableCollection)
            {
                this.InnerArray[this.Length++] = item;
            }
        }

        public bool Insert(T element, int index)
        {
            if (!this.IsIndexCorrect(index))
            {
                return false;
            }

            var tmp = this.InnerArray[this.Length - 1];
            for (var i = this.Length - 1; i > index; i--)
            {
                this.InnerArray[i] = this.InnerArray[i - 1];
            }

            this.InnerArray[index] = element;
            this.Add(tmp);
            return true;
        }

        public bool Remove(int index)
        {
            if (!this.IsIndexCorrect(index))
            {
                return false;
            }

            for (var i = index; i < this.Length - 1; i++)
            {
                this.InnerArray[i] = this.InnerArray[i + 1];
            }

            this.Length--;
            return true;
        }

        protected void SetLargerCapacity(int i)
        {
            var tmpArray = new T[this.Capacity + i];
            this.InnerArray.CopyTo(tmpArray, 0);
            this.InnerArray = tmpArray;
        }

        private bool IsIndexCorrect(int index)
        {
            return !((index > this.Length - 1) | (index < 0));
        }
    }
}