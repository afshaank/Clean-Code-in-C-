namespace GoodCodeBadCode.CH03.LawOfDemeter
{
    public class Example
    {
        public void BadExample_Chaining()
        {
            var report = new Report();
            report.Database.Connection.Open();
        }

        public void GoodExample()
        {
            var report = new Report();
            report.OpenConnection();
        }
    }
}
