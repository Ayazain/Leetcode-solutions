 public class MedianFinder
    {
        public class Node
        {
            public double val;
            public Node next;
            public Node prv;
            public Node(int _val, Node _prv)
            {
                val = _val;
                prv = _prv;
                next = null;
            }

        }

        public Node LastMed;
        public bool even;
        public int length;
        public Node root;
        public MedianFinder()
        {
            LastMed = null;
            even = true;
            root = null;
            length = 0;
        }
        public void UpdateLastMid (int num )
        {
            if (LastMed.val <= num) // elemnt added after the mid   
                {
                    if (length % 2 == 1)
                        LastMed = LastMed.next;
                }
                else // elemnt added befor 
                {
                    if (length % 2 == 0)
                    LastMed = LastMed.prv;
                }
          
        }

        public void AddNum(int num)
        {
            length++;
            if (root == null)  //add firest elemnt  
            {
                root = new Node(num, null);
                LastMed = root;
            }
            else  //add num in the right pos  
            {
                Node copy = root;
                Node prv = null;
                bool AddLast = false;
                while (copy.val <= num) // get frist elemnt greter than me
                {
                    if (copy.next == null) { prv = copy; AddLast = true; break; } // add after  here i have the last elemnt 
                    copy = copy.next;
                }
                if (prv == null) prv = copy.prv;
                Node NewNode = new Node(num, prv);
                if (prv != null) prv.next = NewNode;
                if (!AddLast) { copy.prv = NewNode; NewNode.next = copy; }
                  if (copy == root && copy.prv!=null)  root = NewNode;// if i updated the first node 
              UpdateLastMid(num) ; 
            }


        }

        public double FindMedian()
        {
            if (length % 2 == 1)
                return LastMed.val;
            else
                return
                  (LastMed.val + LastMed.next.val) / 2;
        }
    }

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */