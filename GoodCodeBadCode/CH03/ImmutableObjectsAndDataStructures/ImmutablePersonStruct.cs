namespace GoodCodeBadCode.CH03.ImmutableObjectsAndDataStructures
{
    public struct ImmutablePersonStruct
    {
        private readonly int _id;
        private readonly string _firstName;
        private readonly string _lastName;

        public int Id => _id;
        public string FirstName => _firstName;
        public string LastName => _lastName;
        public string FullName => $"{_firstName} {_lastName}";
        public string FullNameReversed => $"{_lastName}, {_firstName}";

        public ImmutablePersonStruct(int id, string firstName, string lastName)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
        }

    }
}
