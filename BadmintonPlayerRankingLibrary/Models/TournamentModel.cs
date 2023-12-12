using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonPlayerRankingLibrary.Models
{
    public class TournamentModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tournament Name is required.")]
        public string? TournamentName { get; set; }
        [Required(ErrorMessage = "Tournament Date is required.")]
        public DateTime TournamentDate { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        public string? Description { get; set; }

    }
}
