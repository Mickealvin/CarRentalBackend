using CarRental.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain.Entities
{
    public class Employee: BaseEntity
    {
        public string Name { get; set; }
        public string IDCard { get; set; }
        public WorkShift WorkShift { get; set; }
        public double ComissionPercentage { get; set; }
        public DateTime HireDate { get; set; }
    }
}
