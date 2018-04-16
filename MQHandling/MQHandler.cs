using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MQHandling
{
    public class MQHandler <T>
    {

        private string ConnectionString = @"FormatName:direct=os:";
        private string ConnectionName = @".\private$\";
        private MessageQueue mq; 


        //check if exists
        //Create
        //Send
        //receive 

        public MQHandler(string name, bool CreateIfNotExists)
        {
            ConnectionName += name;

            if(CreateIfNotExists)
            {
                if(!MessageQueue.Exists(ConnectionName)) {

                    MessageQueue.Create(ConnectionName);
                }
            }
            mq = new MessageQueue(ConnectionString + ConnectionName);
            mq.Formatter = new XmlMessageFormatter( new Type[]
                {  typeof(T)});
        }

        public void Send (T data)
        {
            mq.Send(data);
        } 

        public T Receive ()
        {
            return (T)mq.Receive().Body;
        } 

    }
}
