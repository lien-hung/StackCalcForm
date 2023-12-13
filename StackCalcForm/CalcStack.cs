namespace StackCalcForm
{
    class CalcStack<T>
    {
        private readonly T[] items;
        private int top;
        private readonly int capacity;
        public int Count;
        public CalcStack(int size)
        {
            capacity = size;
            items = new T[capacity];
            top = -1;
            Count = 0;
        }
        public void Push(T item)
        {
            items[++top] = item;
            Count++;
        }
        public T? Pop()
        {
            if (top == -1)
            {
                return default;
            }
            T poppedItem = items[top--];
            Count--;
            return poppedItem;
        }
        public T Peek()
        {
            return items[top];
        }
        public bool IsEmpty()
        {
            return top == -1;
        }
    }
}