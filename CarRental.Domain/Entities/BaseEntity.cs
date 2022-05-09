using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool Status { get; set; }
    }
}
