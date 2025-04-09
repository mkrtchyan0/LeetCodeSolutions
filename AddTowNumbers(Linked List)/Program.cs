namespace AddTowNumbers_Linked_List_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 2, 4, 3 };
            int[] nums2 = { 5, 6, 4 };

            ListNode list1 = CreateListFromArray(nums1);
            ListNode list2 = CreateListFromArray(nums2);

            ListNode result = AddTwoNumbers(list1, list2);

            while (result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }
        }
        public static ListNode CreateListFromArray(int[] arr)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;
            foreach (int num in arr)
            {
                current.next = new ListNode(num);
                current = current.next;
            }
            return dummy.next;
        }
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            int carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                int val1 = (l1 != null) ? l1.val : 0;
                int val2 = (l2 != null) ? l2.val : 0;

                int sum = val1 + val2 + carry;
                carry = sum / 10;

                current.next = new ListNode(sum % 10);
                current = current.next;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }

            return dummy.next;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
