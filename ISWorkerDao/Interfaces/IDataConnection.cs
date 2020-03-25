namespace ISWorker.Dao.Interfaces
{
    public interface IDataConnection
    {
        bool TestStringConnection(IConnectionConfig configuration);
    }
}