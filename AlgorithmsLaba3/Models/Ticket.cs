using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Models
{
    internal class Ticket
    {
        private int id;
        private bool fresh;
        private DateTime dateOfIssue;
        public Ticket(int id)
        {
            this.id = id;
            fresh = true;
            dateOfIssue = DateTime.Now;
        }
        public bool GetFresh()
        {
            return fresh;
        }
        public int GetId()
        {
            return id;
        }
        public void UseTicket()
        {
            fresh = false;
        }
        public void CheckTicket()
        {
            if (dateOfIssue.Year > DateTime.Now.Year &&
                dateOfIssue.Month > DateTime.Now.Month &&
                dateOfIssue.Day > DateTime.Now.Day)
            {
                fresh = false;
            }
        }
        public string TicketExpirationDate()
        {
            if (fresh == false)
            {
                return "Билет не действителен";
            }
            return "Билет действителен";
        }
    }
}
