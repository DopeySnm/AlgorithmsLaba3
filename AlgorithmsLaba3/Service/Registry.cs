using AlgorithmsLaba3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Service
{
    internal class Registry
    {
        private string name;
        public QueueAtTheClinic queue; 
        public Registry(string name, QueueAtTheClinic queue)
        {
            this.queue = queue;
            this.name = name;
        }
        public void Consultation()
        {
            Ticket ticket = queue.Pull();
            Console.WriteLine($"Номер {ticket.GetId()} пройдите в регестатур {name}");
            ticket.CheckTicket();
            if (ticket.GetFresh())
            {
                Console.WriteLine("Пациент проконсультирован");
            }
            else
            {
                Console.WriteLine("Истёк срок годности билета");
            }
            ticket.UseTicket();
        }
    }
}
