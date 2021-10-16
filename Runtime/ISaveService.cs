public interface ISaveService
{
    void SaveData(string key, object data);
    T LoadData<T>(string key);
}