using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class LinkedListProblems
    {
        public LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
        {
            // Write your code here.
            var current = linkedList;
            while (current != null)
            {
                var nextDistinct = current.next;
                while (nextDistinct != null && nextDistinct.value == current.value)
                {
                    nextDistinct = nextDistinct.next;
                }
                current.next = nextDistinct;
                current = nextDistinct;
            }
            return linkedList;
        }

        public LinkedList SumOfLinkedLists(LinkedList linkedListOne, LinkedList linkedListTwo)
        {
            // Write your code here.
            StringBuilder listOne = new StringBuilder("");
            StringBuilder listTwo = new StringBuilder("");
            var current = linkedListOne;
            while (current != null)
            {
                listOne.Append(current.value);
                current = current.next;
            }
            current = linkedListTwo;
            while (current != null)
            {
                listTwo.Append(current.value);
                current = current.next;
            }
            var num1Array = listOne.ToString().ToCharArray();
            var num2Array = listTwo.ToString().ToCharArray();
            Array.Reverse(num2Array);
            Array.Reverse(num1Array);

            var sumCharArray = (Convert.ToInt32(num1Array.ToString()) + Convert.ToInt32(num2Array.ToString())).ToString().ToCharArray();
            Array.Reverse(sumCharArray);
            string sum = sumCharArray.ToString();
            LinkedList response = new LinkedList(Convert.ToInt32(sum[0]));
            current = response.next;
            for (int i = 1; i < sum.Length; i++)
            {
                current.next = new LinkedList(Convert.ToInt32(sum[0]));
                current = current.next;
            }
            return response;
        }


        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)

        {

            ListNode result = new ListNode();
            ListNode resultCurrent = result;
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                int sum = 0;
                if (l1 != null && l2 != null)
                {
                    sum = l1.val + l2.val + carry;
                    l1 = l1.next;
                    l2 = l2.next;
                }
                else if (l1 != null)
                {
                    sum = l1.val + carry;
                    l1 = l1.next;
                }
                else if (l2 != null)
                {
                    sum = l2.val + carry;
                    l2 = l2.next;
                }
                else if (carry > 0)
                {
                    sum = carry;
                }

                if (sum >= 10)
                {
                    resultCurrent.val = sum % 10;
                    carry = 1;
                }
                else
                {
                    resultCurrent.val = sum;
                    carry = 0;
                }
                if (l1 != null || l2 != null || carry > 0)
                {
                    resultCurrent.next = new ListNode();
                    resultCurrent = resultCurrent.next;
                }
            }
            return result;
        }

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            head = new ListNode(1);
            head.next = new ListNode(2);
            //head.next.next = new ListNode(3);
            //head.next.next.next = new ListNode(4);
            //head.next.next.next.next = new ListNode(5);
            Stack<ListNode> stack = new Stack<ListNode>();
            var current = head;
            while (current != null)
            {
                stack.Push(current);
                current = current.next;
            }
            int counter = 0;
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                counter++;
                if (counter == n)
                {
                    if (stack.Count > 0)
                    {
                        var prev = stack.Pop();
                        prev.next = node.next;
                    }
                    else
                    {
                        head = node.next;
                        break;
                    }
                }
            }
            return head;
        }

        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode current = head;
            head = head.next;
            head.next = current;

            current = current.next.next;

            while (current != null)
            {

            }

            return head;
        }

        public static ListNode ReverseList(ListNode head)
        {
            ListNode hd = new ListNode();
            ReverseList(head, hd);
            return hd.next;
        }

        public static ListNode ReverseList(ListNode node, ListNode head)
        {
            ListNode parent;
            if (node.next != null)
            {
                parent = ReverseList(node.next, head);
                node.next = null;
            }
            else
            {
                head.next = node;
                return node;
            }
            parent.next = node;
            return parent.next;
        }

        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return head;
            ListNode prev = head;
            ListNode current = head.next;
            while (current != null)
            {
                if (prev.val == current.val)
                {
                    prev.next = current.next;
                    current = prev.next;
                }
                else
                {
                    prev = prev.next;
                    if (prev.next == null)
                        break;
                    current = prev.next;
                }
            }
            return head;
        }

        public ListNode OddEvenList(ListNode head)
        {
            if (head == null)
                return head;
            ListNode odd = head;
            ListNode even = head.next;
            ListNode evenHead = even;

            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }
            odd.next = evenHead;
            return head;
        }

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (null == headA || null == headB)
                return null;

            ListNode curA = headA;
            ListNode curB = headB;
            while (curA != curB)
            {
                curA = curA == null ? headB : curA.next;
                curB = curB == null ? headA : curB.next;
            }
            return curA;
        }

        public static ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || head.next == null)
                return head;
            int listLength = GetListLength(head);
            if (k > listLength)
            {
                int n = listLength;
                k = k % n;
            }
            ListNode first = head;
            ListNode second = head;
            int i = 0;
            while (i < k && second != null)
            {
                i++;
                second = second.next;
            }
            if (second == null)
                return head;
            while (second.next != null)
            {
                second = second.next;
                first = first.next;
            }
            second.next = head;
            head = first.next;
            first.next = null;
            return head;
        }
        public static int GetListLength(ListNode head)
        {
            if (head == null)
                return 0;
            int length = 0;
            var current = head;
            while (current != null)
            {
                length++;
                current = current.next;
            }
            return length;
        }
    }
}
