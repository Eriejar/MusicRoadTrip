using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicRoadTrip
{
    public class RoadMap
    {
        IMapNode Origin;
        IMapNode Focus;

        List<IMapNode> Nodes
        {
            get { return GetNodes(Origin); }
        }

        public void MoveFocusToOrigin()
        {
            Focus = Origin;
        }

        public void MoveFocusToParent()
        {
            Focus = Focus.Parent;
        }

        private List<IMapNode> GetNodes(IMapNode root)
        {
            var nodes = new List<IMapNode>();
            nodes.Add(root);
            foreach (IMapNode node in root.Children)
            {
                nodes.AddRange(GetNodes(node));
            }

            return nodes.OrderBy(x => x.Name).ToList();
        }


    }
}
