using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;

namespace NorthWebApp.Domain
{
    public class Territory
    {
        [StringLength(20)]
        public string TerritoryID { get; set; }

        [Required]
        //[StringLength(50)]
        [MaxLength(50, ErrorMessage = "Flaco no pongas mas de 50 caracteres !")]
        [Display(Name = "Descripcion")]
        public string TerritoryDescription { get; set; }

        public int RegionID { get; set; }

        public virtual Region Region { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}