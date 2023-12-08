using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class PlayerModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? DateOfBirth { get;}
        public string? GenderID { get; }
        public string? ClubID { get; }
        public string? AgeGroupID { get; }
    }
}
