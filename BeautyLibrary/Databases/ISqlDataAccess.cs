using System.Collections.Generic;

namespace BeautyLibrary.Databases
{
    public interface ISqlDataAccess
    {
        List<T> LaodData<T, U>(string sqlStatement, U parameters, string connectionStringName, bool isStoredProcedure = false);
        int SaveData<T>(string sqlStatement, T parameters, string connectionStringName, bool isStoredProcedure = false);
    }
}