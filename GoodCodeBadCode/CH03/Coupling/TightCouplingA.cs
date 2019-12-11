using System.Diagnostics;

namespace GoodCodeBadCode.CH03.Coupling
{
    public class TightCouplingA
    {
        public string _name;

        public string Name
        {
            get
            {
                if (!_name.Equals(string.Empty))
                    return _name;
                else
                    return "String is empty!";
            }
            set
            {
                if (value.Equals(string.Empty))
                    Debug.WriteLine("String is empty!");
            }
        }
    }
}
