using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.DAL.Entities
{
   public  class Preferences
    {
        public Preferences()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PreferencesID { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserID { get; set; }

        [ForeignKey("Product")]
        public int? ProductID { get; set; }

        public int VisitNumber { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual Product Products { get; set; }
    }
}
