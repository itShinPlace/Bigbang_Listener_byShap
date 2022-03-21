using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Bigbang.Listener.Models {
    
    [Table("BigResult")]
    public class BigResult {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int A { get; set; }

        public string B { get; set; }

    }
}
