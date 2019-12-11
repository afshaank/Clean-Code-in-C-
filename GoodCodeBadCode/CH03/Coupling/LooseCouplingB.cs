using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace GoodCodeBadCode.CH03.Coupling
{
    public class LooseCouplingB
    {
        [SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value")]
        public LooseCouplingB()
        {
            LooseCouplingA lca = new LooseCouplingA();
            lca = null;
            Debug.WriteLine($"Name is {lca.Name}");
        }
    }
}
