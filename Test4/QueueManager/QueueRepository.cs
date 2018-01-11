using Store;
using System;
using System.Collections.Generic;
using System.Messaging;

namespace QueueManager
{
    public interface IQueueRepository
    {
        bool Add(Player player);

        List<Player> GetAll();
    }

    public class QueueRepository : IQueueRepository
    {
        string description = "This is a test queue.";
        string path = @".\Private$\DOSqueue";

        public bool Add(Player player)
        {
            MessageQueue messageQueue = null;
            bool success = false;
           
            try
            {
                if (MessageQueue.Exists(path))
                {
                    messageQueue = new MessageQueue(path);
                    messageQueue.Label = description;
                }
                else
                {
                    MessageQueue.Create(path);
                    messageQueue = new MessageQueue(path);
                    messageQueue.Label = description;
                }

                messageQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(Player) });
                messageQueue.Send(player);
                success = true;
                return success;
            }
            catch
            {
                throw;
            }
            finally
            {
                messageQueue.Dispose();
            }
        }

        public List<Player> GetAll()
        {
            List<Player> list = new List<Player>();

            using (MessageQueue messageQueue = new MessageQueue(path))
            {
                System.Messaging.Message[] messages = messageQueue.GetAllMessages();

                foreach (System.Messaging.Message message in messages)
                {                    
                    message.Formatter = new XmlMessageFormatter(new Type[] { typeof(Player) });

                    list.Add((Player)message.Body);
                }
            }

            return list;
        }
    }
}