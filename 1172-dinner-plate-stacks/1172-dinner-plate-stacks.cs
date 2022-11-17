 public class PlateStack
    {
        public Stack<int> plates;

        public PlateStack()
        {
            plates = new Stack<int>();


        }
        public int getSize()
        {
            return plates.Count();
        }
    }

    public class DinnerPlates
    {
        List<PlateStack> dinnerPlates;
        PriorityQueue<int, int> emptyStaks;
        int LeftMostStack ; 
        public int capacity;

        public DinnerPlates(int capacity)
        {
            dinnerPlates = new List<PlateStack>();
            emptyStaks = new PriorityQueue<int, int>();
            LeftMostStack = 0 ;  
            this.capacity = capacity;
        }
        public void Push(int val)
        {
            if (dinnerPlates == null || dinnerPlates.Count == 0)
            {
                PushToNewStack(val);
            }

            else if (emptyStaks.Count > 0)
            {
                PushToLeftMostEmptyStack(val);
            }
            else if (dinnerPlates[dinnerPlates.Count - 1].getSize() >= capacity)
            {
                PushToNewStack(val);
            }
            else
            {
                PushToLastStack(val);
            }

        }

        private void PushToLastStack(int val)
        {
            dinnerPlates[LeftMostStack].plates.Push(val);
        }

        private void PushToNewStack(int val)
        {
            PlateStack newStack = new PlateStack();
            newStack.plates.Push(val);
            dinnerPlates.Add(newStack);
            LeftMostStack = dinnerPlates.Count-1; 
        }
        private void PushToLeftMostEmptyStack(int val)
        {
            int leftMostEmptyStack = emptyStaks.Dequeue();
            dinnerPlates[leftMostEmptyStack].plates.Push(val);
              if (LeftMostStack < leftMostEmptyStack) LeftMostStack = leftMostEmptyStack;
        }

        public int Pop()
        {
            if (dinnerPlates == null || dinnerPlates.Count == 0)
                return -1;

            else
                return PopHelpper(LeftMostStack);

        }
        public int PopHelpper(int index)
        {
            if (dinnerPlates[index].plates.Count == 0)
            {
                if (index <= 0) return -1;
                 
                 LeftMostStack--;
               return PopHelpper(LeftMostStack);
              
            }
            int val = dinnerPlates[index].plates.Pop();
              emptyStaks.Enqueue(index , index);
            return val;
        }

        public int PopAtStack(int index)
        {
           // if (index == LeftMostStack) return Pop(); 
            if (dinnerPlates.Count <= index) return -1;
            PlateStack stackToRomoveFrom = dinnerPlates[index];
            if (stackToRomoveFrom.plates.Count <= 0) return -1;
            int popedVal = stackToRomoveFrom.plates.Pop();
            emptyStaks.Enqueue(index,  index);
            return popedVal;
        }
    }
/**
 * Your DinnerPlates object will be instantiated and called as such:
 * DinnerPlates obj = new DinnerPlates(capacity);
 * obj.Push(val);
 * int param_2 = obj.Pop();
 * int param_3 = obj.PopAtStack(index);
 */