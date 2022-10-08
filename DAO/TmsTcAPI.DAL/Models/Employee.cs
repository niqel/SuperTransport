using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Addresses = new HashSet<Addresses>();
            CalendarEmployee = new HashSet<CalendarEmployee>();
            Operator = new HashSet<Operator>();
            Usuarios = new HashSet<Usuarios>();
        }

        public int Id { get; set; }
        public string GivenName { get; set; }
        public string PaternalSurname { get; set; }
        public string MaternalSurname { get; set; }
        public int NumEmpleyeeZam { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Email { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime? Birthday { get; set; }
        public string Picture { get; set; }
        public string SignatureUrl { get; set; }
        public float? HoldDiscountPercentage { get; set; }
        public DateTime? HiringDate { get; set; }
        public DateTime? QuitDate { get; set; }
        public string Phone { get; set; }
        public string Rfc { get; set; }
        public string Sar { get; set; }
        public string Nickname { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string BirthPlace { get; set; }
        public string Genre { get; set; }
        public string MaritalStatus { get; set; }
        public float? DailyIntegratedSalary { get; set; }
        public string Curp { get; set; }
        public int? IaveCardNumber { get; set; }
        public float? MinimumSalaryQuantity { get; set; }
        public bool Sindicalizado { get; set; }
        public string EmergencyPhone { get; set; }
        public bool SalaryIncluded { get; set; }
        public bool PerdiemIncluded { get; set; }
        public bool StaysIncluded { get; set; }
        public bool CompensationIncluded { get; set; }
        public float? Pensionpercentage { get; set; }
        public string Imss { get; set; }
        public int CEmployeeTypeid { get; set; }

        public virtual CEmployeeType CEmployeeType { get; set; }
        public virtual ICollection<Addresses> Addresses { get; set; }
        public virtual ICollection<CalendarEmployee> CalendarEmployee { get; set; }
        public virtual ICollection<Operator> Operator { get; set; }
        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
