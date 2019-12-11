namespace GoodCodeBadCode.CH03.LawOfDemeter
{
    public class Report
    {
        public Report()
        {
            Database = new Database();
        }

        public Database Database { get; set; }

        public void OpenConnection()
        {
            Database.OpenConnection();
        }
    }
}
