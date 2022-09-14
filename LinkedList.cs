namespace labs_assignment
{
    public class LinkedList
    {

        public int Count { get; private set; } = 0;
        public Node NodeHead { get; set; }
        public List<Node> Nodes { get; set; }
        private Type DataType { get; set; }

        public LinkedList()
        {
            Nodes = new List<Node>();
        }

        public void Add(object nodeData)
        {
            Type typeOfNewData = nodeData.GetType();

            Node newNode = new Node(nodeData);

            if (NodeHead != null)
            {
                if (typeOfNewData == DataType)
                {
                    Node previousNode = NodeHead;

                    newNode.Next = previousNode;
                }
                else
                {
                    throw new Exception("LinkedList supports only one data type");
                }
            }
            else
            {
                DataType = typeOfNewData;
            }

            Nodes.Insert(0, newNode);

            NodeHead = newNode;

            Count += 1;
        }

        public void PrintNodes()
        {
            Console.WriteLine("\nPrinting all nodes");

            foreach (Node node in Nodes)
            {
                node.PrintData();

                Console.Write(", ");
            }
        }
    }
}
