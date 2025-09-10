

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
            if (head == null)
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

        public void InsertAtLastPosition(int value)
        {
            ListNode newNode = new ListNode(value);

            if (head == null)
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
            int i = 0;
            while (curr != null)
            {
                i++;
                ListNode newNode = new ListNode(curr.val, null);
                if (i % 2 == 0)
                {
                    if (evenList == null)
                    {
                        evenList = newNode;
                    }
                    else
                    {
                        newNode.next = evenList;
                        evenList = newNode;
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
                        newNode.next = oddList;
                        oddList = newNode;
                    }
                }
                curr = curr.next;
            }

            ListNode result = null;
            ListNode tempEven = evenList;
            ListNode tempOdd = oddList;


            while (tempEven != null)
            {
                ListNode newNode = new ListNode(tempEven.val, null);

                if (result == null)
                {
                    result = newNode;
                }
                else
                {
                    newNode.next = result;
                    result = newNode;
                }
                tempEven = tempEven.next;
            }


            while (tempOdd != null)
            {
                ListNode newNode = new ListNode(tempOdd.val, null);

                if (result == null)
                {
                    result = newNode;
                }
                else
                {
                    newNode.next = result;
                    result = newNode;
                }
                tempOdd = tempOdd.next;
            }

            return result;
        }

        public void InsertAtGivenPosition(int value, int position)
        {
            ListNode newNode = new ListNode(value);
            if (position == 0)
            {
                InsertAtFirstPosition(value);
                return;
            }
            if (position == size)
            {
                InsertAtLastPosition(value);
                return;
            }
            ListNode temp = head;
            int currentPositon = 0;

            while (currentPositon < position - 1)
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
            if (position == 0)
            {
                head = head.next;
                size--;
                return;
            }
            else if (position == size - 1)
            {
                ListNode temp = head;
                while (temp.next != tail)
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

                while (currentPosition < position - 1)
                {
                    temp = temp.next;
                    currentPosition++;
                }
                temp.next = temp.next.next;
                size--;
            }
        }

        public ListNode RemoveNthFromEnd(int n)
        {
            ListNode temp = head;
            int size = 0;
            while (temp != null)
            {
                temp = temp.next;
                size++;
            }
            temp = head;
            if (size == n)
            {
                head = head.next;
                return head;
            }

            while (size > n + 1)
            {
                temp = temp.next;
                size--;
            }
            temp.next = temp.next.next;

            return head;
        }


        public ListNode DeleteMiddle()
        {
            ListNode temp = head;
            int size = 0;
            while (temp != null)
            {
                temp = temp.next;
                size++;
            }
            int middleIndex = Convert.ToInt32(Math.Floor(size / 2.00));
            Console.Write(middleIndex);
            temp = head;
            size = 0;

            if (middleIndex == 0)
            {
                head = head.next;
                return head;
            }
            while (temp != null && size < middleIndex - 1)
            {
                temp = temp.next;
                size++;
            }
            temp.next = temp.next.next;

            return head;
        }


        public ListNode AddTowNumber(ListNode l1, ListNode l2)
        {
            ListNode currentL1 = l1;
            ListNode currentL2 = l2;
            ListNode result = null;
            int carry = 0;  

            while (currentL1 != null || currentL2 !=null)
            {
                int nodeOneValue = 0;
                int nodeTwoValue = 0;   
                
                if(currentL1 != null)
                {
                    nodeOneValue = currentL1.val;
                    currentL1 = currentL1.next;
                }
                if(currentL2 != null)
                {
                    nodeTwoValue = currentL2.val;
                    currentL2 = currentL2.next;
                }
                int sum = nodeOneValue + nodeTwoValue + carry;
                carry = sum / 10;
                ListNode newNode = new ListNode(sum % 10);
                if(result == null)
                {
                    result = newNode;
                }
                else
                {
                    ListNode temp = result;
                    while(temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = newNode; 
                }
            }

            if(carry > 0)
            {
                ListNode newNode = new ListNode(carry);
                ListNode temp = result;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }

            return result;
        }

        public ListNode AddTwoNumberApproch2(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            ListNode temp = result;
            int carry = 0;

            while (l1 != null || l1 != null  || carry>0)
            {
                int sum = 0;
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                sum += carry;
                carry = sum / 10;
                ListNode newNode = new ListNode(sum % 10);
                temp.next = newNode;
                temp = temp.next;
            }
            return result.next;
        }


        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            ListNode curr=head;
            ListNode result=new ListNode(0);
            ListNode tempResult = result;
            ListNode reverseList = null;

            int size = 0;
            while (curr != null)
            {
                size++;

                if(size>=left && size<=right)
                {
                    ListNode newNode = new ListNode(curr.val);
                    if (reverseList == null)
                    {
                        reverseList = newNode;
                    }
                    else
                    {
                        newNode.next = reverseList;
                        reverseList = newNode;
                    }
                }
                curr = curr.next;
            }

            size = 0;
            curr = head;
            ListNode tempReverse = reverseList;

            while (curr != null)
            {
                size++;
                ListNode newNode = new ListNode(curr.val); 
                
                if (size >= left && size <= right)
                {
                    newNode = new ListNode(tempReverse.val);
                    tempReverse = tempReverse.next;
                }
                tempResult.next = newNode;
                tempResult = tempResult.next;
                curr = curr.next;            
            }

            return result.next;
        }

        public void ReorderList(ListNode head)
        {
            if(head == null || head.next == null)
            {
                return;
            }
            ListNode slow = head;
            ListNode fast = head;
            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            ListNode prev = null;
            ListNode curr = slow;
            ListNode next = null;
            while(curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            ListNode first = head;
            ListNode second = prev;
            while(second.next != null)
            {
                ListNode temp1 = first.next;
                first.next = second;
                first = temp1;
                ListNode temp2 = second.next;
                second.next = first;
                second = temp2;
            }
        }

        public void ReorderListApproch2(ListNode head)
        {
            if(head == null || head.next == null)
            {
                return;
            }

            ListNode curr = head;
            ListNode reverseList= null; 

            while(curr != null)
            {
                ListNode newNode = new ListNode(curr.val);
                if(reverseList == null)
                {
                    reverseList = newNode;
                }
                else
                {
                    newNode.next = reverseList;
                    reverseList = newNode;
                }
                curr = curr.next;
            }

            curr = head;
            ListNode slow=head;
            ListNode fast=head;
            ListNode currentReverse = reverseList;
            ListNode result=new ListNode(0);
            ListNode tempResult = result;

            while (fast != null && fast.next != null)
            {
                ListNode newNode = new ListNode(slow.val);              
                tempResult.next = newNode;
                tempResult = tempResult.next;
                ListNode newNodeFromReverse = new ListNode(currentReverse.val);              
                tempResult.next = newNodeFromReverse;
                tempResult = tempResult.next;


                slow = slow.next;
                fast = fast.next.next;
                curr = curr.next;
                currentReverse= currentReverse.next;
            }
            if (curr != null)
            {
                ListNode newNode = new ListNode(slow.val);
                tempResult.next = newNode;
            }

            ListNode p1 = head;
            ListNode p2 = result.next;
            while (p1 != null && p2 != null)
            {
                p1.val = p2.val;
                p1 = p1.next;
                p2 = p2.next;
            }
        }

        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if(head == null || head.next == null || k <= 1)
            {
                return head;
            }

            ListNode curr = head;
            int size = 0;
            while(curr != null)
            {
                size++;
                curr = curr.next;
            }

            int neededReverse = size / k;
            curr = head;

            ListNode result = null;
            while (neededReverse > 0)
            {
                int count = 0;
               
                while (curr!=null && count<k )
                {
                    ListNode newNode = new ListNode(curr.val);  
                    if(result == null)
                    {
                        result = newNode;
                    }
                    else
                    {
                        if(count==0)
                        {
                            ListNode tempResult = result;
                            while(tempResult != null)
                            {
                                tempResult = tempResult.next;
                            }
                            tempResult = newNode;
                        }
                        else
                        {
                            newNode.next = result;
                            result = newNode;
                        }                          
                    }
                    curr = curr.next;
                    count++;
                }
                neededReverse--;
            }

            while(curr != null)
            {
                ListNode newNode = new ListNode(curr.val);
                result.next = newNode;
                curr = curr.next;
            }

            return head;

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
