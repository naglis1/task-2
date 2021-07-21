using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Algorithm
    {
        public int FindDepth(Saka saka)
        {
            int max = 0;

            for (int i = 0; i < saka.sakos.Count; i++)
            {
                //Finding depth of the deepest subtree
                int d = FindDepth(saka.sakos[i]);
                if (d > max)
                {
                    max = d;
                }
            }

            //Returning deepest subtree's depth plus current node
            return max + 1;
        }
    }
}
