
using static LeetcodeProblems.LeetCodeLinkedList;

namespace LeetcodeProblems
{
    public class LinkeList
    {
        private Node head;
        private Node tail;
        private int size;

        public LinkeList()
        {
            this.size = 0;
        }

        public void InsertionInLastPosition(int value)
        {
            Node newNode = new Node(value);

            if(head==null)
            {
                head = newNode;
                tail = newNode;
                size++;
                return;
            }

            tail.next = newNode;
            tail = newNode;
            size++;
        }

        public void InsertionInFirstPosition(int value)
        {
            Node newNode = new Node(value);
            if(head==null)
            {
                head = newNode;
                tail = newNode;
                size++;
                return;
            }
            newNode.next = head;
            head = newNode;
            size++;
        }

        public void InsertionInSpecificPosition(int value,int indexPosition)
        {
            if(head==null)
            {
                InsertionInLastPosition(value);
                return;
            }
            if(indexPosition==0)
            {
                InsertionInFirstPosition(value);
                return;
            }
            if(indexPosition==size)
            {
                InsertionInLastPosition(value);
                return;
            }

            Node newNode = new Node(value);
            Node temp= head;
            int index = 0;
            while(index<indexPosition-1)
            {
                temp = temp.next;
                index++;
            }
            newNode.next = temp.next;
            temp.next = newNode;
            
            size++;
        }

        public void DeleteDuplicates()
        {
            Node node = head;

            while (node != null && node.next != null)
            {
                if(node.value ==node.next.value)
                {
                    node.next = node.next.next;
                    size--;
                }
                else
                {
                    node = node.next;
                }
            }
            tail = node;
            tail.next = null;
        }

        public void DisplayLinkedList()
        {
            Node current = head;
            while(current!=null)
            {
                Console.Write(current.value +"-->");
                current = current.next;
            }
            Console.WriteLine("END");
            Console.WriteLine("Size-->" + size);
        }

        public class Node
        {
            public int value;
            public Node next;

            public Node(int value)
            {
                this.value = value;
                this.next = null;
            }

            public Node(int value, Node next)
            {
                this.value = value;
                this.next = next;
            }
        }
     
    }

}
