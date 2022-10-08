using System;
using System.Collections.Generic;

namespace TmsTcAPI.DAL.Models
{
    public partial class CAddressType
    {
        public CAddressType()
        {
            Addresses = new HashSet<Addresses>();
        }

        public int Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<Addresses> Addresses { get; set; }
    }
}
