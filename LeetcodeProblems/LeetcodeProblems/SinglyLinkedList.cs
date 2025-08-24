
namespace LeetcodeProblems
{
    public class SinglyLinkedList
    {
        private Node head;

        public void Add(int value)
        {
            Node newNode = new Node(value);
            if (head==null)
            {
                head = newNode;
                return;
            }

            Node current=head;

            while (current.next!=null)
            {
                current=current.next;
            }
            current.next=newNode;
        }

        public void PrintList()
        {
            Node current=head;
            while (current!=null)
            {
                System.Console.Write(current.value+" -> ");
                current=current.next;
            }
            System.Console.WriteLine("null");
        }
    }
}
