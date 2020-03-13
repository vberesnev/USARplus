using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace USAR_TestProject.Model
{
    class MessagesList: IEnumerable
    {
        private readonly string SAVE_PATH;
        
        [JsonProperty]
        private List<IMessage> messages;
        [JsonIgnore]
        public int MessageCount => messages.Count;

        public MessagesList() 
        {
            SAVE_PATH = Path.Combine(System.Environment.CurrentDirectory, "data.json");
            messages = new List<IMessage>();
        }

        public async void AddAsync(IMessage message)
        {
            messages.Add(message);
            await Task.Run(() => Save());
        }

        private void Save()
        {
            try
            {
                string json = JsonConvert.SerializeObject(messages, Formatting.Indented);
                File.WriteAllText(SAVE_PATH, json, Encoding.UTF8);
            }
            catch(Exception ex)
            {
                throw new Exception($"Ошибка сохранения данных: {ex.Message}");
            }
        }

        public void Load()
        {
            try
            {
                if (!File.Exists(SAVE_PATH))
                    return;
                string json = File.ReadAllText(SAVE_PATH, Encoding.UTF8);
                messages = JsonConvert.DeserializeObject<List<Message>>(json).ToList<IMessage>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        public IMessage GetLastMessage()
        {
            return messages.OrderByDescending(x => x.SaveDate).First();
        }

        public IEnumerator GetEnumerator()
        {
            foreach (IMessage message in messages)
            {
                yield return message;
            }
        }
    }
}
