

namespace LeetcodeProblems
{
    public class SLL
    {
        public ListNode head;
        public ListNode tail;
        public int size;
        public SLL()
        {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }

        public void InsertAtFirstPosition(int value)
        {
            ListNode newNode = new ListNode(value);
            if(head==null)
            {
                head = newNode;
                tail = newNode;
                size++;
                return;
            }
            newNode.next = head;
            head= newNode;
            size++;
        }

        public void InsertAtLastPosition(int value)
        {
            ListNode newNode= new ListNode(value);

            if(head==null)
            {
                InsertAtFirstPosition(value);
                return;
            }
            tail.next = newNode;
            tail = newNode;
            size++;
        }

        public ListNode OddEvenList()
        {
            ListNode curr = head;

            ListNode oddList = null;
            ListNode evenList = null;

            ListNode tempEven=null;
            ListNode tempOdd = null;
            while (curr != null)
            {
                ListNode newNode = new ListNode(curr.val, null);
                if (newNode.val % 2 == 0)
                {
                    if (evenList == null)
                    {
                        evenList = newNode;
                    }
                    else
                    {
                        tempEven = evenList;
                        while (tempEven.next != null)
                        {
                            tempEven = tempEven.next;
                        }
                        tempEven.next = newNode;
                    }
                }
                else
                {
                    if (oddList == null)
                    {
                        oddList = newNode;
                    }
                    else
                    {
                        tempOdd = oddList;
                        while (tempOdd.next != null)
                        {
                            tempOdd = tempOdd.next;
                        }
                        tempOdd.next = newNode;
                    }
                }
                curr = curr.next;
            }

            ListNode result= null;
            tempEven = evenList;
            tempOdd = oddList;
            while (tempOdd != null)
            {
                ListNode newNode = new ListNode(tempOdd.val, null);

                if(result == null)
                {
                    result = newNode;
                }
                else
                {
                    ListNode temp = result;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = newNode;
                }
                tempOdd= tempOdd.next;
            }

            while (tempEven != null)
            {
                ListNode newNode = new ListNode(tempEven.val, null);

                if (result == null)
                {
                    result = newNode;
                }
                else
                {
                    ListNode temp = result;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = newNode;
                }
                tempEven= tempEven.next;
            }

            return result;
        }

        public void InsertAtGivenPosition(int value,int position)
        {
            ListNode newNode = new ListNode(value);
            if(position==0)
            {
                InsertAtFirstPosition(value);
                return;
            }
            if(position==size)
            {
                InsertAtLastPosition(value);
                return;
            }
            ListNode temp = head;
            int currentPositon = 0;
            
            while(currentPositon<position-1)
            {
                temp = temp.next;
                currentPositon++;
            }
            newNode.next = temp.next;
            temp.next = newNode;
            
            size++;
        }
            
        public void DeleteNodeUsingPosition(int position)
        {
            if(position==0)
            {
                head = head.next;
                size--;
                return;
            }
            else if(position == size-1)
            {
                ListNode temp = head;
                while(temp.next!=tail)
                {
                    temp = temp.next;
                }
                temp.next = null;
                size--;
            }
            else
            {
                ListNode temp = head;
                int currentPosition = 0;

                while(currentPosition<position-1)
                {
                    temp = temp.next;
                    currentPosition++;
                }
                temp.next = temp.next.next;
                size--;
            }
        }

        public void DisplayLinkedList()
        {
            ListNode temp = head;
            while(temp != null)
            {
                Console.Write(temp.val +"-->");
                temp = temp.next;
            }
            Console.WriteLine("END");
            Console.WriteLine("Size of Linked List: "+size);
        }

        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int value)
            {
                this.val = value;
                this.next = null;
            }

            public ListNode(int value,ListNode next)
            {
                this.val = value;
                this.next = next;
            }
        }
    }
}
