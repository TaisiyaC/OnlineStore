using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.DAL.Entities
{
    public class Address
    {
        public Address()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressID { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string City{ get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Street { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string House { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Index { get; set; }

        public ApplicationUser User { get; set; }

        public Address Lecture { get; set; }
    }
}
