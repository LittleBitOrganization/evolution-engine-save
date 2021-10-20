public class SaveService : IService, ISaveService
{
    private IDataSaver _dataDataSaver;

    public SaveService(IDataSaver dataDataSaver)
    {
        _dataDataSaver = dataDataSaver;
    }

    public void SaveData(string key, object data)
    {
        _dataDataSaver.SaveData(key, data);
    }

    public T LoadData<T>(string key)
    {
        return _dataDataSaver.LoadData<T>(key);
    }
}