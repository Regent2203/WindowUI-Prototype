using System;

namespace Model.Messages
{
    public class Message
    {
        public readonly int Id;
        public readonly string Title;
        public readonly string Body;
        public readonly DateTime DateSent;

        public Message(int id, string title, string body, DateTime dateSent)
        {
            Id = id;
            Title = title;
            Body = body;
            DateSent = dateSent;
        }
    }
}