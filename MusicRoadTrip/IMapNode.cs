using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicRoadTrip
{
    public interface IMapNode
    {
        string Name { get; set; }
        List<IMapNode> Recommendations { get; set; }
        IMapNode Parent { get; set; }
        List<IMapNode> Children { get; set; }

    }
}
