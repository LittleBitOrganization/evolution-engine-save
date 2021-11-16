using LittleBit.Modules.CoreModule;

namespace LittleBit.Modules.SaveModule
{
    public class SaveService : ISaveService
    {
        private IDataSaver _dataSaver;

        public SaveService(IDataSaver dataSaver)
        {
            _dataSaver = dataSaver;
        }

        public void SaveData(string key, object data)
        {
            _dataSaver.SaveData(key, data);
        }

        public T LoadData<T>(string key) where T : Data
        {
            return _dataSaver.LoadData<T>(key);
        }
    }
}