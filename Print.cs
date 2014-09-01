using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstThread
{
    class Print
    {
        public void PrintMethod(object message, int numberOfTimes, string threadName, int sleepTimer = 0)
        {
            if (message.GetType() != typeof(string))
            {
                throw new ArgumentException("Message must be a string!", "message");
            }

            for (int i = 0; i < numberOfTimes; i++)
            {
                Thread.Sleep(sleepTimer);
                int messageNumber = i;
                Console.WriteLine(threadName + " " + message + " " + messageNumber);
            }
        }
    }
}