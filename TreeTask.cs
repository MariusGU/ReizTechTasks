using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTechTasks
{
    internal class TreeTask
    {
        private Branch tree =  new Branch();
        private int depth;
        public TreeTask()
        {
            List<int> dephts = new List<int>();
            CreateTree();
            TraverseTreeDepth(1, tree, dephts);
            depth = dephts.Max();
        }
        private void CreateTree()
        {
            //second layer
            tree.branches.Add(new Branch());
            tree.branches.Add(new Branch());

            //third layer
            tree.branches[0].branches.Add(new Branch());
            tree.branches[1].branches.Add(new Branch());
            tree.branches[1].branches.Add(new Branch());
            tree.branches[1].branches.Add(new Branch());

            //fourth layer
            tree.branches[1].branches[0].branches.Add(new Branch());
            tree.branches[1].branches[1].branches.Add(new Branch());
            tree.branches[1].branches[1].branches.Add(new Branch());

            //fifth layer
            tree.branches[1].branches[1].branches[0].branches.Add(new Branch());
        }
        private void TraverseTreeDepth(int currentDepth, Branch tree, List<int> depths)
        { 
            if(tree.branches.Count > 0)
            {
                foreach(Branch branch in tree.branches)
                {
                    TraverseTreeDepth(currentDepth + 1, branch, depths);
                } 
            }
            depths.Add(currentDepth);
        }
        public int GetDepth()
        {
            return depth;
        }
    }
}
