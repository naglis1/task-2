using System;
using System.Collections.Generic;

namespace Task2
{
    class Saka
    {
        public List<Saka> sakos;
    }

    class Program
    {
        Program()
        {
            InOut io = new InOut();
            Algorithm algo = new Algorithm();

            root = new Saka();
            io.Input(root, data);
            
            depth = algo.FindDepth(root);
            io.Output(depth);
        }

        Saka root;
        int depth;
        //Data of tree example given in the task. Shows node's number of children in DepthFirstSearch-like order
        readonly int[] data = { 2, 1, 0, 3, 1, 0, 2, 1, 0, 0, 0 };
        
        static void Main(string[] args)
        {
            new Program();  
        }
    }
}
