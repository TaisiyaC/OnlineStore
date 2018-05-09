using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.DAL.Entities
{
    public class Product
    {
        public Product()
        {
            PreOrders = new HashSet<PreOrder>();
            Orders = new HashSet<Order>();
            Materials = new HashSet<Material>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [ForeignKey("Dimensions")]
        public int? DimensionsID { get; set; }

        [ForeignKey("PhoneDiagonal")]
        public int? PhoneDiagonalID { get; set; }

        [ForeignKey("Navigation")]
        public int? NavigationID { get; set; }

        [ForeignKey("CPU")]
        public int? CpuID { get; set; }

        [ForeignKey("Sim")]
        public int? SimID { get; set; }

        [ForeignKey("Storage")]
        public int? StorageID { get; set; }

        [ForeignKey("FrontCam")]
        public int? FrontCamID { get; set; }

        [ForeignKey("MainCam")]
        public int? MainCamID { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string ProductName { get; set; }

        public int ProductPrice { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string ProductDescription { get; set; }

        public virtual ICollection<PreOrder> PreOrders{ get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Material> Materials { get; set; }
        public virtual Dimension Dimensions { get; set; }
        public virtual PhoneDiagonal PhoneDiagonal { get; set; }
        public virtual Navigation Navigation { get; set; }
        public virtual CPU CPU { get; set; }
        public virtual SIM SIM { get; set; }
        public virtual Storage Storage { get; set; }
        public virtual Camera FrontCam { get; set; }
        public virtual Camera MainCam { get; set; }
    }
}
