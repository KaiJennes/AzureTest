using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzureTest.Shared.Enum;

namespace AzureTest.Shared.Model
{
    public class TicketHeader
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ResponsibleContactName { get; set; }
        public TicketHeaderState State { get; set; }


    }
}
