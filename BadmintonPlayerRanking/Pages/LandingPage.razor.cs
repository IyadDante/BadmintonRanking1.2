using BadmintonPlayerRankingLibrary.Data;
using BadmintonPlayerRankingLibrary.Models;

namespace BadmintonPlayerRanking.Pages;
public partial class LandingPage
{
    List<ClubModel> ClubsList { get; set; }

    protected override void OnInitialized()
    {
        ClubsList = _db.GetClubs();
    }
}