using System.ComponentModel.DataAnnotations;

namespace Shooping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }
        //Data notations validaciones
        [Display(Name = "Country")]
        [MaxLength(50, ErrorMessage = "{0}  must have maximum {1} characters.")]
        [Required(ErrorMessage = "{0} is mandatory.")]
        public string Name { get; set; }

    }
}
