using System;

namespace IUP.Toolkits
{
    public sealed class DynamicBuffer<T>
    {
        public DynamicBuffer(int size) => Array = new T[size];

        public T[] Array { get; private set; }

        public void Resize(int newLength, bool preserveData = false)
        {
            T[] array = new T[newLength];
            if (preserveData)
            {
                System.Array.Copy(Array, array, newLength);
            }
            Array = array;
        }

        public void Grow(int growingStep, int maxLength = int.MaxValue, bool preserveData = false)
        {
            if (growingStep <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(growingStep));
            }
            if (maxLength < Array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(maxLength));
            }
            long longLength = IUP_Math.Safe.Sum(Array.Length, growingStep);
            longLength = IUP_Math.Min(longLength, maxLength);
            int newLength = (int)longLength;
            T[] array = new T[newLength];
            if (preserveData)
            {
                System.Array.Copy(Array, array, newLength);
            }
            Array = array;
        }

        public void Shrink(int newLength)
        {
            if (newLength < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(newLength));
            }
            if (newLength > Array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(newLength));
            }
            Array = new T[newLength];
        }

        public void ClearFrom(int fromIndex)
        {
            for (int i = fromIndex; i < Array.Length; i += 1)
            {
                Array[i] = default;
            }
        }

        public void Clear()
        {
            for (int i = 0; i < Array.Length; i += 1)
            {
                Array[i] = default;
            }
        }
    }
}
