using ProjetoAgendamento.Service.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgendamento.Service.Domain.Entities
{
    public class Voucher
    {
        public string Code { get; private set; }
        public decimal? DiscountPercentage { get; private set; }
        public decimal? DiscountValue { get; private set; }
        public DiscountTypeVoucher DiscountTypeVoucher { get; private set; }

        public DateTime ExpirationDate { get; private set; }
        public bool Active { get; set; }
        public bool Used { get; set; }

        public Voucher(string code, decimal? discountPercentage, decimal? discountValue, DiscountTypeVoucher discountTypeVoucher, DateTime expirationDate, bool active, bool used)
        {
            Code = code;
            DiscountPercentage = discountPercentage;
            DiscountValue = discountValue;
            DiscountTypeVoucher = discountTypeVoucher;
            ExpirationDate = expirationDate;
            Active = active;
            Used = used;
        }
    }
}
