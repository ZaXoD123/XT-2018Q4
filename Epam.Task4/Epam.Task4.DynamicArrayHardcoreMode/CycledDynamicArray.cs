using System;
using System.Collections;
using System.Collections.Generic;
using Epam.Task4.DynamicArray;

namespace Epam.Task4.DynamicArrayHardcoreMode
{
    internal class CycledDynamicArray<T> : DynamicArray<T>, IEnumerable<T>, IEnumerator<T>
    {
        private int position;

        public CycledDynamicArray()
        {
        }

        public CycledDynamicArray(int n) : base(n)
        {
        }

        public CycledDynamicArray(IEnumerable<T> arr) : base(arr)
        {
        }
        
        T IEnumerator<T>.Current => this.InnerArray[this.position];

        object IEnumerator.Current => this.InnerArray[this.position];
        
        public new IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return base.GetEnumerator();
        }

        void IDisposable.Dispose()
        {
        }

        bool IEnumerator.MoveNext()
        {
            this.position = ++this.position % InnerArray.Length;
            return true;
        }

        void IEnumerator.Reset()
        {
            this.position = 0;
        }
    }
}