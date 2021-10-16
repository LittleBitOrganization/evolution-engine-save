public class SaveService : IService, ISaveService
{
    private ISaver _dataSaver;

    public SaveService(ISaver dataSaver)
    {
        _dataSaver = dataSaver;
    }

    public void SaveData(string key, object data)
    {
        _dataSaver.SaveData(key, data);
    }

    public T LoadData<T>(string key)
    {
        return _dataSaver.LoadData<T>(key);
    }
}