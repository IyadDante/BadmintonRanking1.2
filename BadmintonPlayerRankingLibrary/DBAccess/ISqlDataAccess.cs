
namespace DataAccess.DbAccess
{
    public interface ISqlDataAccess
    {
        List<T> LoadData<T, U>(string sqlStatement, U parameters, string conncectionId = "SqlConnection");
        void SaveData<T>(string sqlStatement, T parameters, string conncectionId = "SqlConnection");
    }
}