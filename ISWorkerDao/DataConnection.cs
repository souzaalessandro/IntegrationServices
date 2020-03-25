using System;
using ISWorker.Dao.Interfaces;

namespace ISWorker.Dao
{
    public class DataConnection : IDataConnection,IConnectionConfig
    {
        public DataConnection()
        {

        }

        string IConnectionConfig.DataBase { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IConnectionConfig.ServerName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IConnectionConfig.Username { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IConnectionConfig.Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool TestStringConnection(IConnectionConfig configuration)
        {
            throw new NotImplementedException();
        }
    }
}
