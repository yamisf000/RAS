using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HakunaMatata.Models.DataModels
{
    public partial class Level
    {
        public Level()
        {
            Agent = new HashSet<Agent>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "LevelName is required.")]
        [StringLength(50, ErrorMessage = "LevelName must not exceed 50 characters.")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "LevelName must contain letters and spaces only.")]
        public string LevelName { get; set; }

        public virtual ICollection<Agent> Agent { get; set; }
    }
}
