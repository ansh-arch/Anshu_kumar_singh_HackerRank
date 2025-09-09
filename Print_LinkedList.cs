
namespace ConsoleApp2
{
    internal class Print_LinkedList
    {
        static void printLinkedList(SinglyLinkedListNode head)
        {
            while (head != null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }

        }
    }
}
