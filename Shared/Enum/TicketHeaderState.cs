using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureTest.Shared.Enum
{
    public enum TicketHeaderState
    {
        Delegate = 0,
        InProgress = 1,
        WaitingForCustomer=2,
        Finished = 3
    }
}
