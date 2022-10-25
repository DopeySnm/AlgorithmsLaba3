using AlgorithmsLaba3.DataStructures;
using AlgorithmsLaba3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Service
{
    internal class QueueAtTheClinic
    {
        private OurQueue<Ticket> queue;
        private int countTicket;
        public QueueAtTheClinic()
        {
            queue = new OurQueue<Ticket>();
            countTicket = 0;
        }
        public Ticket Put()
        {
            countTicket += 1;
            Ticket ticket = new Ticket(countTicket);
            queue.AddQueue(ticket);
            return ticket;
        }
        public Ticket Pull()
        {
            Ticket ticket = queue.DeleteQueue();
            return ticket;
        }
        public OurQueue<Ticket> GetQueue()
        {
            return queue;
        }
    }
}
