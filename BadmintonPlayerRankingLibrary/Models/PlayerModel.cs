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
        public string? DateOfBirth { get; }
        public int GenderID { get; set; }
        public string? GenderName { get; set; }
        public int ClubID { get; set; }
        public string? ClubName { get; set; }
        public int AgeGroupID { get; set; }
        public string? AgeGroupName { get; set; }

    }
}
