

namespace ConsoleApp2
{
    internal class Insert_LLdata_AtPosition
    {
        static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode llist, int data, int position)
        {
            // Returns the input list without modification; actual logic to be implemented here.
            SinglyLinkedListNode toAdd = new SinglyLinkedListNode(data);
            if (llist == null)
            {
                return llist;
            }
            SinglyLinkedListNode prevNode = llist;
            for (int i = 0; i < position - 1; i++)
            {
                prevNode = prevNode.next;
            }
            toAdd.next = prevNode.next;
            prevNode.next = toAdd;

            return llist;
        }
    }
}
