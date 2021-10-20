public interface IDataSaver
{
    void SaveData(string key, object data);
    T LoadData<T>(string key);
}