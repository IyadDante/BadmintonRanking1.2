namespace BadmintonPlayerRankingLibrary.Models
{
    public class PlayersRankingModel
    {
        public int Id { get; set; }
        public int PlayerID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? SinglesPoints { get; set; }
        public string? SinglesRanking { get; set; }
        public string? DoublesPoints { get; set; }
        public string? DoublesRanking { get; set; }
        public string? MixedPoints { get; set; }
        public string? MixedRanking { get; set; }
        public string? OverallPoints { get; set; }
        public string? OverallRanking { get; set; }

    }
}
