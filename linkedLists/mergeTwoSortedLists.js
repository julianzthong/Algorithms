/*
Merge two sorted linked lists and return it as a sorted list. The list should be made by splicing together the nodes of the first two lists.

Example 1:
Input: l1 = [1,2,4], l2 = [1,3,4]
Output: [1,1,2,3,4,4]

Example 2:
Input: l1 = [], l2 = []
Output: []

Example 3:
Input: l1 = [], l2 = [0]
Output: [0]

Constraints:
The number of nodes in both lists is in the range [0, 50].
-100 <= Node.val <= 100
Both l1 and l2 are sorted in non-decreasing order.
*/
/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */
var mergeTwoLists = function(l1, l2) {
    if (!l1) return l2;
    if (!l2) return l1;

    let head = new ListNode(0);
    let result = head;
    while(l1 && l2) {

        if (l1.val <= l2.val) {
            head.next = new ListNode(l1.val);
            head = head.next
            l1 = l1.next;
        } else if (l1.val >= l2.val) {
            head.next = new ListNode(l2.val);
            head = head.next
            l2 = l2.next
        } else {
            head.next = new ListNode(l1.val);
            head = head.next;
            l1 = l1.next;

            head.next = new ListNode(l2.val);
            head = head.next;
            l2 = l2.next;
        }
    }
    while (l1 || l2) {
        if (l1) {
            head.next = new ListNode(l1.val);
            head = head.next;
            l1 = l1.next;
        }
        if (l2) {
            head.next = new ListNode(l2.val);
            head = head.next;
            l2 = l2.next;
        }
    }

    return result.next;
};