public interface ISaver
{
    void SaveData(string key, object data);
    T LoadData<T>(string key);
}