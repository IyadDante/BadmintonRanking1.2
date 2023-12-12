using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonPlayerRankingLibrary.Models
{
    public class PlayerModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Club is required.")]
        public string Club { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Age Group is required.")]
        public string AgeGroup { get; set; }

        [Required(ErrorMessage = "Year Of Birth is required.")]
        public string YearOfBirth { get; set; }
    }
}
