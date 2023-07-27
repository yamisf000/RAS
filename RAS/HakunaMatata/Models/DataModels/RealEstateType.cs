using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HakunaMatata.Models.DataModels
{
    public partial class RealEstateType
    {
        public RealEstateType()
        {
            RealEstate = new HashSet<RealEstate>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "RealEstateTypeName is required.")]
        [StringLength(50, ErrorMessage = "RealEstateTypeName must not exceed 50 characters.")]
        public string RealEstateTypeName { get; set; }

        public virtual ICollection<RealEstate> RealEstate { get; set; }
    }
}
