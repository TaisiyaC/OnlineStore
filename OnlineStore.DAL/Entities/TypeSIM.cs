using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.DAL.Entities
{
    public class TypeSIM
    {
        public TypeSIM()
        {
            SIMs = new HashSet<SIM>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeSimlID { get; set; }

        public int SIMNumber { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string SIMType { get; set; }

        public virtual ICollection<SIM> SIMs { get; set; }

    }
}
