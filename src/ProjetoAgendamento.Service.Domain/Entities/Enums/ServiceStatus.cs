using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgendamento.Service.Domain.Entities.Enums
{
    public enum ServiceStatus
    {
        Disabled = 0,
        Available = 1,
        Scheduled = 2,
        InProcess = 3,
        InProgress = 4,
        Done = 5,
    }
}
