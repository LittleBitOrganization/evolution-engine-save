using UnityEngine;
using UnityEngine.Scripting;

namespace LittleBit.Modules.SaveModule
{
    
    public class JsonDataSaver : IDataSaver
    {
        [Preserve]
        public JsonDataSaver()
        {
            
        }
        
        public void SaveData(string key, object data)
        {
            var jsonData = JsonUtility.ToJson(data);
            PlayerPrefs.SetString(key, jsonData);
        }

        public T LoadData<T>(string key)
        {
            return JsonUtility.FromJson<T>(PlayerPrefs.GetString(key));
        }
    }
}