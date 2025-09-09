
namespace ConsoleApp2
{
    internal class Insert_LLdata_At_Tail
    {
        static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
        {
            SinglyLinkedListNode toAdd = new SinglyLinkedListNode(data);
            if (head == null)
            {
                return toAdd;
            }
            SinglyLinkedListNode curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
            }
            //This while loop terminates after getting last node
            curr.next = toAdd;
            return head;


        }
    }
}
