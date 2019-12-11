using System.Diagnostics;

namespace GoodCodeBadCode.CH03.Coupling
{
    public class LooseCouplingA
    {
        private readonly string _name;
        private readonly string _stringIsEmpty = "String is empty";

        public string Name
        {
            get
            {
                if (_name.Equals(string.Empty))
                    return _stringIsEmpty;
                else
                    return _name;
            }

            set
            {
                if (value.Equals(string.Empty))
                    Debug.WriteLine("Exception: String length must be greater than zero.");
            }
        }
    }
}
