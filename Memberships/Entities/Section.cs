using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Memberships.Entities
{
    [Table("Section")] //nazwa tablicy
    public class Section
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //zwiekszałoby Id automatycznie dla kazdego nowego wiersza. Id jest automatycznie wymagane, ni trzeba dodawac required
        public int Id { get; set; }
        [MaxLength(255)] //max długość tytułu
        [Required]
        public string Title { get; set; }
    }
}