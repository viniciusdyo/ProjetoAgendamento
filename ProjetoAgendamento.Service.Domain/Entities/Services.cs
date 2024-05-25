using ProjetoAgendamento.Service.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgendamento.Service.Domain.Entities
{
    public class Services
    {
        public Guid Id { get; private set; }
        public string? Name { get; private set; }
        public string? Description { get; private set; }
        public ServiceType ServiceType { get; private set; }
        public ServiceStatus ServiceStatus { get; private set; } = ServiceStatus.Disabled;
        public bool VoucherUsed { get; set; }
        public Voucher Voucher { get; private set; }
        public double Price { get; private set; }
    }
}
