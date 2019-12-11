namespace GoodCodeBadCode.CH03.LawOfDemeter
{
    public class Database
    {
        public Database()
        {
            Connection = new Connection();
        }

        public Connection Connection { get; set; }

        public void OpenConnection()
        {
            Connection.Open();
        }
    }
}
