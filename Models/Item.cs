using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo3App.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Insert Name")]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

    }
}
