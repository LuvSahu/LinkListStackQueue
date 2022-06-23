namespace DataStructure

{
    public class Program
    {
        public static void Main(String[] args)
        {
            //LinkedList linked = new LinkedList();
            //Node node1 = new Node(70);
            //Node node2 = new Node(56);
            //Node node3 = new Node(30);
            //linked.AddNode(node1);
            //linked.AddNode(node2);
            //linked.AddNode(node3);
            //linked.Display();

            LinkedList Link = new LinkedList();
            Node node1 = new Node(70);
            Node node2 = new Node(56);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            Node node5 = new Node(95);

            //Link.AddNode(node1);
            //Link.AddNode(node2);
            //Link.AddNode(node3);
            //Link.Display();


            //Console.WriteLine("\n");
            //Link.AppendNode(node4);
            //Console.WriteLine("\n");
            //Link.Display();


            //Link.DeleteNodeAtFirst();

            //Link.Display();

            //Console.WriteLine("\n Insert a node Btw");
            //Link.InsertNode(node5, node2);
            //Link.Display();

            //Link.DeleteNodeAtLast();
            //Console.WriteLine("\n Delete at node at last");
            //Link.Display();




            //Stack
            Stack stack = new Stack();

            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);
            stack.DisplayStack();
            stack.Top();
            stack.DisplayStack();




            //Queue
            Queue queue = new Queue();
            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.DisplayQueue();
            queue.Deenque();
            queue.DisplayQueue();

        }


    }


}


