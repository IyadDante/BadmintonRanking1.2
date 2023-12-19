using BadmintonPlayerRankingLibrary.Models;


namespace BadmintonPlayerRanking.Pages;

public partial class HomePage
{
    private List<PlayersRankingModel> PlayersRankingList { get; set; }
    private int pageSize = 10;
    private int currentPage = 1;
    private int pageCount;

    public PlayerModel PlayerLookUp { get; set; }

    protected override void OnInitialized()
    {
        PlayersRankingList = _db.GetAllPlayersRanking();
        pageCount = (int)Math.Ceiling(PlayersRankingList.Count / (double)pageSize);
    }

    private void HandlePageChanged(int newPage)
    {
        currentPage = newPage;
    }

}
