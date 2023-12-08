using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonPlayerRankingLibrary.Models
{
    public class PlayerModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? YearOfBrith { get; }
        public string? Gender { get; }
        public string? Club { get; }
        public string? AgeGroup { get; }
    }
}
