namespace Runner.Algorithms;

public partial class Solution {
  public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
    ListNode result = new();

    while(list1 != null && list2 != null)
    {

    }

    return result;
  }

  public class ListNode {
    public int val;
    public ListNode? next;
    public ListNode(int val=0, ListNode? next = null) {
        this.val = val;
        this.next = next;
    }
  }
}

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */