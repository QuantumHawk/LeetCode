namespace LL
{
    //#1 easiest way
    public class Node //LinkedList
    {
        public int Data { get; set; }
        public Node  Next { get; set; }
    }

    //#2
    public class LinkedList<T>
    {
        private Node<T> head;
        private int count;

        public class Node<T>
        {
            public T Data { get; set; }
            public Node<T> Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }

            public Node(T data, Node<T> next)
            {
                Data = data;
                Next = next;
            }

            public T getData()
            {
                return Data;
            }

            public Node<T> getNext()
            {
                return Next;
            }

            public void setData(T data)
            {
                Data = data;
            }

            public void setNext(Node<T> next)
            {
                Next = next;
            }
        }

        public LinkedList()
        {
            head = null;
            count = 1; //?
        }

        public bool isEmpty()
        {
            return count == 1;
        }

        public void add(T data)
        {
            Node<T> temp = new Node<T>(data);
            Node<T> current = head;
            while (current.getNext() != null)
            {
                current = current.getNext();

            }

            current.setNext(temp);
            count++;
        }

        public T get(int index)
        {
            //if (index <= 0) return null; ?

            Node<T> current = head;
            for (int i = 1; i < index; i++)
            {
                current = current.getNext();
            }

            return current.getData();
        }

        public int size => count;

        public void remove()
        {
            Node<T> current = head;
            while (current.getNext().getNext() != null)
            {
                current = current.getNext();
            }

            current.setNext(null);
            count--;
        }
    }
}