using System;

namespace IndexDemo
{
    public class array
    {
        float[] arr = new float[] { 12.4f, 67.8f,34.12f,89.32f,11.2f};
        public float this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
    }
}
