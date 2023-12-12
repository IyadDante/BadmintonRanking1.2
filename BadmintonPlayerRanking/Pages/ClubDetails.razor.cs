using BadmintonPlayerRankingLibrary.Data;
using BadmintonPlayerRankingLibrary.Models;
using Microsoft.AspNetCore.Components;

namespace BadmintonPlayerRanking.Pages
{
    public partial class ClubDetails
    {
        [Inject]
        private ISqlData _db { get; set; }

        private List<ClubModel> clubsList;
        private ClubModel newClub;

        protected override void OnInitialized()
        {
            clubsList = _db.GetAllClubs();
            newClub = new ClubModel();
        }

        private void CreateNewClub()
        {
            _db.InsertClub(newClub);
            clubsList = _db.GetAllClubs();
        }
    }
}
