using System;
using System.Collections.Generic;

namespace Task2
{
    class Saka
    {
        public List<Saka> sakos;
    }

    public class Program
    {
        readonly Saka root;
        public int depth;

        public Program(int[] data)
        {
            InOut io = new InOut();
            Algorithm algo = new Algorithm();

            root = new Saka();
            io.CreateTree(root, data);
            
            depth = algo.FindDepth(root);
            io.OutputTreeDepth(depth);
        }

        static void Main(string[] args)
        {
            //Data of tree example given in the task
            //Shows node's number of children in DepthFirstSearch-like order
            //Other examples are in test project
            //Tree cannot be empty
            int[] data = { 2, 1, 0, 3, 1, 0, 2, 1, 0, 0, 0 };
            new Program(data);  
        }
    }
}
