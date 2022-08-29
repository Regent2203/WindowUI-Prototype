using System.Collections.Generic;
using System;
using Model.Messages;

namespace Model
{
    public class MessagesModel : IModel
    {
        private Dictionary<int, Message> _messages = new Dictionary<int, Message>();
        public event Action ModelUpdated;
        public Dictionary<int, Message> Messages => _messages;


        public MessagesModel()
        {
            Init();
        }

        public void Init()
        {
            LoadFromServer();
#if DEBUG
            LoadFake();
#endif
        }

        private void LoadFromServer() //not implemented for prototype
        {
            //_shopItems.Clear();

            //загружаем откуда-нибудь все имеющиеся сообщения для данного пользователя, например, с сервера, в формате JSON, затем парсим/десереализуем в объекты
            //_messages = JSON.Deserialize(...);
        }

        private void LoadFake()
        {
            _messages.Clear();

            var exampleList = new List<Message>()
            {
                new Message(138119, "Приветствие", "Добро пожаловать в систему.", new DateTime(2020, 01, 01)),
                new Message(166280, "Покупка", "Вы успешно приобрели товар 'Премиум на месяц'", new DateTime(2020, 01, 03)),
                new Message(213444, "Напоминание", "Вы не заходили в игру уже 230 дней...", new DateTime(2022, 06, 06)),
            };

            foreach (var message in exampleList)
                AddMessage(message);
        }

        private void AddMessage(Message msg)
        {
            _messages.Add(msg.Id, msg);
        }

        public void TryDeleteMessage(int id)
        {
            if (_messages.ContainsKey(id))
            {
                //Server.SendRequest("DeleteMessage", id).OnComplete(); //отправляем на сервер запрос на удаление сообщения в почте пользователя
                OnComplete(); //debug

                void OnComplete()
                {
                    _messages.Remove(id);
                    ModelUpdated?.Invoke();
                }
            }
        }
    }
}