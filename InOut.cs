using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class InOut 
    {
        public void Output(int depth)
        {
            Console.WriteLine(depth);
        }

        public void Input(Saka root, int[] data)
        {
            int k = 0;
            CreateTree(root, data, ref k);
        }
        
        private void CreateTree(Saka saka, int[] data, ref int k)
        {
            //Adding nodes recursively in DepthFirstSearch-like order 
            int num = data[k];
            saka.sakos = new List<Saka>();
            for (int i = 0; i < num; i++)
            {
                saka.sakos.Add(new Saka());
                k++;
                CreateTree(saka.sakos[i], data, ref k);
            }
        }
    }
}
