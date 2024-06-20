public class Data
    {
        public static Node CrearMockData()
        {
            Node nodo9 = new Node("nodo9");
            Node nodo8 = new Node("nodo8", null, nodo9);
            Node nodo7 = new Node("nodo7", null, nodo8);
            Node nodo6 = new Node("nodo6");
            Node nodo5 = new Node("nodo5");
            Node nodo4 = new Node("nodo4", nodo5, nodo6);
            Node nodo3 = new Node("nodo3");
            Node nodo2 = new Node("nodo2", nodo3, nodo4);
            Node nodo1 = new Node("nodo1", null, nodo2);
            Node root = new Node("root", nodo1, nodo7);

            return root;
        }
    }