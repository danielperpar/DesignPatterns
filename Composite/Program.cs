using System;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();

            Console.WriteLine("Client: I get a simple leaf component");
            var leaf = new Leaf();
            client.ClientCode1(leaf);


            Console.WriteLine("Client: I get a tree");
            var tree = new Composite();
            var branch1 = new Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            tree.Add(branch1);
            var branch2 = new Composite();
            branch2.Add(new Leaf());
            tree.Add(branch2);
            client.ClientCode1(tree);

            Console.WriteLine("Client: I manage a tree");
            client.ClientCode2(tree, new Leaf());

        }
    }
}
