namespace ISWorker.Dao.Interfaces
{
    public interface IConnectionConfig
    {
        string DataBase { get; set; }
        string ServerName { get; set; }
        string Username { get; set; }
        string Password { get; set; }
    }

}