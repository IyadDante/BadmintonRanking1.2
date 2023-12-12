// TournamentDetails.razor.cs

using BadmintonPlayerRankingLibrary.Data;
using BadmintonPlayerRankingLibrary.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace BadmintonPlayerRanking.Pages
{
    public partial class TournamentDetails
    {

        [Inject]
        private ISqlData _db { get; set; }

        private List<TournamentModel> tournamentsList;
        private TournamentModel newTournament;
        private EditContext editContext;

        protected override void OnInitialized()
        {
            tournamentsList = _db.GetAllTournaments();
            newTournament = new TournamentModel();
        }

        private void CreateNewTournament()
        {
            _db.InsertTournament(newTournament);
            tournamentsList = _db.GetAllTournaments();
            newTournament = new TournamentModel();
        }

    }
}
