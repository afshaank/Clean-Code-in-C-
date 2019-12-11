using System.Diagnostics;

namespace GoodCodeBadCode.CH03.Coupling
{
    public class TightCouplingB
    {
        public TightCouplingB()
        {
            TightCouplingA tca = new TightCouplingA
            {
                _name = null
            };
            Debug.WriteLine("Name is " + tca._name);
        }
    }
}
