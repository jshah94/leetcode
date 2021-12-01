using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Graph
    {
        public string name;
        public List<Graph> children = new List<Graph>();

        public Graph(string name)
        {
            this.name = name;
        }
		public List<string> BreadthFirstSearch(List<string> array)
		{
			
			Queue<Graph> graphs = new Queue<Graph>();
			graphs.Enqueue(this);
            while (graphs.Count > 0)
            {
				var g = graphs.Dequeue();
				array.Add(g.name);
				for (int i = 0; i < g.children.Count; i++)
				{
					graphs.Enqueue(g.children[i]);
				}
			}
			
			// Write your code here.
			return array;
		}

		public Graph AddChild(string name)
		{
			Graph child = new Graph(name);
			children.Add(child);
			return this;
		}
	}
}
