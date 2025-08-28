

namespace LeetcodeProblems
{
    internal class DLL
    {
        public ListNode head;
        public ListNode tail;
        public int size;

        public DLL()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public void InsertationInFirstPosition(int value)
        {
            ListNode newNode = new ListNode(value);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }
            size++;
        }

        public void InsertationInLastPosition(int value)
        {
            ListNode newNode = new ListNode(value);
            if (tail==null)
            {
                tail = newNode;
                head = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }
            size++;
        }

        public void InsertationInSpecificPosition(int value,int position)
        {
            if (position < 0 || position > size)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            if (position == 0)
            {
                InsertationInFirstPosition(value);
                return;
            }
            if (position == size)
            {
                InsertationInLastPosition(value);
                return;
            }
            ListNode newNode = new ListNode(value);

            ListNode temp = head;
            int currentPosition = 0;    
            while(currentPosition < position - 1)
            {
                temp = temp.next;
                currentPosition++;
            }   
            newNode.next = temp.next;
            temp.next.prev = newNode;

            temp.next = newNode;
            newNode.prev = temp;

            size++;
        }


        public void DeleteNodeUsingPosition(int position)
        {
            if (position == 0)
            {
                if (head == tail)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    head = head.next;
                    head.prev = null;
                }
                size--;
                return;
            }
            if (position == size - 1)
            {
                tail = tail.prev;
                tail.next = null;
                size--;
                return;
            }
            ListNode temp = head;
            int currentPosition = 0;
            while (currentPosition < position-1)
            {
                temp = temp.next;
                currentPosition++;
            }
            temp.next = temp.next.next;
            temp.next.prev = temp;
            size--;
        }
        public void DisplayDoubllyLinkedList()
        {
            ListNode current = head;
            while (current != null)
            {
                Console.Write(current.val + "-->");
                current = current.next;
            }
            Console.WriteLine("END");
            Console.WriteLine("Size of List:"+size);
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode prev;

            public ListNode(int value)
            {
                this.val = value;
            }

            public ListNode(int value,ListNode next,ListNode prev)
            {
                this.val = value;
                this.next = next;
                this.prev = prev;
            }
        }
    }
}
