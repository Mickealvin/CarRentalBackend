using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain.Entities
{
    public class Model: BaseEntity
    {
        public string Description { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
