using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicRoadTrip
{
    public class Artist : IMapNode
    {
        public string Name { get; set; }
        public List<IMapNode> Recommendations { get; set; }
        public IMapNode Parent { get; set; }
        public List<IMapNode> Children { get; set; }
        public List<Album> Albums { get; set; }

        public Artist(string name)
        {
            Name = name;
            Recommendations = null;
            Parent = null;
            Children = null;
            Albums = null;
        }

        private GetLastFMInfo()
        {

        }
    }
}
