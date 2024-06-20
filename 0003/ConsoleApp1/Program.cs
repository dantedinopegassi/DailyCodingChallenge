// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/********************************************************************|
| Given the root to a binary tree, implement serialize(root), which  |
| serializes the tree into a string, and deserialize(s), which       |
| deserializes the string back into the tree.                        |
|                                                                    |
| For example, given the following Node class                        |
|                                                                    |
| class Node:                                                        |
|     def __init__(self, val, left=None, right=None):                |
|         self.val = val                                             |
|         self.left = left                                           |
|         self.right = right                                         |
|                                                                    |
| The following test should pass:                                    |
|                                                                    |
| node = Node('root', Node('left', Node('left.left')), Node('right'))|
| assert deserialize(serialize(node)).left.left.val == 'left.left'   |
|********************************************************************/
/*********************|
|       root          |
|       / \           |
|      1   7          |
|       \   \         |
|        2   8        |
|       / \   \       |
|      3   4   9      |
|         / \         |
|        5   6        |
|*********************/

//Node('root', Node('nodo1', null, Node('nodo2', Node('nodo3', null, null), Node('nodo4', Node('nodo5', null, null), Node('nodo6', null, null)))), Node('nodo7', null, Node('nodo8', null, Node('nodo9', null, null))))

Node root = Data.CrearMockData();
Console.WriteLine(Serializar(root));

string Serializar(Node coso)
{
    string stringcito = coso.toString();
    return stringcito;
}
