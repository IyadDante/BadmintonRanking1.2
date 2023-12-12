using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonPlayerRankingLibrary.Models
{
    public class ClubModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Club Name is required.")]
        public string clubName { get; set; }
        [Required(ErrorMessage = "Description Name is required.")]
        public string Description { get; set; }
    }
}
