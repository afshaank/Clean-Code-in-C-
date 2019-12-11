using System;

namespace GoodCodeBadCode.CH03.Encapsulation
{
    public class Car
    {
        private string _make;
        private readonly string _model;
        private readonly int _year;

        public Car(string make, string model, int year)
        {
            _make = ValidateMake(make);
            _model = ValidateModel(model);
            _year = ValidateYear(year);
        }

        private int ValidateYear(int year)
        {
            return year >= DateTime.Now.Year - 127 ? year : DateTime.Now.Year;
        }

        private string ValidateModel(string model)
        {
            return model.Length > 3 ? model : "Invalid Model";
        }

        private string ValidateMake(string make)
        {
            if (make.Length >= 3)
                return make;
            throw new ArgumentException("Make must be three characters or more.");
        }

        public string Make
        {
            get { return _make; }
            set { _make = ValidateMake(value); }
        }

        public override string ToString()
        {
            return $"Make: {_make}, Model: {_model}, Year: {_year}";
        }
    }
}
