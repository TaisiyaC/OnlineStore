using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.DAL.Entities
{
   public  class Camera
    {

        public Camera()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CameraID { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string Megapixels { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(200)]
        public string Flash { get; set; }

        public bool Autofocus { get; set; }

        public bool VideoRecording { get; set; }

        [InverseProperty("FrontCam")]
        public virtual Product FrontCamProducts { get; set; }

        [InverseProperty("MainCam")]
        public virtual Product MainCamProducts { get; set; }
    }

    


}
